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
        ///Follow `address` through its follow gate. `wallet` is the caller's wallet hint (LAST argument,
        ///0 = act as the sender): it is verified (`principalOf`, a wrong hint reverts) and the gate is
        ///checked against the verified context (`Gate.mustCheckFor`, principal-resolution spec §6.3, Q4).
        ///The follow itself stays keyed by the spender (Q5).
        ///</summary>
        /// <param name="mbrPayment"> </param>
        /// <param name="gateTxn"> </param>
        /// <param name="address"> </param>
        /// <param name="wallet"> </param>
        public async Task GatedFollow(PaymentTransaction mbrPayment, ApplicationCallTransaction gateTxn, Algorand.Address address, ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, gateTxn });
            byte[] abiHandle = { 159, 92, 24, 189 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPayment, gateTxn, addressAbi, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GatedFollow_Transactions(PaymentTransaction mbrPayment, ApplicationCallTransaction gateTxn, Algorand.Address address, ulong wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, gateTxn });
            byte[] abiHandle = { 159, 92, 24, 189 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPayment, gateTxn, addressAbi, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///LEGACY shim (pre-hint selector, deployed semantics: Gate.mustCheck on Txn.sender). Phase 4 removes it.
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
        ///Deployed tip route, decided on `creator` (legacy shims and the deployed plugins' quotes).
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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWtpdGFTb2NpYWxHcmFwaCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBa2l0YVNvY2lhbE1CUkRhdGEiOlt7Im5hbWUiOiJmb2xsb3dzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImJsb2NrcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwb3N0cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2b3RlbGlzdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZWFjdGlvbnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmVhY3Rpb25saXN0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1ldGEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibW9kZXJhdG9ycyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiYW5uZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWN0aW9ucyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZWZUeXBlcyIsInR5cGUiOiJ1aW50NjQifV0sIkJsb2NrTGlzdEtleSI6W3sibmFtZSI6InVzZXIiLCJ0eXBlIjoiYnl0ZVsxNl0ifSx7Im5hbWUiOiJibG9ja2VkIiwidHlwZSI6ImJ5dGVbMTZdIn1dLCJGb2xsb3dzS2V5IjpbeyJuYW1lIjoidXNlciIsInR5cGUiOiJieXRlWzE2XSJ9LHsibmFtZSI6ImZvbGxvd2VyIiwidHlwZSI6ImJ5dGVbMTZdIn1dLCJWaWV3UGF5V2FsbFZhbHVlIjpbeyJuYW1lIjoidXNlclBheUluZm8iLCJ0eXBlIjoiVmlld1BheVdhbGxWYWx1ZVVzZXJQYXlJbmZvW10ifSx7Im5hbWUiOiJhZ2VudFBheUluZm8iLCJ0eXBlIjoiVmlld1BheVdhbGxWYWx1ZVVzZXJQYXlJbmZvW10ifV0sInRpcE1CUkluZm8iOlt7Im5hbWUiOiJ0eXBlIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoiYXJjNTgiLCJ0eXBlIjoidWludDY0In1dLCJWaWV3UGF5V2FsbFZhbHVlVXNlclBheUluZm8iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjoiQ3JlYXRlIG1ldGhvZCB0byBpbml0aWFsaXplIHRoZSBjb250cmFjdCB3aXRoIHRoZSBEQU8gcmVmZXJlbmNlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhRGFvIiwiZGVzYyI6IlRoZSBBa2l0YSBEQU8gYXBwIElEIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2ZXJzaW9uIiwiZGVzYyI6IlRoZSB2ZXJzaW9uIHN0cmluZyBmb3IgdGhpcyBjb250cmFjdCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJibG9jayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bmJsb2NrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdhdGVkRm9sbG93IiwiZGVzYyI6IkZvbGxvdyBgYWRkcmVzc2AgdGhyb3VnaCBpdHMgZm9sbG93IGdhdGUuIGB3YWxsZXRgIGlzIHRoZSBjYWxsZXIncyB3YWxsZXQgaGludCAoTEFTVCBhcmd1bWVudCxcbjAgPSBhY3QgYXMgdGhlIHNlbmRlcik6IGl0IGlzIHZlcmlmaWVkIChgcHJpbmNpcGFsT2ZgLCBhIHdyb25nIGhpbnQgcmV2ZXJ0cykgYW5kIHRoZSBnYXRlIGlzXG5jaGVja2VkIGFnYWluc3QgdGhlIHZlcmlmaWVkIGNvbnRleHQgKGBHYXRlLm11c3RDaGVja0ZvcmAsIHByaW5jaXBhbC1yZXNvbHV0aW9uIHNwZWMgwqc2LjMsIFE0KS5cblRoZSBmb2xsb3cgaXRzZWxmIHN0YXlzIGtleWVkIGJ5IHRoZSBzcGVuZGVyIChRNSkuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFwcGwiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnYXRlVHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdhdGVkRm9sbG93IiwiZGVzYyI6IkxFR0FDWSBzaGltIChwcmUtaGludCBzZWxlY3RvciwgZGVwbG95ZWQgc2VtYW50aWNzOiBHYXRlLm11c3RDaGVjayBvbiBUeG4uc2VuZGVyKS4gUGhhc2UgNCByZW1vdmVzIGl0LiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhcHBsIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ2F0ZVR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZm9sbG93IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVuZm9sbG93IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzQmxvY2tlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJsb2NrZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc0ZvbGxvd2luZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZm9sbG93ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Rm9sbG93SW5kZXgiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZvbGxvd2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1ZlcnNpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUFraXRhREFPIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wVXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWJyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVmVHlwZU5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZlR5cGVTY2hlbWEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkFraXRhU29jaWFsTUJSRGF0YSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBheVdhbGxNYnIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKCh1aW50OCx1aW50NjQsdWludDY0KVtdLCh1aW50OCx1aW50NjQsdWludDY0KVtdKSIsInN0cnVjdCI6IlZpZXdQYXlXYWxsVmFsdWUiLCJuYW1lIjoicGF5d2FsbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrVGlwTWJyUmVxdWlyZW1lbnRzIiwiZGVzYyI6IkRlcGxveWVkIHRpcCByb3V0ZSwgZGVjaWRlZCBvbiBgY3JlYXRvcmAgKGxlZ2FjeSBzaGltcyBhbmQgdGhlIGRlcGxveWVkIHBsdWdpbnMnIHF1b3RlcykuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50OCx1aW50NjQpIiwic3RydWN0IjoidGlwTUJSSW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTY0Ml0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDM2LDIxMjQsMjIzNV0sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDU1XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyckFmbHciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDI0XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyckF1dG8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTUsMjM0NF0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJCYW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM3Nl0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJCbGtkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjA4XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyckVibGsiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MDksMTM4OV0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJGZ3RlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ0MV0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJIZ3RlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA0M10sImVycm9yTWVzc2FnZSI6IkVSUjplcnJIbmJkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTQ3XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyckhud2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NjZdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJySHRvcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1NV0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJJcG1hIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMwXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycklwbXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzE5XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyckl1cGciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDkzXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyckl3bHQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODBdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyTmNscyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2ODcsMTc1Nl0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJOZGFvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ4NV0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJOZmx3IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA1XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyck5ya3kiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzhdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyU2JsayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzOThdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyU2ZsdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2Ml0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJVbmJrIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE0NiwyMTU3LDIxNzMsMjE4NF0sImVycm9yTWVzc2FnZSI6Ikxlbmd0aCBtdXN0IGJlIDE2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY3OSwxNzQ4XSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQ5LDgwOSwxMzA4LDE2NzIsMTY5MSwxNzQxLDIwODEsMjE5MywyMjQ5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDY1LDE2NTYsMTc2NywxNzgzLDE3OTksMTg0MSwxODY1LDE4ODNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzIsMTY2MywxNzc0LDE3OTAsMTgwNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDMsNjMwLDczNCwxMjk2LDE0MTcsMTQ1NSwxNTQ5LDE1NTcsMTU4NywxNTk1LDE2MjUsMTYzMywxOTIwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1OCw3NDMsMTczNCwxOTA4LDE5MjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDQxLDIxMjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL3NvY2lhbC90eXBlcy50czo6TWV0YVZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg3OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvc29jaWFsL3R5cGVzLnRzOjpWaWV3UGF5V2FsbFZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgzMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rKHVpbnQ4LHVpbnQ2NCx1aW50NjQpW10pLChsZW4rKHVpbnQ4LHVpbnQ2NCx1aW50NjQpW10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICgobGVuKyh1aW50OCx1aW50NjQsdWludDY0KVtdKSwobGVuKyh1aW50OCx1aW50NjQsdWludDY0KVtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODI3LDE4NTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHR1cGxlIGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzI2LDEyODVdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGFwcGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTUsNzEzLDEyNzEsMTQwOF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURNeUlESWdNamcxTURBS0lDQWdJR0o1ZEdWallteHZZMnNnSW1GcmFYUmhYMlJoYnlJZ01IZ3hOVEZtTjJNM05TQWlaaUlnSWlJZ0ltSWlJREI0TURBZ0ltRmhiQ0lnSW5OaGJDSWdJblpsY25OcGIyNGlJQ0pGVWxJNlpYSnlRbUZ1WkNJZ0lrVlNVanBsY25KR1ozUmxJaUFpZDJGc2JHVjBJaUFpUlZKU09tVnljazVrWVc4aUlDSndZV3dpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJhMmwwWVZOdlkybGhiRWR5WVhCb0lHVjRkR1Z1WkhNZ1kyeGhjM05sY3loQ1lYTmxVMjlqYVdGc0xDQlZjR2R5WVdSbFlXSnNaVUZyYVhSaFFtRnpaVU52Ym5SeVlXTjBLU0I3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhsWVRreE9EQmtaQ0F2THlCdFpYUm9iMlFnSW5Wd1pHRjBaU2h6ZEhKcGJtY3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmZFhCa1lYUmxYM0p2ZFhSbFFEUUtDbTFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVd0cGRHRlRiMk5wWVd4SGNtRndhQ0JsZUhSbGJtUnpJR05zWVhOelpYTW9RbUZ6WlZOdlkybGhiQ3dnVlhCbmNtRmtaV0ZpYkdWQmEybDBZVUpoYzJWRGIyNTBjbUZqZENrZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF5TWdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdJMU9XTTRZVFUwSURCNFlXVmxZbUl6TnpnZ01IZzVaalZqTVRoaVpDQXdlRGcyTmpjMU5EazBJREI0TkdJMlpqa3dOMllnTUhneE5qRmlNMkUzWVNBd2VEUXpNRE0yTmpobElEQjRaV0kyTW1ZMU1EZ2dNSGd3T1Rnek9EQmhOQ0F3ZURNelpUa3lZemswSURCNE9EVTBaR1ZrWlRBZ01IZ3hORE15TkdaaU55QXdlR0V4TXpSaE1qYzRJREI0TXpRME1UYzFaakFnTHk4Z2JXVjBhRzlrSUNKaWJHOWpheWh3WVhrc1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0oxYm1Kc2IyTnJLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaVoyRjBaV1JHYjJ4c2IzY29jR0Y1TEdGd2NHd3NZV1JrY21WemN5eDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJGMFpXUkdiMnhzYjNjb2NHRjVMR0Z3Y0d3c1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0ptYjJ4c2IzY29jR0Y1TEdGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlkVzVtYjJ4c2IzY29ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKcGMwSnNiMk5yWldRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1dKdmIyd2lMQ0J0WlhSb2IyUWdJbWx6Um05c2JHOTNhVzVuS0dGa1pISmxjM01zWVdSa2NtVnpjeWxpYjI5c0lpd2diV1YwYUc5a0lDSm5aWFJHYjJ4c2IzZEpibVJsZUNoaFpHUnlaWE56TEdGa1pISmxjM01wZFdsdWREWTBJaXdnYldWMGFHOWtJQ0oxY0dSaGRHVkJhMmwwWVVSQlR5aDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYjNCVmNDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWJXSnlLR0o1ZEdWYlhTeHpkSEpwYm1jc1lubDBaVnRkS1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbkJoZVZkaGJHeE5ZbklvS0NoMWFXNTBPQ3gxYVc1ME5qUXNkV2x1ZERZMEtWdGRMQ2gxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwS1Z0ZEtTbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltTm9aV05yVkdsd1RXSnlVbVZ4ZFdseVpXMWxiblJ6S0hWcGJuUTJOQ3hoWkdSeVpYTnpMSFZwYm5RMk5Da29kV2x1ZERnc2RXbHVkRFkwS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHSnNiMk5ySUhWdVlteHZZMnNnWjJGMFpXUkdiMnhzYjNjZ2JHVm5ZV041UjJGMFpXUkdiMnhzYjNjZ1ptOXNiRzkzSUhWdVptOXNiRzkzSUdselFteHZZMnRsWkNCcGMwWnZiR3h2ZDJsdVp5Qm5aWFJHYjJ4c2IzZEpibVJsZUNCMWNHUmhkR1ZCYTJsMFlVUkJUeUJ0WVdsdVgyOXdWWEJmY205MWRHVkFNVGNnYldKeUlIQmhlVmRoYkd4TlluSWdZMmhsWTJ0VWFYQk5ZbkpTWlhGMWFYSmxiV1Z1ZEhNS0lDQWdJR1Z5Y2dvS2JXRnBibDl2Y0ZWd1gzSnZkWFJsUURFM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pNd0NpQWdJQ0F2THlCdmNGVndLQ2s2SUhadmFXUWdleUI5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURJeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVd0cGRHRlRiMk5wWVd4SGNtRndhQ0JsZUhSbGJtUnpJR05zWVhOelpYTW9RbUZ6WlZOdlkybGhiQ3dnVlhCbmNtRmtaV0ZpYkdWQmEybDBZVUpoYzJWRGIyNTBjbUZqZENrZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5tWTVPREUzWmpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdVb2RXbHVkRFkwTEhOMGNtbHVaeWwyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZM0psWVhSbENpQWdJQ0JsY25JS0NtMWhhVzVmZFhCa1lYUmxYM0p2ZFhSbFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk16VUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklGc25WWEJrWVhSbFFYQndiR2xqWVhScGIyNG5YU0I5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklGVndaR0YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0E5UFFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdJZ2RYQmtZWFJsQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzZZWE56WlhKMFJYaGhZM1JRWVhsdFpXNTBLSFI0YmpvZ2RXbHVkRFkwTENCeVpXTmxhWFpsY2pvZ1lubDBaWE1zSUdGdGIzVnVkRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3BoYzNObGNuUkZlR0ZqZEZCaGVXMWxiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPamMyQ2lBZ0lDQXZMeUJsZUhCdmNuUWdablZ1WTNScGIyNGdZWE56WlhKMFJYaGhZM1JRWVhsdFpXNTBLSFI0YmpvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1TENCeVpXTmxhWFpsY2pvZ1FXTmpiM1Z1ZEN3Z1lXMXZkVzUwT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIQnliM1J2SURNZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvMk9Bb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLSFI0Ymk1amJHOXpaVkpsYldGcGJtUmxjbFJ2SUQwOVBTQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNJR1Z5Y2tOc2IzTmxSbTl5WW1sa1pHVnVLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbmRIaHVjeUJEYkc5elpWSmxiV0ZwYm1SbGNsUnZDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nWVhOelpYSjBSWGhoWTNSUVlYbHRaVzUwWDJGbWRHVnlYMkZ6YzJWeWRFQTNDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBsY25KT1kyeHpJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnljazVqYkhNS0NtRnpjMlZ5ZEVWNFlXTjBVR0Y1YldWdWRGOWhablJsY2w5aGMzTmxjblJBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TmprS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaDBlRzR1Y21WclpYbFVieUE5UFQwZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxDQmxjbkpTWld0bGVVWnZjbUpwWkdSbGJpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWjNSNGJuTWdVbVZyWlhsVWJ3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJR0Z6YzJWeWRFVjRZV04wVUdGNWJXVnVkRjloWm5SbGNsOWhjM05sY25SQU9Rb2dJQ0FnY0hWemFHSjVkR1Z6SUNKRlVsSTZaWEp5VG5KcmVTSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSk9jbXQ1Q2dwaGMzTmxjblJGZUdGamRGQmhlVzFsYm5SZllXWjBaWEpmWVhOelpYSjBRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPamM0Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2RIaHVMbkpsWTJWcGRtVnlJRDA5UFNCeVpXTmxhWFpsY2l3Z1pYSnlTVzUyWVd4cFpGQmhlVzFsYm5SU1pXTmxhWFpsY2lrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJoYzNObGNuUkZlR0ZqZEZCaGVXMWxiblJmWVdaMFpYSmZZWE56WlhKMFFESUtJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPbVZ5Y2tsd2JYSWlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlTWEJ0Y2dvS1lYTnpaWEowUlhoaFkzUlFZWGx0Wlc1MFgyRm1kR1Z5WDJGemMyVnlkRUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8zT1FvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtIUjRiaTVoYlc5MWJuUWdQVDA5SUdGdGIzVnVkQ3dnWlhKeVNXNTJZV3hwWkZCaGVXMWxiblJCYlc5MWJuUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdZbTU2SUdGemMyVnlkRVY0WVdOMFVHRjViV1Z1ZEY5aFpuUmxjbDloYzNObGNuUkFOQW9nSUNBZ2NIVnphR0o1ZEdWeklDSkZVbEk2WlhKeVNYQnRZU0lLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGxjbkpKY0cxaENncGhjM05sY25SRmVHRmpkRkJoZVcxbGJuUmZZV1owWlhKZllYTnpaWEowUURRNkNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pweVpXTnZjbVJRWVhsbGNpaHlaV052Y21RNklHSjVkR1Z6TENCd1lYbGxjam9nWW5sMFpYTXNJRzkzYm1WeU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2NtVmpiM0prVUdGNVpYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qRXdOUW9nSUNBZ0x5OGdaWGh3YjNKMElHWjFibU4wYVc5dUlISmxZMjl5WkZCaGVXVnlLSEpsWTI5eVpEb2dZbmwwWlhNc0lIQmhlV1Z5T2lCQlkyTnZkVzUwTENCdmQyNWxjam9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pFd05nb2dJQ0FnTHk4Z2FXWWdLSEJoZVdWeUlDRTlQU0J2ZDI1bGNpa2dld29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUNFOUNpQWdJQ0JpZWlCeVpXTnZjbVJRWVhsbGNsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02T1RZS0lDQWdJQzh2SUhKbGRIVnliaUJDZVhSbGN5aFFZWGxsY2tKdmVGQnlaV1pwZUNrdVkyOXVZMkYwS0hOb1lUSTFOaWh5WldOdmNtUXBLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCemFHRXlOVFlLSUNBZ0lIQjFjMmhpZVhSbGN5QWlKQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem94TURjS0lDQWdJQzh2SUc5d0xrSnZlQzV3ZFhRb2NHRjVaWEpTWldOdmNtUkxaWGtvY21WamIzSmtLU3dnY0dGNVpYSXVZbmwwWlhNcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0p2ZUY5d2RYUUtDbkpsWTI5eVpGQmhlV1Z5WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZPbkpsYkdWaGMyVkVaWEJ2YzJsMEtISmxZMjl5WkRvZ1lubDBaWE1zSUc5M2JtVnlPaUJpZVhSbGN5d2dZVzF2ZFc1ME9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncHlaV3hsWVhObFJHVndiM05wZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TVRRd0NpQWdJQ0F2THlCbGVIQnZjblFnWm5WdVkzUnBiMjRnY21Wc1pXRnpaVVJsY0c5emFYUW9jbVZqYjNKa09pQmllWFJsY3l3Z2IzZHVaWEk2SUVGalkyOTFiblFzSUdGdGIzVnVkRG9nZFdsdWREWTBLVG9nVzBGalkyOTFiblFzSUhWcGJuUTJORjBnZXdvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qazJDaUFnSUNBdkx5QnlaWFIxY200Z1FubDBaWE1vVUdGNVpYSkNiM2hRY21WbWFYZ3BMbU52Ym1OaGRDaHphR0V5TlRZb2NtVmpiM0prS1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdjMmhoTWpVMkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWlRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveE5ESUtJQ0FnSUM4dklHTnZibk4wSUZ0d1lYbGxjaXdnYzNCdmJuTnZjbVZrWFNBOUlHOXdMa0p2ZUM1blpYUW9hMlY1S1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveE5ETUtJQ0FnSUM4dklHbG1JQ2doYzNCdmJuTnZjbVZrS1NCN0NpQWdJQ0JpYm5vZ2NtVnNaV0Z6WlVSbGNHOXphWFJmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qRTBOQW9nSUNBZ0x5OGdjbVYwZFhKdUlGdHZkMjVsY2l3Z1lXMXZkVzUwWFFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NuSmxiR1ZoYzJWRVpYQnZjMmwwWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNVFEyQ2lBZ0lDQXZMeUJ2Y0M1Q2IzZ3VaR1ZzWlhSbEtHdGxlU2tLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem94TkRjS0lDQWdJQzh2SUdOdmJuTjBJSFJ2ZEdGc09pQjFhVzUwTmpRZ1BTQmhiVzkxYm5RZ0t5QlFZWGxsY2xKbFkyOXlaRTFDVWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqSURRZ0x5OGdNamcxTURBS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNVE13Q2lBZ0lDQXZMeUJqYjI1emRDQmJMQ0JtZFc1a1pXUmRJRDBnYjNBdVFXTmpkRkJoY21GdGN5NWhZMk4wUW1Gc1lXNWpaU2h5WldObGFYWmxjaWtLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRUpoYkdGdVkyVUtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3hNekVLSUNBZ0lDOHZJSEpsZEhWeWJpQm1kVzVrWldRZ2ZId2dZVzF2ZFc1MElENDlJRWRzYjJKaGJDNXRhVzVDWVd4aGJtTmxDaUFnSUNCaWJub2djbVZzWldGelpVUmxjRzl6YVhSZlltOXZiRjkwY25WbFFEZ0tJQ0FnSUdSMWNBb2dJQ0FnWjJ4dlltRnNJRTFwYmtKaGJHRnVZMlVLSUNBZ0lENDlDaUFnSUNCaWVpQnlaV3hsWVhObFJHVndiM05wZEY5aWIyOXNYMlpoYkhObFFEa0tDbkpsYkdWaGMyVkVaWEJ2YzJsMFgySnZiMnhmZEhKMVpVQTRPZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtDbkpsYkdWaGMyVkVaWEJ2YzJsMFgySnZiMnhmYldWeVoyVkFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakUwT0FvZ0lDQWdMeThnY21WMGRYSnVJRnRqWVc1U1pXTmxhWFpsUVd4bmJ5aEJZMk52ZFc1MEtIQmhlV1Z5S1N3Z2RHOTBZV3dwSUQ4Z1FXTmpiM1Z1ZENod1lYbGxjaWtnT2lCdmQyNWxjaXdnZEc5MFlXeGRDaUFnSUNCaWVpQnlaV3hsWVhObFJHVndiM05wZEY5MFpYSnVZWEo1WDJaaGJITmxRRFFLSUNBZ0lITjNZWEFLQ25KbGJHVmhjMlZFWlhCdmMybDBYM1JsY201aGNubGZiV1Z5WjJWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1UUTRDaUFnSUNBdkx5QnlaWFIxY200Z1cyTmhibEpsWTJWcGRtVkJiR2R2S0VGalkyOTFiblFvY0dGNVpYSXBMQ0IwYjNSaGJDa2dQeUJCWTJOdmRXNTBLSEJoZVdWeUtTQTZJRzkzYm1WeUxDQjBiM1JoYkYwS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ3B5Wld4bFlYTmxSR1Z3YjNOcGRGOTBaWEp1WVhKNVgyWmhiSE5sUURRNkNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWlCeVpXeGxZWE5sUkdWd2IzTnBkRjkwWlhKdVlYSjVYMjFsY21kbFFEVUtDbkpsYkdWaGMyVkVaWEJ2YzJsMFgySnZiMnhmWm1Gc2MyVkFPVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlISmxiR1ZoYzJWRVpYQnZjMmwwWDJKdmIyeGZiV1Z5WjJWQU1UQUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk9rRnJhWFJoVTI5amFXRnNSM0poY0dndVkzSmxZWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1UWUtJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TWpNS0lDQWdJQzh2SUhSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVZ1BTQmhhMmwwWVVSaGJ3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakUwQ2lBZ0lDQXZMeUIyWlhKemFXOXVJRDBnUjJ4dlltRnNVM1JoZEdVOGMzUnlhVzVuUGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbFdaWEp6YVc5dUlIMHBDaUFnSUNCaWVYUmxZeUE0SUM4dklDSjJaWEp6YVc5dUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QjBhR2x6TG5abGNuTnBiMjR1ZG1Gc2RXVWdQU0IyWlhKemFXOXVDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzZRV3RwZEdGVGIyTnBZV3hIY21Gd2FDNWliRzlqYTF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtSnNiMk5yT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2prMkNpQWdJQ0F2THlCaWJHOWpheWh0WW5KUVlYbHRaVzUwT2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRzSUdGa1pISmxjM002SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk9UY0tJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2doZEdocGN5NXBjMEpoYm01bFpDaFVlRzR1YzJWdVpHVnlLU3dnWlhKeVFtRnVibVZrS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyRnNiSE4xWWlCcGMwSmhibTVsWkFvZ0lDQWdZbm9nWW14dlkydGZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJR0o1ZEdWaklEa2dMeThnSWtWU1VqcGxjbkpDWVc1a0lnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrSmhibVFLQ21Kc2IyTnJYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qazRDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvVkhodUxuTmxibVJsY2lBaFBUMGdZV1JrY21WemN5d2daWEp5VTJWc1prSnNiMk5yS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pHbG5JREVLSUNBZ0lDRTlDaUFnSUNCaWJub2dZbXh2WTJ0ZllXWjBaWEpmWVhOelpYSjBRRFVLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT21WeWNsTmliR3NpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5VTJKc2F3b0tZbXh2WTJ0ZllXWjBaWEpmWVhOelpYSjBRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRBMENpQWdJQ0F2THlCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRBMUNpQWdJQ0F2THlCMGFHbHpMbTFpY2loQ2VYUmxjeWduSnlrc0lDY25MQ0JDZVhSbGN5Z25KeWtwTG1Kc2IyTnJjeUFySUhOd2IyNXpiM0pEYjNOMEtHMWljbEJoZVcxbGJuUXVjMlZ1WkdWeUxDQlVlRzR1YzJWdVpHVnlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlJZ29nSUNBZ1pIVndiaUF5Q2lBZ0lDQmpZV3hzYzNWaUlITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem82UW1GelpWTnZZMmxoYkM1dFluSUtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQm5kSGh1Y3lCVFpXNWtaWElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3hNREVLSUNBZ0lDOHZJSEpsZEhWeWJpQndZWGxsY2lBOVBUMGdiM2R1WlhJZ1B5QXdJRG9nVUdGNVpYSlNaV052Y21STlFsSUtJQ0FnSUQwOUNpQWdJQ0JwYm5SaklEUWdMeThnTWpnMU1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFd05Rb2dJQ0FnTHk4Z2RHaHBjeTV0WW5Jb1FubDBaWE1vSnljcExDQW5KeXdnUW5sMFpYTW9KeWNwS1M1aWJHOWphM01nS3lCemNHOXVjMjl5UTI5emRDaHRZbkpRWVhsdFpXNTBMbk5sYm1SbGNpd2dWSGh1TG5ObGJtUmxjaWtLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNREl0TVRBMkNpQWdJQ0F2THlCaGMzTmxjblJGZUdGamRGQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lHMWljbEJoZVcxbGJuUXNDaUFnSUNBdkx5QWdJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQjBhR2x6TG0xaWNpaENlWFJsY3lnbkp5a3NJQ2NuTENCQ2VYUmxjeWduSnlrcExtSnNiMk5yY3lBcklITndiMjV6YjNKRGIzTjBLRzFpY2xCaGVXMWxiblF1YzJWdVpHVnlMQ0JVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdMeThnS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJoYzNObGNuUkZlR0ZqZEZCaGVXMWxiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TURnS0lDQWdJQzh2SUdOdmJuTjBJR0pzYjJOcmMwdGxlU0E5SUhSb2FYTXVZbXhyS0ZSNGJpNXpaVzVrWlhJc0lHRmtaSEpsYzNNcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnWW14ckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklHSnNiMk5yY3lBOUlFSnZlRTFoY0R4Q2JHOWphMHhwYzNSTFpYa3NJR0o1ZEdWelBEQStQaWg3SUd0bGVWQnlaV1pwZURvZ1FXdHBkR0ZUYjJOcFlXeENiM2hRY21WbWFYaENiRzlqYTNNZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltSWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakV4TVFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtDRjBhR2x6TG1Kc2IyTnJjeWhpYkc5amEzTkxaWGtwTG1WNGFYTjBjeXdnWlhKeVFXeHlaV0ZrZVVKc2IyTnJaV1FwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHSnNiMk5yWDJGbWRHVnlYMkZ6YzJWeWRFQTNDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBsY25KRllteHJJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnlja1ZpYkdzS0NtSnNiMk5yWDJGbWRHVnlYMkZ6YzJWeWRFQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakV4TWdvZ0lDQWdMeThnZEdocGN5NWliRzlqYTNNb1lteHZZMnR6UzJWNUtTNWpjbVZoZEdVb0tRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbTk0WDJOeVpXRjBaUW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVEV6Q2lBZ0lDQXZMeUJ5WldOdmNtUlFZWGxsY2loMGFHbHpMbUpzYjJOcmN5aGliRzlqYTNOTFpYa3BMbXRsZVN3Z2JXSnlVR0Y1YldWdWRDNXpaVzVrWlhJc0lGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUhKbFkyOXlaRkJoZVdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk9UWUtJQ0FnSUM4dklHSnNiMk5yS0cxaWNsQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3Z1lXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem82UVd0cGRHRlRiMk5wWVd4SGNtRndhQzUxYm1Kc2IyTnJXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFc1aWJHOWphem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TVRjS0lDQWdJQzh2SUhWdVlteHZZMnNvWVdSa2NtVnpjem9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVEU0Q2lBZ0lDQXZMeUJqYjI1emRDQmliRzlqYTNOTFpYa2dQU0IwYUdsekxtSnNheWhVZUc0dWMyVnVaR1Z5TENCaFpHUnlaWE56S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCaWJHc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdZbXh2WTJ0eklEMGdRbTk0VFdGd1BFSnNiMk5yVEdsemRFdGxlU3dnWW5sMFpYTThNRDQrS0hzZ2EyVjVVSEpsWm1sNE9pQkJhMmwwWVZOdlkybGhiRUp2ZUZCeVpXWnBlRUpzYjJOcmN5QjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRFNUNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9kR2hwY3k1aWJHOWphM01vWW14dlkydHpTMlY1S1M1bGVHbHpkSE1zSUdWeWNsVnpaWEpPYjNSQ2JHOWphMlZrS1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dkVzVpYkc5amExOWhablJsY2w5aGMzTmxjblJBTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWxJNlpYSnlWVzVpYXlJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBsY25KVmJtSnJDZ3AxYm1Kc2IyTnJYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRXlNQW9nSUNBZ0x5OGdkR2hwY3k1aWJHOWphM01vWW14dlkydHpTMlY1S1M1a1pXeGxkR1VvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE1qUUtJQ0FnSUM4dklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1USTFDaUFnSUNBdkx5QjBhR2x6TG0xaWNpaENlWFJsY3lnbkp5a3NJQ2NuTENCQ2VYUmxjeWduSnlrcExtSnNiMk5yY3dvZ0lDQWdZbmwwWldOZk15QXZMeUFpSWdvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JqWVd4c2MzVmlJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pvNlFtRnpaVk52WTJsaGJDNXRZbklLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNakl0TVRJMkNpQWdJQ0F2THlCamIyNXpkQ0JiY21WalpXbDJaWElzSUdGdGIzVnVkRjBnUFNCeVpXeGxZWE5sUkdWd2IzTnBkQ2dLSUNBZ0lDOHZJQ0FnZEdocGN5NWliRzlqYTNNb1lteHZZMnR6UzJWNUtTNXJaWGtzQ2lBZ0lDQXZMeUFnSUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lIUm9hWE11YldKeUtFSjVkR1Z6S0NjbktTd2dKeWNzSUVKNWRHVnpLQ2NuS1NrdVlteHZZMnR6Q2lBZ0lDQXZMeUFwQ2lBZ0lDQmpZV3hzYzNWaUlISmxiR1ZoYzJWRVpYQnZjMmwwQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakV5TndvZ0lDQWdMeThnYVhSNGJpNXdZWGx0Wlc1MEtIc2djbVZqWldsMlpYSXNJR0Z0YjNWdWRDQjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVEUzQ2lBZ0lDQXZMeUIxYm1Kc2IyTnJLR0ZrWkhKbGMzTTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk9rRnJhWFJoVTI5amFXRnNSM0poY0dndVoyRjBaV1JHYjJ4c2IzZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWVhSbFpFWnZiR3h2ZHpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEJ1SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE16WXRNVFF4Q2lBZ0lDQXZMeUJuWVhSbFpFWnZiR3h2ZHlnS0lDQWdJQzh2SUNBZ2JXSnlVR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhodUxBb2dJQ0FnTHk4Z0lDQm5ZWFJsVkhodU9pQm5kSGh1TGtGd2NHeHBZMkYwYVc5dVEyRnNiRlI0Yml3S0lDQWdJQzh2SUNBZ1lXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ2QyRnNiR1YwT2lCMWFXNTBOalFLSUNBZ0lDOHZJQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ1lYQndiQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVFF5Q2lBZ0lDQXZMeUJqYjI1emRDQndJRDBnY0hKcGJtTnBjR0ZzVDJZb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTd2dkMkZzYkdWMEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem94TmdvZ0lDQWdMeThnWVd0cGRHRkVRVThnUFNCSGJHOWlZV3hUZEdGMFpUeEJjSEJzYVdOaGRHbHZiajRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVFXdHBkR0ZFUVU4Z2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRnJhWFJoWDJSaGJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hORElLSUNBZ0lDOHZJR052Ym5OMElIQWdQU0J3Y21sdVkybHdZV3hQWmloMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQjNZV3hzWlhRcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem95TURZS0lDQWdJQzh2SUdOdmJuTjBJRnRoY0hCTWFYTjBRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb1lXdHBkR0ZFUVU4c0lFSjVkR1Z6S0VGcmFYUmhSRUZQUjJ4dlltRnNVM1JoZEdWTFpYbHpRV3RwZEdGQmNIQk1hWE4wS1NrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1GaGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZPVE00Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjbVZ6YjJ4MlpWQnlhVzVqYVhCaGJDaG5aWFJCYTJsMFlVRndjRXhwYzNRb1lXdHBkR0ZFUVU4cExuZGhiR3hsZEN3Z2FHbHVkQ2tLSUNBZ0lIQjFjMmhwYm5RZ09EZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakl4TWdvZ0lDQWdMeThnVkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TWpFekNpQWdJQ0F2THlCSGJHOWlZV3d1WTJGc2JHVnlRWEJ3YkdsallYUnBiMjVKWkN3S0lDQWdJR2RzYjJKaGJDQkRZV3hzWlhKQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qSXhOQW9nSUNBZ0x5OGdSMnh2WW1Gc0xtTmhiR3hsY2tGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRZV3hzWlhKQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR052ZG1WeUlEWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk1UUTRDaUFnSUNBdkx5QnBaaUFvYUdsdWRDQTlQVDBnTUNrZ2V3b2dJQ0FnWW01NklHZGhkR1ZrUm05c2JHOTNYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnY0c5d2JpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qa3pDaUFnSUNBdkx5QnZjbWxuYVc0NklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem81TlFvZ0lDQWdMeThnY21WbVpYSnlaWEk2SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3l3S0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem81TVFvZ0lDQWdMeThnZDJGc2JHVjBPaUF3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZPVEF0T1RjS0lDQWdJQzh2SUhKbGRIVnliaUI3Q2lBZ0lDQXZMeUFnSUhkaGJHeGxkRG9nTUN3S0lDQWdJQzh2SUNBZ2NISnBibU5wY0dGc09pQnpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lHOXlhV2RwYmpvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQnpjR1Z1WkdWeU9pQnpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lISmxabVZ5Y21WeU9pQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJSFpwWVZCc2RXZHBiam9nWm1Gc2MyVXNDaUFnSUNBdkx5QjlDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TUFvZ0lDQWdZMjl1WTJGMENncG5ZWFJsWkVadmJHeHZkMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk9uSmxjMjlzZG1WUWNtbHVZMmx3WVd4RGRIaEFORE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRRekNpQWdJQ0F2THlCamIyNXpkQ0I3SUdadmJHeHZkMGRoZEdWSlJDQjlJRDBnZEdocGN5NW5aWFJOWlhSaEtHRmtaSEpsYzNNcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTJGc2JITjFZaUJuWlhSTlpYUmhDaUFnSUNCbGVIUnlZV04wSURVd0lEZ0tJQ0FnSUdKMWNua2dNVEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TkRRS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaG5ZWFJsUTJobFkydERkSGdvWjJGMFpWUjRiaXdnZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlN3Z1oyRjBaVU4wZUNod0tTd2dabTlzYkc5M1IyRjBaVWxFS1N3Z1pYSnlSbUZwYkdWa1IyRjBaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1UWUtJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRRMENpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9aMkYwWlVOb1pXTnJRM1I0S0dkaGRHVlVlRzRzSUhSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVc0lHZGhkR1ZEZEhnb2NDa3NJR1p2Ykd4dmQwZGhkR1ZKUkNrc0lHVnlja1poYVd4bFpFZGhkR1VwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3pNRFFLSUNBZ0lDOHZJSEpsZEhWeWJpQjdJSEJ5YVc1amFYQmhiRG9nY0M1d2NtbHVZMmx3WVd3c0lIZGhiR3hsZERvZ2NDNTNZV3hzWlhRc0lITndaVzVrWlhJNklIQXVjM0JsYm1SbGNpQjlDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnT0NBek1nb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTUNBNENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ056SWdNeklLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWRYSjVJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZPVGd6Q2lBZ0lDQXZMeUJuWVhSbFZIaHVMbUZ3Y0Vsa0lEMDlQU0JCY0hCc2FXTmhkR2x2YmloblpYUkJhMmwwWVVGd2NFeHBjM1FvWVd0cGRHRkVRVThwTG1kaGRHVXBJQ1ltQ2lBZ0lDQmthV2NnTlFvZ0lDQWdaM1I0Ym5NZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3lNRFlLSUNBZ0lDOHZJR052Ym5OMElGdGhjSEJNYVhOMFFubDBaWE5kSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFFubDBaWE1vWVd0cGRHRkVRVThzSUVKNWRHVnpLRUZyYVhSaFJFRlBSMnh2WW1Gc1UzUmhkR1ZMWlhselFXdHBkR0ZCY0hCTWFYTjBLU2tLSUNBZ0lITjNZWEFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbUZoYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk9UZ3pDaUFnSUNBdkx5Qm5ZWFJsVkhodUxtRndjRWxrSUQwOVBTQkJjSEJzYVdOaGRHbHZiaWhuWlhSQmEybDBZVUZ3Y0V4cGMzUW9ZV3RwZEdGRVFVOHBMbWRoZEdVcElDWW1DaUFnSUNCd2RYTm9hVzUwSURRd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02T1RnekxUazROQW9nSUNBZ0x5OGdaMkYwWlZSNGJpNWhjSEJKWkNBOVBUMGdRWEJ3YkdsallYUnBiMjRvWjJWMFFXdHBkR0ZCY0hCTWFYTjBLR0ZyYVhSaFJFRlBLUzVuWVhSbEtTQW1KZ29nSUNBZ0x5OGdaMkYwWlZSNGJpNXZia052YlhCc1pYUnBiMjRnUFQwOUlFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVRtOVBjQ0FtSmdvZ0lDQWdZbm9nWjJGMFpXUkdiMnhzYjNkZlltOXZiRjltWVd4elpVQTFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzVPRFFLSUNBZ0lDOHZJR2RoZEdWVWVHNHViMjVEYjIxd2JHVjBhVzl1SUQwOVBTQlBia052YlhCc1pYUmxRV04wYVc5dUxrNXZUM0FnSmlZS0lDQWdJR1JwWnlBMENpQWdJQ0JuZEhodWN5QlBia052YlhCc1pYUnBiMjRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZPVGd6TFRrNE5Bb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1aGNIQkpaQ0E5UFQwZ1FYQndiR2xqWVhScGIyNG9aMlYwUVd0cGRHRkJjSEJNYVhOMEtHRnJhWFJoUkVGUEtTNW5ZWFJsS1NBbUpnb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1dmJrTnZiWEJzWlhScGIyNGdQVDA5SUU5dVEyOXRjR3hsZEdWQlkzUnBiMjR1VG05UGNDQW1KZ29nSUNBZ1ltNTZJR2RoZEdWa1JtOXNiRzkzWDJKdmIyeGZabUZzYzJWQU5UUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk9UZzFDaUFnSUNBdkx5Qm5ZWFJsVkhodUxtNTFiVUZ3Y0VGeVozTWdQVDA5SURRZ0ppWUtJQ0FnSUdScFp5QTBDaUFnSUNCbmRIaHVjeUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUQwOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2prNE15MDVPRFVLSUNBZ0lDOHZJR2RoZEdWVWVHNHVZWEJ3U1dRZ1BUMDlJRUZ3Y0d4cFkyRjBhVzl1S0dkbGRFRnJhWFJoUVhCd1RHbHpkQ2hoYTJsMFlVUkJUeWt1WjJGMFpTa2dKaVlLSUNBZ0lDOHZJR2RoZEdWVWVHNHViMjVEYjIxd2JHVjBhVzl1SUQwOVBTQlBia052YlhCc1pYUmxRV04wYVc5dUxrNXZUM0FnSmlZS0lDQWdJQzh2SUdkaGRHVlVlRzR1Ym5WdFFYQndRWEpuY3lBOVBUMGdOQ0FtSmdvZ0lDQWdZbm9nWjJGMFpXUkdiMnhzYjNkZlltOXZiRjltWVd4elpVQTFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzVPRFlLSUNBZ0lDOHZJR2RoZEdWVWVHNHVZWEJ3UVhKbmN5Z3dLU0E5UFQwZ2JXVjBhRzlrVTJWc1pXTjBiM0lvUjJGMFpVMTFjM1JEYUdWamEwWnZja0ZpYVUxbGRHaHZaQ2tnSmlZS0lDQWdJR1JwWnlBMENpQWdJQ0JuZEhodWMyRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEbGlNVFEzWkRKaklDOHZJRzFsZEdodlpDQWliWFZ6ZEVOb1pXTnJSbTl5S0NoaFpHUnlaWE56TEhWcGJuUTJOQ3hoWkdSeVpYTnpLU3gxYVc1ME5qUXNZbmwwWlZ0ZFcxMHBkbTlwWkNJS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPams0TXkwNU9EWUtJQ0FnSUM4dklHZGhkR1ZVZUc0dVlYQndTV1FnUFQwOUlFRndjR3hwWTJGMGFXOXVLR2RsZEVGcmFYUmhRWEJ3VEdsemRDaGhhMmwwWVVSQlR5a3VaMkYwWlNrZ0ppWUtJQ0FnSUM4dklHZGhkR1ZVZUc0dWIyNURiMjF3YkdWMGFXOXVJRDA5UFNCUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGs1dlQzQWdKaVlLSUNBZ0lDOHZJR2RoZEdWVWVHNHViblZ0UVhCd1FYSm5jeUE5UFQwZ05DQW1KZ29nSUNBZ0x5OGdaMkYwWlZSNGJpNWhjSEJCY21kektEQXBJRDA5UFNCdFpYUm9iMlJUWld4bFkzUnZjaWhIWVhSbFRYVnpkRU5vWldOclJtOXlRV0pwVFdWMGFHOWtLU0FtSmdvZ0lDQWdZbm9nWjJGMFpXUkdiMnhzYjNkZlltOXZiRjltWVd4elpVQTFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzVPRGNLSUNBZ0lDOHZJR2RoZEdWVWVHNHVZWEJ3UVhKbmN5Z3hLU0E5UFQwZ1pXNWpiMlJsUVhKak5DaGpkSGdwSUNZbUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWjNSNGJuTmhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2FXY2dOd29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk9UZ3pMVGs0TndvZ0lDQWdMeThnWjJGMFpWUjRiaTVoY0hCSlpDQTlQVDBnUVhCd2JHbGpZWFJwYjI0b1oyVjBRV3RwZEdGQmNIQk1hWE4wS0dGcmFYUmhSRUZQS1M1bllYUmxLU0FtSmdvZ0lDQWdMeThnWjJGMFpWUjRiaTV2YmtOdmJYQnNaWFJwYjI0Z1BUMDlJRTl1UTI5dGNHeGxkR1ZCWTNScGIyNHVUbTlQY0NBbUpnb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1dWRXMUJjSEJCY21keklEMDlQU0EwSUNZbUNpQWdJQ0F2THlCbllYUmxWSGh1TG1Gd2NFRnlaM01vTUNrZ1BUMDlJRzFsZEdodlpGTmxiR1ZqZEc5eUtFZGhkR1ZOZFhOMFEyaGxZMnRHYjNKQlltbE5aWFJvYjJRcElDWW1DaUFnSUNBdkx5Qm5ZWFJsVkhodUxtRndjRUZ5WjNNb01Ta2dQVDA5SUdWdVkyOWtaVUZ5WXpRb1kzUjRLU0FtSmdvZ0lDQWdZbm9nWjJGMFpXUkdiMnhzYjNkZlltOXZiRjltWVd4elpVQTFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzVPRGdLSUNBZ0lDOHZJR2RoZEdWVWVHNHVZWEJ3UVhKbmN5Z3lLU0E5UFQwZ2FYUnZZaWhwWkNrS0lDQWdJR1JwWnlBMENpQWdJQ0JuZEhodWMyRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdScFp5QTVDaUFnSUNBOVBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvNU9ETXRPVGc0Q2lBZ0lDQXZMeUJuWVhSbFZIaHVMbUZ3Y0Vsa0lEMDlQU0JCY0hCc2FXTmhkR2x2YmloblpYUkJhMmwwWVVGd2NFeHBjM1FvWVd0cGRHRkVRVThwTG1kaGRHVXBJQ1ltQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbTl1UTI5dGNHeGxkR2x2YmlBOVBUMGdUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNU9iMDl3SUNZbUNpQWdJQ0F2THlCbllYUmxWSGh1TG01MWJVRndjRUZ5WjNNZ1BUMDlJRFFnSmlZS0lDQWdJQzh2SUdkaGRHVlVlRzR1WVhCd1FYSm5jeWd3S1NBOVBUMGdiV1YwYUc5a1UyVnNaV04wYjNJb1IyRjBaVTExYzNSRGFHVmphMFp2Y2tGaWFVMWxkR2h2WkNrZ0ppWUtJQ0FnSUM4dklHZGhkR1ZVZUc0dVlYQndRWEpuY3lneEtTQTlQVDBnWlc1amIyUmxRWEpqTkNoamRIZ3BJQ1ltQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbUZ3Y0VGeVozTW9NaWtnUFQwOUlHbDBiMklvYVdRcENpQWdJQ0JpZWlCbllYUmxaRVp2Ykd4dmQxOWliMjlzWDJaaGJITmxRRFUwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LWjJGMFpXUkdiMnhzYjNkZlltOXZiRjl0WlhKblpVQTFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TkRRS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaG5ZWFJsUTJobFkydERkSGdvWjJGMFpWUjRiaXdnZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlN3Z1oyRjBaVU4wZUNod0tTd2dabTlzYkc5M1IyRjBaVWxFS1N3Z1pYSnlSbUZwYkdWa1IyRjBaU2tLSUNBZ0lHSnVlaUJuWVhSbFpFWnZiR3h2ZDE5aFpuUmxjbDloYzNObGNuUkFNd29nSUNBZ1lubDBaV01nTVRBZ0x5OGdJa1ZTVWpwbGNuSkdaM1JsSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2tabmRHVUtDbWRoZEdWa1JtOXNiRzkzWDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakUwTmdvZ0lDQWdMeThnZEdocGN5NW1iMnhzYjNkSmJYQnNLRzFpY2xCaGVXMWxiblFzSUdGa1pISmxjM01wQ2lBZ0lDQmpZV3hzYzNWaUlHWnZiR3h2ZDBsdGNHd0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNell0TVRReENpQWdJQ0F2THlCbllYUmxaRVp2Ykd4dmR5Z0tJQ0FnSUM4dklDQWdiV0p5VUdGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVMQW9nSUNBZ0x5OGdJQ0JuWVhSbFZIaHVPaUJuZEhodUxrRndjR3hwWTJGMGFXOXVRMkZzYkZSNGJpd0tJQ0FnSUM4dklDQWdZV1JrY21WemN6b2dRV05qYjNWdWRDd0tJQ0FnSUM4dklDQWdkMkZzYkdWME9pQjFhVzUwTmpRS0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1oyRjBaV1JHYjJ4c2IzZGZZbTl2YkY5bVlXeHpaVUExTkRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJR2RoZEdWa1JtOXNiRzkzWDJKdmIyeGZiV1Z5WjJWQU5UVUtDbWRoZEdWa1JtOXNiRzkzWDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVEF5Q2lBZ0lDQXZMeUJwWmlBb2QyRnNiR1YwSUQwOVBTQXdJSHg4SUhkaGJHeGxkRVpoWTNSdmNua2dQVDA5SURBcElIc0tJQ0FnSUdScFp5QXhDaUFnSUNCaWVpQm5ZWFJsWkVadmJHeHZkMTlwWmw5aWIyUjVRRGdLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmlibm9nWjJGMFpXUkdiMnhzYjNkZllXWjBaWEpmYVdaZlpXeHpaVUE1Q2dwbllYUmxaRVp2Ykd4dmQxOXBabDlpYjJSNVFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRXdNd29nSUNBZ0x5OGdjbVYwZFhKdUlHWmhiSE5sQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWjJGMFpXUkdiMnhzYjNkZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPanBwYzBkbGJuVnBibVZYWVd4c1pYUkFNVFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakUxTWdvZ0lDQWdMeThnYVdZZ0tDRnBjMGRsYm5WcGJtVlhZV3hzWlhRb2FHbHVkQ3dnZDJGc2JHVjBSbUZqZEc5eWVTa3BJSHNLSUNBZ0lHSnVlaUJuWVhSbFpFWnZiR3h2ZDE5aFpuUmxjbDlwWmw5bGJITmxRREUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakUxTkFvZ0lDQWdMeThnYkc5bloyVmtSWEp5S0dWeWNraHBiblJPYjNSWFlXeHNaWFFwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJa1ZTVWpwbGNuSklibmRzSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2todWQyd0tDbWRoZEdWa1JtOXNiRzkzWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakUxT1FvZ0lDQWdMeThnYVdZZ0tHTmhiR3hsY2tGd2NDQTlQVDBnTUNrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JpYm5vZ1oyRjBaV1JHYjJ4c2IzZGZZV1owWlhKZmFXWmZaV3h6WlVBeE9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveE5qRUtJQ0FnSUM4dklHeHZaMmRsWkVWeWNpaGxjbkpJYVc1MFZHOXdUR1YyWld3cENpQWdJQ0J3ZFhOb1lubDBaWE1nSWtWU1VqcGxjbkpJZEc5d0lnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNraDBiM0FLQ21kaGRHVmtSbTlzYkc5M1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pFMk5nb2dJQ0FnTHk4Z2JHVjBJSFpwWVZCc2RXZHBiaUE5SUdaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3hOamNLSUNBZ0lDOHZJR2xtSUNoallXeHNaWEpCY0hBZ0lUMDlJR2hwYm5RcElIc0tJQ0FnSUdScFp5QXhDaUFnSUNBaFBRb2dJQ0FnWW5vZ1oyRjBaV1JHYjJ4c2IzZGZZV1owWlhKZmFXWmZaV3h6WlVBeU5Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVGN4Q2lBZ0lDQXZMeUJqYjI1emRDQmJjM0JsYm1ScGJtY3NJSE53Wlc1a2FXNW5SWGhwYzNSelhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRUo1ZEdWektHaHBiblFzSUVKNWRHVnpLRkJTU1U1RFNWQkJURjlMUlZsZlUxQkZUa1JKVGtjcEtRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW5Od1pXNWthVzVuWDJGa1pISmxjM01pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5WeWVTQTVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRTNNZ29nSUNBZ0x5OGdhV1lnS0NFb2MzQmxibVJwYm1kRmVHbHpkSE1nSmlZZ2MzQmxibVJwYm1jdWJHVnVaM1JvSUQwOVBTQXpNaUFtSmlCemNHVnVaR2x1WnlBOVBUMGdjMlZ1WkdWeUxtSjVkR1Z6SUNZbUlITmxibVJsY2lBaFBUMGdZMkZzYkdWeVFXUmtjaWtwSUhzS0lDQWdJR0o2SUdkaGRHVmtSbTlzYkc5M1gybG1YMkp2WkhsQU1qTUtJQ0FnSUdScFp5QTNDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0o2SUdkaGRHVmtSbTlzYkc5M1gybG1YMkp2WkhsQU1qTUtJQ0FnSUdScFp5QTNDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUdKNklHZGhkR1ZrUm05c2JHOTNYMmxtWDJKdlpIbEFNak1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmthV2NnTlFvZ0lDQWdJVDBLSUNBZ0lHSnVlaUJuWVhSbFpFWnZiR3h2ZDE5aFpuUmxjbDlwWmw5bGJITmxRREkwQ2dwbllYUmxaRVp2Ykd4dmQxOXBabDlpYjJSNVFESXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3hOelFLSUNBZ0lDOHZJR3h2WjJkbFpFVnljaWhsY25KSWFXNTBUbTkwUW05MWJtUXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBsY25KSWJtSmtJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnlja2h1WW1RS0NtZGhkR1ZrUm05c2JHOTNYMkZtZEdWeVgybG1YMlZzYzJWQU1qUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRTNPQW9nSUNBZ0x5OGdkbWxoVUd4MVoybHVJRDBnZEhKMVpRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR052ZG1WeUlESUtDbWRoZEdWa1JtOXNiRzkzWDJGbWRHVnlYMmxtWDJWc2MyVkFNalU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakU0TVFvZ0lDQWdMeThnWTI5dWMzUWdXMk52Ym5SeWIyeHNaV1JDZVhSbGN5d2dZMjl1ZEhKdmJHeGxaRVY0YVhOMGMxMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhDZVhSbGN5aG9hVzUwTENCQ2VYUmxjeWhRVWtsT1EwbFFRVXhmUzBWWlgwTlBUbFJTVDB4TVJVUXBLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltTnZiblJ5YjJ4c1pXUmZZV1JrY21WemN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakU0TWdvZ0lDQWdMeThnYVdZZ0tDRW9ZMjl1ZEhKdmJHeGxaRVY0YVhOMGN5QW1KaUJqYjI1MGNtOXNiR1ZrUW5sMFpYTXViR1Z1WjNSb0lEMDlQU0F6TWlrcElIc0tJQ0FnSUdKNklHZGhkR1ZrUm05c2JHOTNYMmxtWDJKdlpIbEFNamNLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1oyRjBaV1JHYjJ4c2IzZGZZV1owWlhKZmFXWmZaV3h6WlVBeU9Bb0taMkYwWldSR2IyeHNiM2RmYVdaZlltOWtlVUF5TnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRnMENpQWdJQ0F2THlCc2IyZG5aV1JGY25Jb1pYSnlTR2x1ZEVKaFpGZGhiR3hsZENrS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09tVnlja2wzYkhRaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVNYZHNkQW9LWjJGMFpXUkdiMnhzYjNkZllXWjBaWEpmYVdaZlpXeHpaVUF5T0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRFNUNpQWdJQ0F2THlCcFppQW9ZMjl1ZEhKdmJHeGxaQ0E5UFQwZ2MzQmxibVJsY2lrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ013b2dJQ0FnUFQwS0lDQWdJR0o2SUdkaGRHVmtSbTlzYkc5M1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXpBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRJd0NpQWdJQ0F2THlCeVpYUjFjbTRnZEhKMVpRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSE4zWVhBS0NtZGhkR1ZrUm05c2JHOTNYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pvNmQyRnNiR1YwUTI5dWRISnZiSE5NYVhabFFETTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3hPVEVLSUNBZ0lDOHZJR052Ym5OMElGdHlaV1psY25KbGNrSjVkR1Z6TENCeVpXWmxjbkpsY2tWNGFYTjBjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWhvYVc1MExDQkNlWFJsY3loUVVrbE9RMGxRUVV4ZlMwVlpYMUpGUmtWU1VrVlNLU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbkpsWm1WeWNtVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRreUNpQWdJQ0F2THlCamIyNXpkQ0J5WldabGNuSmxjaUE5SUhKbFptVnljbVZ5UlhocGMzUnpJQ1ltSUhKbFptVnljbVZ5UW5sMFpYTXViR1Z1WjNSb0lEMDlQU0F6TWlBL0lFRmpZMjkxYm5Rb2NtVm1aWEp5WlhKQ2VYUmxjeWtnT2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNS0lDQWdJR0o2SUdkaGRHVmtSbTlzYkc5M1gzUmxjbTVoY25sZlptRnNjMlZBTXpnS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaWVpQm5ZWFJsWkVadmJHeHZkMTkwWlhKdVlYSjVYMlpoYkhObFFETTRDaUFnSUNCamIzWmxjaUEwQ2dwbllYUmxaRVp2Ykd4dmQxOTBaWEp1WVhKNVgyMWxjbWRsUURNNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveE9UWUtJQ0FnSUM4dklIQnlhVzVqYVhCaGJEb2diR2wyWlNBL0lHTnZiblJ5YjJ4c1pXUWdPaUJ6Wlc1a1pYSXNDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JREVLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCelpXeGxZM1FLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRrM0NpQWdJQ0F2THlCdmNtbG5hVzQ2SUd4cGRtVWdQeUJqYjI1MGNtOXNiR1ZrSURvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnWW5vZ1oyRjBaV1JHYjJ4c2IzZGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME1Rb0taMkYwWldSR2IyeHNiM2RmZEdWeWJtRnllVjl0WlhKblpVQTBNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVGswTFRJd01Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhzS0lDQWdJQzh2SUNBZ2QyRnNiR1YwT2lCb2FXNTBMQW9nSUNBZ0x5OGdJQ0J3Y21sdVkybHdZV3c2SUd4cGRtVWdQeUJqYjI1MGNtOXNiR1ZrSURvZ2MyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCdmNtbG5hVzQ2SUd4cGRtVWdQeUJqYjI1MGNtOXNiR1ZrSURvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQnpjR1Z1WkdWeU9pQnpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lISmxabVZ5Y21WeUxBb2dJQ0FnTHk4Z0lDQjJhV0ZRYkhWbmFXNHNDaUFnSUNBdkx5QjlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qSXdPUzB5TVRZS0lDQWdJQzh2SUhKbGRIVnliaUJ5WlhOdmJIWmxVSEpwYm1OcGNHRnNRM1I0S0FvZ0lDQWdMeThnSUNCM1lXeHNaWFJHWVdOMGIzSjVMQW9nSUNBZ0x5OGdJQ0JvYVc1MExBb2dJQ0FnTHk4Z0lDQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0JIYkc5aVlXd3VZMkZzYkdWeVFYQndiR2xqWVhScGIyNUpaQ3dLSUNBZ0lDOHZJQ0FnUjJ4dlltRnNMbU5oYkd4bGNrRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdkSEoxWlFvZ0lDQWdMeThnS1FvZ0lDQWdZaUJuWVhSbFpFWnZiR3h2ZDE5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZPbkpsYzI5c2RtVlFjbWx1WTJsd1lXeERkSGhBTkRNS0NtZGhkR1ZrUm05c2JHOTNYM1JsY201aGNubGZabUZzYzJWQU5ERTZDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk1UazNDaUFnSUNBdkx5QnZjbWxuYVc0NklHeHBkbVVnUHlCamIyNTBjbTlzYkdWa0lEb2dSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0JpSUdkaGRHVmtSbTlzYkc5M1gzUmxjbTVoY25sZmJXVnlaMlZBTkRJS0NtZGhkR1ZrUm05c2JHOTNYM1JsY201aGNubGZabUZzYzJWQU16ZzZDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk1Ua3lDaUFnSUNBdkx5QmpiMjV6ZENCeVpXWmxjbkpsY2lBOUlISmxabVZ5Y21WeVJYaHBjM1J6SUNZbUlISmxabVZ5Y21WeVFubDBaWE11YkdWdVozUm9JRDA5UFNBek1pQS9JRUZqWTI5MWJuUW9jbVZtWlhKeVpYSkNlWFJsY3lrZ09pQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWWlCbllYUmxaRVp2Ykd4dmQxOTBaWEp1WVhKNVgyMWxjbWRsUURNNUNncG5ZWFJsWkVadmJHeHZkMTloWm5SbGNsOXBabDlsYkhObFFETXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3hNaklLSUNBZ0lDOHZJR052Ym5OMElGdDNZV3hzWlhSQlpHUnlaWE56TENCM1lXeHNaWFJGZUdsemRITmRJRDBnYjNBdVFYQndVR0Z5WVcxekxtRndjRUZrWkhKbGMzTW9kMkZzYkdWMEtRb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VGa1pISmxjM01LSUNBZ0lITjNZWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRJekNpQWdJQ0F2THlCcFppQW9JWGRoYkd4bGRFVjRhWE4wY3lrZ2V3b2dJQ0FnWW01NklHZGhkR1ZrUm05c2JHOTNYMkZtZEdWeVgybG1YMlZzYzJWQU16SUtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3hNalFLSUNBZ0lDOHZJSEpsZEhWeWJpQm1ZV3h6WlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZNVGc1Q2lBZ0lDQXZMeUJqYjI1emRDQnNhWFpsSUQwZ2QyRnNiR1YwUTI5dWRISnZiSE5NYVhabEtHaHBiblFzSUdOdmJuUnliMnhzWldRc0lITmxibVJsY2lrS0lDQWdJR0lnWjJGMFpXUkdiMnhzYjNkZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPanAzWVd4c1pYUkRiMjUwY205c2MweHBkbVZBTXpVS0NtZGhkR1ZrUm05c2JHOTNYMkZtZEdWeVgybG1YMlZzYzJWQU16STZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRXlOZ29nSUNBZ0x5OGdhV1lnS0dOdmJuUnliMnhzWldRZ1BUMDlJSGRoYkd4bGRFRmtaSEpsYzNNcElIc0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUQwOUNpQWdJQ0JpZWlCbllYUmxaRVp2Ykd4dmQxOWhablJsY2w5cFpsOWxiSE5sUURNMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pnMUNpQWdJQ0F2THlCamIyNXpkQ0JiWVhWMGFGMGdQU0J2Y0M1QlkyTjBVR0Z5WVcxekxtRmpZM1JCZFhSb1FXUmtjaWhoWTJOdmRXNTBLUW9nSUNBZ2MzZGhjQW9nSUNBZ1lXTmpkRjl3WVhKaGJYTmZaMlYwSUVGalkzUkJkWFJvUVdSa2Nnb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pFeU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUdGMWRHaEJaR1J5VDJZb2QyRnNiR1YwUVdSa2NtVnpjeWtnUFQwOUlFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3hPRGtLSUNBZ0lDOHZJR052Ym5OMElHeHBkbVVnUFNCM1lXeHNaWFJEYjI1MGNtOXNjMHhwZG1Vb2FHbHVkQ3dnWTI5dWRISnZiR3hsWkN3Z2MyVnVaR1Z5S1FvZ0lDQWdZaUJuWVhSbFpFWnZiR3h2ZDE5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZPbmRoYkd4bGRFTnZiblJ5YjJ4elRHbDJaVUF6TlFvS1oyRjBaV1JHYjJ4c2IzZGZZV1owWlhKZmFXWmZaV3h6WlVBek5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk9EVUtJQ0FnSUM4dklHTnZibk4wSUZ0aGRYUm9YU0E5SUc5d0xrRmpZM1JRWVhKaGJYTXVZV05qZEVGMWRHaEJaR1J5S0dGalkyOTFiblFwQ2lBZ0lDQmtkWEFLSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBRWFYwYUVGa1pISUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMM0J5YVc1amFYQmhiQzUwY3pveE1qa0tJQ0FnSUM4dklISmxkSFZ5YmlCaGRYUm9RV1JrY2s5bUtHTnZiblJ5YjJ4c1pXUXBJRDA5UFNCM1lXeHNaWFJCWkdSeVpYTnpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdmNISnBibU5wY0dGc0xuUnpPakU0T1FvZ0lDQWdMeThnWTI5dWMzUWdiR2wyWlNBOUlIZGhiR3hsZEVOdmJuUnliMnh6VEdsMlpTaG9hVzUwTENCamIyNTBjbTlzYkdWa0xDQnpaVzVrWlhJcENpQWdJQ0JpSUdkaGRHVmtSbTlzYkc5M1gyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwzQnlhVzVqYVhCaGJDNTBjem82ZDJGc2JHVjBRMjl1ZEhKdmJITk1hWFpsUURNMUNncG5ZWFJsWkVadmJHeHZkMTloWm5SbGNsOXBabDlsYkhObFFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRXdOUW9nSUNBZ0x5OGdZMjl1YzNRZ1cyTnlaV0YwYjNJc0lHVjRhWE4wYzEwZ1BTQnZjQzVCY0hCUVlYSmhiWE11WVhCd1EzSmxZWFJ2Y2loM1lXeHNaWFFwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndRM0psWVhSdmNnb2dJQ0FnYzNkaGNBb2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDNCeWFXNWphWEJoYkM1MGN6b3hNRFlLSUNBZ0lDOHZJSEpsZEhWeWJpQmxlR2x6ZEhNZ0ppWWdZM0psWVhSdmNpQTlQVDBnWVhCd1FXUmtjbVZ6YzA5bUtIZGhiR3hsZEVaaFkzUnZjbmtwQ2lBZ0lDQmllaUJuWVhSbFpFWnZiR3h2ZDE5aWIyOXNYMlpoYkhObFFERXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qYzBDaUFnSUNBdkx5QnlaWFIxY200Z1FXTmpiM1Z1ZENodmNDNXphR0UxTVRKZk1qVTJLRUo1ZEdWektDZGhjSEJKUkNjcExtTnZibU5oZENodmNDNXBkRzlpS0dGd2NFbGtLU2twS1FvZ0lDQWdaR2xuSURZS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUFpWVhCd1NVUWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITm9ZVFV4TWw4eU5UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTl3Y21sdVkybHdZV3d1ZEhNNk1UQTJDaUFnSUNBdkx5QnlaWFIxY200Z1pYaHBjM1J6SUNZbUlHTnlaV0YwYjNJZ1BUMDlJR0Z3Y0VGa1pISmxjM05QWmloM1lXeHNaWFJHWVdOMGIzSjVLUW9nSUNBZ1pHbG5JREV4Q2lBZ0lDQTlQUW9nSUNBZ1lub2daMkYwWldSR2IyeHNiM2RmWW05dmJGOW1ZV3h6WlVBeE1nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OXdjbWx1WTJsd1lXd3VkSE02TVRVeUNpQWdJQ0F2THlCcFppQW9JV2x6UjJWdWRXbHVaVmRoYkd4bGRDaG9hVzUwTENCM1lXeHNaWFJHWVdOMGIzSjVLU2tnZXdvZ0lDQWdZaUJuWVhSbFpFWnZiR3h2ZDE5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5d2NtbHVZMmx3WVd3dWRITTZPbWx6UjJWdWRXbHVaVmRoYkd4bGRFQXhOQW9LWjJGMFpXUkdiMnhzYjNkZlltOXZiRjltWVd4elpVQXhNam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Y0hKcGJtTnBjR0ZzTG5Sek9qRTFNZ29nSUNBZ0x5OGdhV1lnS0NGcGMwZGxiblZwYm1WWFlXeHNaWFFvYUdsdWRDd2dkMkZzYkdWMFJtRmpkRzl5ZVNrcElIc0tJQ0FnSUdJZ1oyRjBaV1JHYjJ4c2IzZGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZjSEpwYm1OcGNHRnNMblJ6T2pwcGMwZGxiblZwYm1WWFlXeHNaWFJBTVRRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02T2tGcmFYUmhVMjlqYVdGc1IzSmhjR2d1YkdWbllXTjVSMkYwWldSR2IyeHNiM2RiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwc1pXZGhZM2xIWVhSbFpFWnZiR3h2ZHpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE5UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ1WVcxbE9pQW5aMkYwWldSR2IyeHNiM2NuSUgwcENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJR0Z3Y0d3S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UVTJDaUFnSUNBdkx5QmpiMjV6ZENCN0lHWnZiR3h2ZDBkaGRHVkpSQ0I5SUQwZ2RHaHBjeTVuWlhSTlpYUmhLR0ZrWkhKbGMzTXBDaUFnSUNCallXeHNjM1ZpSUdkbGRFMWxkR0VLSUNBZ0lHVjRkSEpoWTNRZ05UQWdPQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFMU53b2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLR2RoZEdWRGFHVmpheWhuWVhSbFZIaHVMQ0IwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsTENCVWVHNHVjMlZ1WkdWeUxDQm1iMnhzYjNkSFlYUmxTVVFwTENCbGNuSkdZV2xzWldSSFlYUmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveE5nb2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TlRjS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaG5ZWFJsUTJobFkyc29aMkYwWlZSNGJpd2dkR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU3dnVkhodUxuTmxibVJsY2l3Z1ptOXNiRzkzUjJGMFpVbEVLU3dnWlhKeVJtRnBiR1ZrUjJGMFpTa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pRMk1Bb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1aGNIQkpaQ0E5UFQwZ1FYQndiR2xqWVhScGIyNG9aMlYwUVd0cGRHRkJjSEJNYVhOMEtHRnJhWFJoUkVGUEtTNW5ZWFJsS1NBbUpnb2dJQ0FnYzNkaGNBb2dJQ0FnWjNSNGJuTWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem95TURZS0lDQWdJQzh2SUdOdmJuTjBJRnRoY0hCTWFYTjBRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb1lXdHBkR0ZFUVU4c0lFSjVkR1Z6S0VGcmFYUmhSRUZQUjJ4dlltRnNVM1JoZEdWTFpYbHpRV3RwZEdGQmNIQk1hWE4wS1NrS0lDQWdJSE4zWVhBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1GaGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZORFl3Q2lBZ0lDQXZMeUJuWVhSbFZIaHVMbUZ3Y0Vsa0lEMDlQU0JCY0hCc2FXTmhkR2x2YmloblpYUkJhMmwwWVVGd2NFeHBjM1FvWVd0cGRHRkVRVThwTG1kaGRHVXBJQ1ltQ2lBZ0lDQndkWE5vYVc1MElEUXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5EWXdMVFEyTVFvZ0lDQWdMeThnWjJGMFpWUjRiaTVoY0hCSlpDQTlQVDBnUVhCd2JHbGpZWFJwYjI0b1oyVjBRV3RwZEdGQmNIQk1hWE4wS0dGcmFYUmhSRUZQS1M1bllYUmxLU0FtSmdvZ0lDQWdMeThnWjJGMFpWUjRiaTV2YmtOdmJYQnNaWFJwYjI0Z1BUMDlJRTl1UTI5dGNHeGxkR1ZCWTNScGIyNHVUbTlQY0NBbUpnb2dJQ0FnWW5vZ2JHVm5ZV041UjJGMFpXUkdiMnhzYjNkZlltOXZiRjltWVd4elpVQXhNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzBOakVLSUNBZ0lDOHZJR2RoZEdWVWVHNHViMjVEYjIxd2JHVjBhVzl1SUQwOVBTQlBia052YlhCc1pYUmxRV04wYVc5dUxrNXZUM0FnSmlZS0lDQWdJR1JwWnlBMENpQWdJQ0JuZEhodWN5QlBia052YlhCc1pYUnBiMjRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZORFl3TFRRMk1Rb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1aGNIQkpaQ0E5UFQwZ1FYQndiR2xqWVhScGIyNG9aMlYwUVd0cGRHRkJjSEJNYVhOMEtHRnJhWFJoUkVGUEtTNW5ZWFJsS1NBbUpnb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1dmJrTnZiWEJzWlhScGIyNGdQVDA5SUU5dVEyOXRjR3hsZEdWQlkzUnBiMjR1VG05UGNDQW1KZ29nSUNBZ1ltNTZJR3hsWjJGamVVZGhkR1ZrUm05c2JHOTNYMkp2YjJ4ZlptRnNjMlZBTVRFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TkRZeUNpQWdJQ0F2THlCbllYUmxWSGh1TG01MWJVRndjRUZ5WjNNZ1BUMDlJRFFnSmlZS0lDQWdJR1JwWnlBMENpQWdJQ0JuZEhodWN5Qk9kVzFCY0hCQmNtZHpDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalEyTUMwME5qSUtJQ0FnSUM4dklHZGhkR1ZVZUc0dVlYQndTV1FnUFQwOUlFRndjR3hwWTJGMGFXOXVLR2RsZEVGcmFYUmhRWEJ3VEdsemRDaGhhMmwwWVVSQlR5a3VaMkYwWlNrZ0ppWUtJQ0FnSUM4dklHZGhkR1ZVZUc0dWIyNURiMjF3YkdWMGFXOXVJRDA5UFNCUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGs1dlQzQWdKaVlLSUNBZ0lDOHZJR2RoZEdWVWVHNHViblZ0UVhCd1FYSm5jeUE5UFQwZ05DQW1KZ29nSUNBZ1lub2diR1ZuWVdONVIyRjBaV1JHYjJ4c2IzZGZZbTl2YkY5bVlXeHpaVUF4TVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8wTmpNS0lDQWdJQzh2SUdkaGRHVlVlRzR1WVhCd1FYSm5jeWd3S1NBOVBUMGdiV1YwYUc5a1UyVnNaV04wYjNJOGRIbHdaVzltSUVkaGRHVXVjSEp2ZEc5MGVYQmxMbTExYzNSRGFHVmphejRvS1NBbUpnb2dJQ0FnWkdsbklEUUtJQ0FnSUdkMGVHNXpZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRORE01TWpJMk5UVWdMeThnYldWMGFHOWtJQ0p0ZFhOMFEyaGxZMnNvWVdSa2NtVnpjeXgxYVc1ME5qUXNZbmwwWlZ0ZFcxMHBkbTlwWkNJS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalEyTUMwME5qTUtJQ0FnSUM4dklHZGhkR1ZVZUc0dVlYQndTV1FnUFQwOUlFRndjR3hwWTJGMGFXOXVLR2RsZEVGcmFYUmhRWEJ3VEdsemRDaGhhMmwwWVVSQlR5a3VaMkYwWlNrZ0ppWUtJQ0FnSUM4dklHZGhkR1ZVZUc0dWIyNURiMjF3YkdWMGFXOXVJRDA5UFNCUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGs1dlQzQWdKaVlLSUNBZ0lDOHZJR2RoZEdWVWVHNHViblZ0UVhCd1FYSm5jeUE5UFQwZ05DQW1KZ29nSUNBZ0x5OGdaMkYwWlZSNGJpNWhjSEJCY21kektEQXBJRDA5UFNCdFpYUm9iMlJUWld4bFkzUnZjangwZVhCbGIyWWdSMkYwWlM1d2NtOTBiM1I1Y0dVdWJYVnpkRU5vWldOclBpZ3BJQ1ltQ2lBZ0lDQmllaUJzWldkaFkzbEhZWFJsWkVadmJHeHZkMTlpYjI5c1gyWmhiSE5sUURFeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pRMk5Bb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1aGNIQkJjbWR6S0RFcElEMDlQU0J1WlhjZ1FXUmtjbVZ6Y3loallXeHNaWElwTG1KNWRHVnpJQ1ltQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaM1I0Ym5OaElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrYVdjZ013b2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TkRZd0xUUTJOQW9nSUNBZ0x5OGdaMkYwWlZSNGJpNWhjSEJKWkNBOVBUMGdRWEJ3YkdsallYUnBiMjRvWjJWMFFXdHBkR0ZCY0hCTWFYTjBLR0ZyYVhSaFJFRlBLUzVuWVhSbEtTQW1KZ29nSUNBZ0x5OGdaMkYwWlZSNGJpNXZia052YlhCc1pYUnBiMjRnUFQwOUlFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVRtOVBjQ0FtSmdvZ0lDQWdMeThnWjJGMFpWUjRiaTV1ZFcxQmNIQkJjbWR6SUQwOVBTQTBJQ1ltQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbUZ3Y0VGeVozTW9NQ2tnUFQwOUlHMWxkR2h2WkZObGJHVmpkRzl5UEhSNWNHVnZaaUJIWVhSbExuQnliM1J2ZEhsd1pTNXRkWE4wUTJobFkycytLQ2tnSmlZS0lDQWdJQzh2SUdkaGRHVlVlRzR1WVhCd1FYSm5jeWd4S1NBOVBUMGdibVYzSUVGa1pISmxjM01vWTJGc2JHVnlLUzVpZVhSbGN5QW1KZ29nSUNBZ1lub2diR1ZuWVdONVIyRjBaV1JHYjJ4c2IzZGZZbTl2YkY5bVlXeHpaVUF4TVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8wTmpVS0lDQWdJQzh2SUdkaGRHVlVlRzR1WVhCd1FYSm5jeWd5S1NBOVBUMGdhWFJ2WWlocFpDa0tJQ0FnSUdScFp5QTBDaUFnSUNCbmRIaHVjMkVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUnBaeUEwQ2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzBOakF0TkRZMUNpQWdJQ0F2THlCbllYUmxWSGh1TG1Gd2NFbGtJRDA5UFNCQmNIQnNhV05oZEdsdmJpaG5aWFJCYTJsMFlVRndjRXhwYzNRb1lXdHBkR0ZFUVU4cExtZGhkR1VwSUNZbUNpQWdJQ0F2THlCbllYUmxWSGh1TG05dVEyOXRjR3hsZEdsdmJpQTlQVDBnVDI1RGIyMXdiR1YwWlVGamRHbHZiaTVPYjA5d0lDWW1DaUFnSUNBdkx5Qm5ZWFJsVkhodUxtNTFiVUZ3Y0VGeVozTWdQVDA5SURRZ0ppWUtJQ0FnSUM4dklHZGhkR1ZVZUc0dVlYQndRWEpuY3lnd0tTQTlQVDBnYldWMGFHOWtVMlZzWldOMGIzSThkSGx3Wlc5bUlFZGhkR1V1Y0hKdmRHOTBlWEJsTG0xMWMzUkRhR1ZqYXo0b0tTQW1KZ29nSUNBZ0x5OGdaMkYwWlZSNGJpNWhjSEJCY21kektERXBJRDA5UFNCdVpYY2dRV1JrY21WemN5aGpZV3hzWlhJcExtSjVkR1Z6SUNZbUNpQWdJQ0F2THlCbllYUmxWSGh1TG1Gd2NFRnlaM01vTWlrZ1BUMDlJR2wwYjJJb2FXUXBDaUFnSUNCaWVpQnNaV2RoWTNsSFlYUmxaRVp2Ykd4dmQxOWliMjlzWDJaaGJITmxRREV4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LYkdWbllXTjVSMkYwWldSR2IyeHNiM2RmWW05dmJGOXRaWEpuWlVBeE1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hOVGNLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENobllYUmxRMmhsWTJzb1oyRjBaVlI0Yml3Z2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTd2dWSGh1TG5ObGJtUmxjaXdnWm05c2JHOTNSMkYwWlVsRUtTd2daWEp5Um1GcGJHVmtSMkYwWlNrS0lDQWdJR0p1ZWlCc1pXZGhZM2xIWVhSbFpFWnZiR3h2ZDE5aFpuUmxjbDloYzNObGNuUkFNd29nSUNBZ1lubDBaV01nTVRBZ0x5OGdJa1ZTVWpwbGNuSkdaM1JsSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2tabmRHVUtDbXhsWjJGamVVZGhkR1ZrUm05c2JHOTNYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTFPUW9nSUNBZ0x5OGdkR2hwY3k1bWIyeHNiM2RKYlhCc0tHMWljbEJoZVcxbGJuUXNJR0ZrWkhKbGMzTXBDaUFnSUNCallXeHNjM1ZpSUdadmJHeHZkMGx0Y0d3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE5UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ1WVcxbE9pQW5aMkYwWldSR2IyeHNiM2NuSUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHNaV2RoWTNsSFlYUmxaRVp2Ykd4dmQxOWliMjlzWDJaaGJITmxRREV4T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdiR1ZuWVdONVIyRjBaV1JHYjJ4c2IzZGZZbTl2YkY5dFpYSm5aVUF4TWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem82UVd0cGRHRlRiMk5wWVd4SGNtRndhQzVtYjJ4c2IzZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BtYjJ4c2IzYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVGN5Q2lBZ0lDQXZMeUJtYjJ4c2IzY29iV0p5VUdGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVMQ0JoWkdSeVpYTnpPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTNNd29nSUNBZ0x5OGdZMjl1YzNRZ2V5Qm1iMnhzYjNkSFlYUmxTVVFnZlNBOUlIUm9hWE11WjJWMFRXVjBZU2hoWkdSeVpYTnpLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUk5aWFJoQ2lBZ0lDQndkWE5vYVc1MElEVXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakUzTkFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtHWnZiR3h2ZDBkaGRHVkpSQ0E5UFQwZ01Dd2daWEp5U0dGelIyRjBaU2tLSUNBZ0lHSjZJR1p2Ykd4dmQxOWhablJsY2w5aGMzTmxjblJBTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWxJNlpYSnlTR2QwWlNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBsY25KSVozUmxDZ3BtYjJ4c2IzZGZZV1owWlhKZllYTnpaWEowUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UYzJDaUFnSUNBdkx5QjBhR2x6TG1admJHeHZkMGx0Y0d3b2JXSnlVR0Y1YldWdWRDd2dZV1JrY21WemN5a0tJQ0FnSUdOaGJHeHpkV0lnWm05c2JHOTNTVzF3YkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFM01nb2dJQ0FnTHk4Z1ptOXNiRzkzS0cxaWNsQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3Z1lXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem82UVd0cGRHRlRiMk5wWVd4SGNtRndhQzUxYm1admJHeHZkMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25WdVptOXNiRzkzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFNE1Bb2dJQ0FnTHk4Z2RXNW1iMnhzYjNjb1lXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UZ3lDaUFnSUNBdkx5QmpiMjV6ZENCbWIyeHNiM2R6UzJWNUlEMGdkR2hwY3k1bWJIY29ZV1JrY21WemN5d2dWSGh1TG5ObGJtUmxjaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOaGJHeHpkV0lnWm14M0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklHWnZiR3h2ZDNNZ1BTQkNiM2hOWVhBOFJtOXNiRzkzYzB0bGVTd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nUVd0cGRHRlRiMk5wWVd4Q2IzaFFjbVZtYVhoR2IyeHNiM2R6SUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKbUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hPRFFLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoMGFHbHpMbVp2Ykd4dmQzTW9abTlzYkc5M2MwdGxlU2t1WlhocGMzUnpMQ0JsY25KT2IzUkdiMnhzYjNkcGJtY3BDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCMWJtWnZiR3h2ZDE5aFpuUmxjbDloYzNObGNuUkFNd29nSUNBZ2NIVnphR0o1ZEdWeklDSkZVbEk2WlhKeVRtWnNkeUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGxjbkpPWm14M0NncDFibVp2Ykd4dmQxOWhablJsY2w5aGMzTmxjblJBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE9EWUtJQ0FnSUM4dklHTnZibk4wSUhzZ1ptOXNiRzkzWlhKRGIzVnVkQ3dnWm05c2JHOTNaWEpKYm1SbGVDQjlJRDBnZEdocGN5NW5aWFJOWlhSaEtHRmtaSEpsYzNNcENpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR05oYkd4emRXSWdaMlYwVFdWMFlRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFF4Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdsdWRDQXpNd29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94T0RnS0lDQWdJQzh2SUhSb2FYTXVkWEJrWVhSbFJtOXNiRzkzWlhKTlpYUmhLR0ZrWkhKbGMzTXNJR1p2Ykd4dmQyVnlTVzVrWlhnc0lHWnZiR3h2ZDJWeVEyOTFiblFnTFNBeEtRb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHTmhiR3h6ZFdJZ2RYQmtZWFJsUm05c2JHOTNaWEpOWlhSaENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UZzVDaUFnSUNBdkx5QjBhR2x6TG1admJHeHZkM01vWm05c2JHOTNjMHRsZVNrdVpHVnNaWFJsS0NrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1Ua3pDaUFnSUNBdkx5QlVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTVOQW9nSUNBZ0x5OGdkR2hwY3k1dFluSW9RbmwwWlhNb0p5Y3BMQ0FuSnl3Z1FubDBaWE1vSnljcEtTNW1iMnhzYjNkekNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNJaUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUdOaGJHeHpkV0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qcENZWE5sVTI5amFXRnNMbTFpY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRreExURTVOUW9nSUNBZ0x5OGdZMjl1YzNRZ1czSmxZMlZwZG1WeUxDQmhiVzkxYm5SZElEMGdjbVZzWldGelpVUmxjRzl6YVhRb0NpQWdJQ0F2THlBZ0lIUm9hWE11Wm05c2JHOTNjeWhtYjJ4c2IzZHpTMlY1S1M1clpYa3NDaUFnSUNBdkx5QWdJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUhSb2FYTXViV0p5S0VKNWRHVnpLQ2NuS1N3Z0p5Y3NJRUo1ZEdWektDY25LU2t1Wm05c2JHOTNjd29nSUNBZ0x5OGdLUW9nSUNBZ1kyRnNiSE4xWWlCeVpXeGxZWE5sUkdWd2IzTnBkQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hPVFlLSUNBZ0lDOHZJR2wwZUc0dWNHRjViV1Z1ZENoN0lISmxZMlZwZG1WeUxDQmhiVzkxYm5RZ2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTRNQW9nSUNBZ0x5OGdkVzVtYjJ4c2IzY29ZV1JrY21WemN6b2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvNlFXdHBkR0ZUYjJOcFlXeEhjbUZ3YUM1cGMwSnNiMk5yWldSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBjMEpzYjJOclpXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVGs1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TWpBeENpQWdJQ0F2THlCamIyNXpkQ0JpYkc5amEzTkxaWGtnUFNCMGFHbHpMbUpzYXloMWMyVnlMQ0JpYkc5amEyVmtLUW9nSUNBZ1kyRnNiSE4xWWlCaWJHc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdZbXh2WTJ0eklEMGdRbTk0VFdGd1BFSnNiMk5yVEdsemRFdGxlU3dnWW5sMFpYTThNRDQrS0hzZ2EyVjVVSEpsWm1sNE9pQkJhMmwwWVZOdlkybGhiRUp2ZUZCeVpXWnBlRUpzYjJOcmN5QjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pJd01nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZbXh2WTJ0ektHSnNiMk5yYzB0bGVTa3VaWGhwYzNSekNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94T1RrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02T2tGcmFYUmhVMjlqYVdGc1IzSmhjR2d1YVhOR2IyeHNiM2RwYm1kYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBjMFp2Ykd4dmQybHVaem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem95TURVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveU1EY0tJQ0FnSUM4dklHTnZibk4wSUdadmJHeHZkM05MWlhrZ1BTQjBhR2x6TG1ac2R5aDFjMlZ5TENCbWIyeHNiM2RsY2lrS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdabXgzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUdadmJHeHZkM01nUFNCQ2IzaE5ZWEE4Um05c2JHOTNjMHRsZVN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dRV3RwZEdGVGIyTnBZV3hDYjNoUWNtVm1hWGhHYjJ4c2IzZHpJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ptSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1qQTRDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTVtYjJ4c2IzZHpLR1p2Ykd4dmQzTkxaWGtwTG1WNGFYTjBjd29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1qQTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qcEJhMmwwWVZOdlkybGhiRWR5WVhCb0xtZGxkRVp2Ykd4dmQwbHVaR1Y0VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBSbTlzYkc5M1NXNWtaWGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TWpFeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1qRXpDaUFnSUNBdkx5QmpiMjV6ZENCbWIyeHNiM2R6UzJWNUlEMGdkR2hwY3k1bWJIY29kWE5sY2l3Z1ptOXNiRzkzWlhJcENpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJR1pzZHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCbWIyeHNiM2R6SUQwZ1FtOTRUV0Z3UEVadmJHeHZkM05MWlhrc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJRUZyYVhSaFUyOWphV0ZzUW05NFVISmxabWw0Um05c2JHOTNjeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWmlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qSXhOQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11Wm05c2JHOTNjeWhtYjJ4c2IzZHpTMlY1S1M1MllXeDFaUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem95TVRFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem82VlhCbmNtRmtaV0ZpYkdWQmEybDBZVUpoYzJWRGIyNTBjbUZqZEM1MWNHUmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNelVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJRnNuVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRuWFNCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3pOd29nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVoyVjBRV3RwZEdGRVFVOVhZV3hzWlhRb0tTNWhaR1J5WlhOekxDQmxjbkpPYjNSQmEybDBZVVJoYnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hPUW9nSUNBZ0x5OGdZMjl1YzNRZ1czZGhiR3hsZEVsRVhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzFkaGJHeGxkQ2twQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qRTJDaUFnSUNBdkx5QmhhMmwwWVVSQlR5QTlJRWRzYjJKaGJGTjBZWFJsUEVGd2NHeHBZMkYwYVc5dVBpaDdJR3RsZVRvZ1IyeHZZbUZzVTNSaGRHVkxaWGxCYTJsMFlVUkJUeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVd0cGRHRmZaR0Z2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakU1Q2lBZ0lDQXZMeUJqYjI1emRDQmJkMkZzYkdWMFNVUmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0VldsdWREWTBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VzSUVKNWRHVnpLRUZyYVhSaFJFRlBSMnh2WW1Gc1UzUmhkR1ZMWlhselYyRnNiR1YwS1NrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpZDJGc2JHVjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPak0zQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NW5aWFJCYTJsMFlVUkJUMWRoYkd4bGRDZ3BMbUZrWkhKbGMzTXNJR1Z5Y2s1dmRFRnJhWFJoUkdGdktRb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVdSa2NtVnpjd29nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCMWNHUmhkR1ZmWVdaMFpYSmZZWE56WlhKMFFETUtJQ0FnSUdKNWRHVmpJREV5SUM4dklDSkZVbEk2WlhKeVRtUmhieUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGxjbkpPWkdGdkNncDFjR1JoZEdWZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNemdLSUNBZ0lDOHZJR052Ym5OMElGdHdiSFZuYVc1elhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRUo1ZEdWektIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6VUd4MVoybHVRWEJ3VEdsemRDa3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pFMkNpQWdJQ0F2THlCaGEybDBZVVJCVHlBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbEJhMmwwWVVSQlR5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV3RwZEdGZlpHRnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qTTRDaUFnSUNBdkx5QmpiMjV6ZENCYmNHeDFaMmx1YzEwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3loMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMUJzZFdkcGJrRndjRXhwYzNRcEtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWaklERXpJQzh2SUNKd1lXd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNemtLSUNBZ0lDOHZJR052Ym5OMElIVndaR0YwWlZCc2RXZHBiaUE5SUdSbFkyOWtaVUZ5WXpROFVHeDFaMmx1UVhCd1RHbHpkRDRvY0d4MVoybHVjeWt1ZFhCa1lYUmxDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pRd0NpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9SMnh2WW1Gc0xtTmhiR3hsY2tGd2NHeHBZMkYwYVc5dVNXUWdQVDA5SUhWd1pHRjBaVkJzZFdkcGJpd2daWEp5U1c1MllXeHBaRlZ3WjNKaFpHVXBDaUFnSUNCbmJHOWlZV3dnUTJGc2JHVnlRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUIxY0dSaGRHVmZZV1owWlhKZllYTnpaWEowUURVS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09tVnlja2wxY0djaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVNYVndad29LZFhCa1lYUmxYMkZtZEdWeVgyRnpjMlZ5ZEVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pFMENpQWdJQ0F2THlCMlpYSnphVzl1SUQwZ1IyeHZZbUZzVTNSaGRHVThjM1J5YVc1blBpaDdJR3RsZVRvZ1IyeHZZbUZzVTNSaGRHVkxaWGxXWlhKemFXOXVJSDBwQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0oyWlhKemFXOXVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qUXhDaUFnSUNBdkx5QjBhR2x6TG5abGNuTnBiMjR1ZG1Gc2RXVWdQU0J1WlhkV1pYSnphVzl1Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPak0xQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUJiSjFWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1SjEwZ2ZTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02T2tGcmFYUmhRbUZ6WlVOdmJuUnlZV04wTG5Wd1pHRjBaVUZyYVhSaFJFRlBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxRV3RwZEdGRVFVODZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1qVUtJQ0FnSUM4dklIVndaR0YwWlVGcmFYUmhSRUZQS0dGcmFYUmhSRUZQT2lCQmNIQnNhV05oZEdsdmJpazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveU5nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WjJWMFFXdHBkR0ZFUVU5WFlXeHNaWFFvS1M1aFpHUnlaWE56TENCbGNuSk9iM1JCYTJsMFlVUmhieWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveE9Rb2dJQ0FnTHk4Z1kyOXVjM1FnVzNkaGJHeGxkRWxFWFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVGVnBiblEyTkNoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMWRoYkd4bGRDa3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pFMkNpQWdJQ0F2THlCaGEybDBZVVJCVHlBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbEJhMmwwWVVSQlR5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV3RwZEdGZlpHRnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qRTVDaUFnSUNBdkx5QmpiMjV6ZENCYmQyRnNiR1YwU1VSZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRWV2x1ZERZMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6VjJGc2JHVjBLU2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWlkMkZzYkdWMElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qSTJDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1blpYUkJhMmwwWVVSQlQxZGhiR3hsZENncExtRmtaSEpsYzNNc0lHVnljazV2ZEVGcmFYUmhSR0Z2S1FvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndRV1JrY21WemN3b2dJQ0FnWVhOelpYSjBJQzh2SUdGd2NHeHBZMkYwYVc5dUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUIxY0dSaGRHVkJhMmwwWVVSQlQxOWhablJsY2w5aGMzTmxjblJBTXdvZ0lDQWdZbmwwWldNZ01USWdMeThnSWtWU1VqcGxjbkpPWkdGdklnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrNWtZVzhLQ25Wd1pHRjBaVUZyYVhSaFJFRlBYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pFMkNpQWdJQ0F2THlCaGEybDBZVVJCVHlBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbEJhMmwwWVVSQlR5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV3RwZEdGZlpHRnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qSTNDaUFnSUNBdkx5QjBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxJRDBnWVd0cGRHRkVRVThLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNalVLSUNBZ0lDOHZJSFZ3WkdGMFpVRnJhWFJoUkVGUEtHRnJhWFJoUkVGUE9pQkJjSEJzYVdOaGRHbHZiaWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem82UW1GelpWTnZZMmxoYkM1dFluSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B0WW5JNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZNVFVLSUNBZ0lDOHZJRzFpY2loeVpXWTZJR0o1ZEdWekxDQnlaV1pVZVhCbFRtRnRaVG9nYzNSeWFXNW5MQ0J5WldaVWVYQmxVMk5vWlcxaE9pQmllWFJsY3lrNklFRnJhWFJoVTI5amFXRnNUVUpTUkdGMFlTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmpZV3hzYzNWaUlITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem82UW1GelpWTnZZMmxoYkM1dFluSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZPa0poYzJWVGIyTnBZV3d1Y0dGNVYyRnNiRTFpY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQmhlVmRoYkd4TlluSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02TXpRS0lDQWdJQzh2SUhCaGVWZGhiR3hOWW5Jb2NHRjVkMkZzYkRvZ1ZtbGxkMUJoZVZkaGJHeFdZV3gxWlNrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01DQnZaaUFvS0d4bGJpc29kV2x1ZERnc2RXbHVkRFkwTEhWcGJuUTJOQ2xiWFNrc0tHeGxiaXNvZFdsdWREZ3NkV2x1ZERZMExIVnBiblEyTkNsYlhTa3BDaUFnSUNCa2FXY2dNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXhOd29nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQXJDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElERWdiMllnS0Noc1pXNHJLSFZwYm5RNExIVnBiblEyTkN4MWFXNTBOalFwVzEwcExDaHNaVzRyS0hWcGJuUTRMSFZwYm5RMk5DeDFhVzUwTmpRcFcxMHBLUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmthV2NnTlFvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhOd29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnS3dvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMM1I1Y0dWekxuUnpPanBXYVdWM1VHRjVWMkZzYkZaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02TXpjS0lDQWdJQzh2SUZCaGVWZGhiR3hRWVhsUGNIUnBiMjVUYVhwbElDb2dLSEJoZVhkaGJHd3VZV2RsYm5SUVlYbEpibVp2TG14bGJtZDBhQ0FySUhCaGVYZGhiR3d1ZFhObGNsQmhlVWx1Wm04dWJHVnVaM1JvS1FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6b3pOaTB6T0FvZ0lDQWdMeThnUW05NFEyOXpkRkJsY2tKNWRHVWdLaUFvQ2lBZ0lDQXZMeUFnSUZCaGVWZGhiR3hRWVhsUGNIUnBiMjVUYVhwbElDb2dLSEJoZVhkaGJHd3VZV2RsYm5SUVlYbEpibVp2TG14bGJtZDBhQ0FySUhCaGVYZGhiR3d1ZFhObGNsQmhlVWx1Wm04dWJHVnVaM1JvS1FvZ0lDQWdMeThnS1FvZ0lDQWdjSFZ6YUdsdWRDQTJPREF3Q2lBZ0lDQXFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02TXpVS0lDQWdJQzh2SUhKbGRIVnliaUJOYVc1UVlYbFhZV3hzVFVKU0lDc2dLQW9nSUNBZ2NIVnphR2x1ZENBNU16QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02TXpVdE16a0tJQ0FnSUM4dklISmxkSFZ5YmlCTmFXNVFZWGxYWVd4c1RVSlNJQ3NnS0FvZ0lDQWdMeThnSUNCQ2IzaERiM04wVUdWeVFubDBaU0FxSUNnS0lDQWdJQzh2SUNBZ0lDQlFZWGxYWVd4c1VHRjVUM0IwYVc5dVUybDZaU0FxSUNod1lYbDNZV3hzTG1GblpXNTBVR0Y1U1c1bWJ5NXNaVzVuZEdnZ0t5QndZWGwzWVd4c0xuVnpaWEpRWVhsSmJtWnZMbXhsYm1kMGFDa0tJQ0FnSUM4dklDQWdLUW9nSUNBZ0x5OGdLUW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPak0wQ2lBZ0lDQXZMeUJ3WVhsWFlXeHNUV0p5S0hCaGVYZGhiR3c2SUZacFpYZFFZWGxYWVd4c1ZtRnNkV1VwT2lCMWFXNTBOalFnZXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pvNlFtRnpaVk52WTJsaGJDNWphR1ZqYTFScGNFMWljbEpsY1hWcGNtVnRaVzUwYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTm9aV05yVkdsd1RXSnlVbVZ4ZFdseVpXMWxiblJ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qYzFDaUFnSUNBdkx5QmphR1ZqYTFScGNFMWljbEpsY1hWcGNtVnRaVzUwY3loaGEybDBZVVJCVHpvZ1FYQndiR2xqWVhScGIyNHNJR055WldGMGIzSTZJRUZqWTI5MWJuUXNJSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRwT2lCMGFYQk5RbEpKYm1adklIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pJMk1Bb2dJQ0FnTHk4Z1kyOXVjM1FnWVd0cGRHRkJjM05sZEhOQ2VYUmxjeUE5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLR0ZyYVhSaFJFRlBMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzBGcmFYUmhRWE56WlhSektTbGJNRjBLSUNBZ0lIQjFjMmhpZVhSbGN5QWlZV3RwZEdGZllYTnpaWFJ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPamMyQ2lBZ0lDQXZMeUJqYjI1emRDQmhhM1JoSUQwZ1FYTnpaWFFvWjJWMFFXdHBkR0ZCYzNObGRITW9ZV3RwZEdGRVFVOHBMbUZyZEdFcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6bzNPQW9nSUNBZ0x5OGdhV1lnS0hkaGJHeGxkQzVwWkNBaFBUMGdNQ0FtSmlBaFkzSmxZWFJ2Y2k1cGMwOXdkR1ZrU1c0b1lXdDBZU2twSUhzS0lDQWdJR0o2SUdOb1pXTnJWR2x3VFdKeVVtVnhkV2x5WlcxbGJuUnpYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QXhDaUFnSUNCaGMzTmxkRjlvYjJ4a2FXNW5YMmRsZENCQmMzTmxkRUpoYkdGdVkyVUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJR05vWldOclZHbHdUV0p5VW1WeGRXbHlaVzFsYm5SelgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qUXpMVFV5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1FXSnpkSEpoWTNSbFpFRmpZMjkxYm5RdWNISnZkRzkwZVhCbExtRnlZelU0WDJOaGJrTmhiR3crS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1FzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnNLSUNBZ0lDOHZJQ0FnSUNCblpYUlFiSFZuYVc1QmNIQk1hWE4wS0dGcmFYUmhSRUZQS1M1dmNIUnBiaXdLSUNBZ0lDOHZJQ0FnSUNCRFlXeHNaWEpVZVhCbFIyeHZZbUZzTEFvZ0lDQWdMeThnSUNBZ0lFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0FuSnl3S0lDQWdJQzh2SUNBZ0lDQnRaWFJvYjJSVFpXeGxZM1J2Y2p4MGVYQmxiMllnVDNCMFNXNVFiSFZuYVc0dWNISnZkRzkwZVhCbExtOXdkRWx1UGlncENpQWdJQ0F2THlBZ0lGMEtJQ0FnSUM4dklIMHBMbkpsZEhWeWJsWmhiSFZsQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qSXhOZ29nSUNBZ0x5OGdZMjl1YzNRZ1czQnNkV2RwYmtGd2NFeHBjM1JDZVhSbGMxMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhDZVhSbGN5aGhhMmwwWVVSQlR5d2dRbmwwWlhNb1FXdHBkR0ZFUVU5SGJHOWlZV3hUZEdGMFpVdGxlWE5RYkhWbmFXNUJjSEJNYVhOMEtTa0tJQ0FnSUdScFp5QXpDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWljR0ZzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPalEyQ2lBZ0lDQXZMeUJuWlhSUWJIVm5hVzVCY0hCTWFYTjBLR0ZyYVhSaFJFRlBLUzV2Y0hScGJpd0tJQ0FnSUdWNGRISmhZM1FnTUNBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZORGNLSUNBZ0lDOHZJRU5oYkd4bGNsUjVjR1ZIYkc5aVlXd3NDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPalE0Q2lBZ0lDQXZMeUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUdScFp5QTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pvME15MDFNZ29nSUNBZ0x5OGdjbVYwZFhKdUlHRmlhVU5oYkd3OGRIbHdaVzltSUVGaWMzUnlZV04wWldSQlkyTnZkVzUwTG5CeWIzUnZkSGx3WlM1aGNtTTFPRjlqWVc1RFlXeHNQaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJDaUFnSUNBdkx5QWdJQ0FnWjJWMFVHeDFaMmx1UVhCd1RHbHpkQ2hoYTJsMFlVUkJUeWt1YjNCMGFXNHNDaUFnSUNBdkx5QWdJQ0FnUTJGc2JHVnlWSGx3WlVkc2IySmhiQ3dLSUNBZ0lDOHZJQ0FnSUNCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdKeWNzQ2lBZ0lDQXZMeUFnSUNBZ2JXVjBhRzlrVTJWc1pXTjBiM0k4ZEhsd1pXOW1JRTl3ZEVsdVVHeDFaMmx1TG5CeWIzUnZkSGx3WlM1dmNIUkpiajRvS1FvZ0lDQWdMeThnSUNCZENpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZak0yTWpNMFlUVWdMeThnYldWMGFHOWtJQ0poY21NMU9GOWpZVzVEWVd4c0tIVnBiblEyTkN4MWFXNTBOalFzWVdSa2NtVnpjeXh6ZEhKcGJtY3NZbmwwWlZzMFhTbGliMjlzSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPalE1Q2lBZ0lDQXZMeUFuSnl3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk5UQUtJQ0FnSUM4dklHMWxkR2h2WkZObGJHVmpkRzl5UEhSNWNHVnZaaUJQY0hSSmJsQnNkV2RwYmk1d2NtOTBiM1I1Y0dVdWIzQjBTVzQrS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURZNE16VmxNMkpqSUM4dklHMWxkR2h2WkNBaWIzQjBTVzRvZFdsdWREWTBMR0p2YjJ3c2RXbHVkRFkwVzEwc2NHRjVLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pRekxUVXlDaUFnSUNBdkx5QnlaWFIxY200Z1lXSnBRMkZzYkR4MGVYQmxiMllnUVdKemRISmhZM1JsWkVGalkyOTFiblF1Y0hKdmRHOTBlWEJsTG1GeVl6VTRYMk5oYmtOaGJHdytLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGc0tJQ0FnSUM4dklDQWdJQ0JuWlhSUWJIVm5hVzVCY0hCTWFYTjBLR0ZyYVhSaFJFRlBLUzV2Y0hScGJpd0tJQ0FnSUM4dklDQWdJQ0JEWVd4c1pYSlVlWEJsUjJ4dlltRnNMQW9nSUNBZ0x5OGdJQ0FnSUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQW5KeXdLSUNBZ0lDOHZJQ0FnSUNCdFpYUm9iMlJUWld4bFkzUnZjangwZVhCbGIyWWdUM0IwU1c1UWJIVm5hVzR1Y0hKdmRHOTBlWEJsTG05d2RFbHVQaWdwQ2lBZ0lDQXZMeUFnSUYwS0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKNWRHVnpJR2hoY3lCMllXeHBaQ0J3Y21WbWFYZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZbTl2YkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qZ3dDaUFnSUNBdkx5QnBaaUFvWTJGdVEyRnNiRUZ5WXpVNFQzQjBTVzRwSUhzS0lDQWdJR0o2SUdOb1pXTnJWR2x3VFdKeVVtVnhkV2x5WlcxbGJuUnpYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPamd6Q2lBZ0lDQXZMeUJoY21NMU9Eb2dSMnh2WW1Gc0xtRnpjMlYwVDNCMFNXNU5hVzVDWVd4aGJtTmxDaUFnSUNCbmJHOWlZV3dnUVhOelpYUlBjSFJKYmsxcGJrSmhiR0Z1WTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6bzRNUzA0TkFvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnZEhsd1pUb2dWR2x3VTJWdVpGUjVjR1ZCVWtNMU9Dd0tJQ0FnSUM4dklDQWdZWEpqTlRnNklFZHNiMkpoYkM1aGMzTmxkRTl3ZEVsdVRXbHVRbUZzWVc1alpRb2dJQ0FnTHk4Z2ZRb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPamd5Q2lBZ0lDQXZMeUIwZVhCbE9pQlVhWEJUWlc1a1ZIbHdaVUZTUXpVNExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem80TVMwNE5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhzS0lDQWdJQzh2SUNBZ2RIbHdaVG9nVkdsd1UyVnVaRlI1Y0dWQlVrTTFPQ3dLSUNBZ0lDOHZJQ0FnWVhKak5UZzZJRWRzYjJKaGJDNWhjM05sZEU5d2RFbHVUV2x1UW1Gc1lXNWpaUW9nSUNBZ0x5OGdmUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2dwamFHVmphMVJwY0UxaWNsSmxjWFZwY21WdFpXNTBjMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem82UW1GelpWTnZZMmxoYkM1amFHVmphMVJwY0UxaWNsSmxjWFZwY21WdFpXNTBjMEEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qYzFDaUFnSUNBdkx5QmphR1ZqYTFScGNFMWljbEpsY1hWcGNtVnRaVzUwY3loaGEybDBZVVJCVHpvZ1FYQndiR2xqWVhScGIyNHNJR055WldGMGIzSTZJRUZqWTI5MWJuUXNJSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRwT2lCMGFYQk5RbEpKYm1adklIc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbU5vWldOclZHbHdUV0p5VW1WeGRXbHlaVzFsYm5SelgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6bzRPQzA1TVFvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnZEhsd1pUb2dWR2x3VTJWdVpGUjVjR1ZFYVhKbFkzUXNDaUFnSUNBdkx5QWdJR0Z5WXpVNE9pQXdDaUFnSUNBdkx5QjlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dZVEF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem8zTlFvZ0lDQWdMeThnWTJobFkydFVhWEJOWW5KU1pYRjFhWEpsYldWdWRITW9ZV3RwZEdGRVFVODZJRUZ3Y0d4cFkyRjBhVzl1TENCamNtVmhkRzl5T2lCQlkyTnZkVzUwTENCM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUtUb2dkR2x3VFVKU1NXNW1ieUI3Q2lBZ0lDQmlJR05vWldOclZHbHdUV0p5VW1WeGRXbHlaVzFsYm5SelgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qcENZWE5sVTI5amFXRnNMbU5vWldOclZHbHdUV0p5VW1WeGRXbHlaVzFsYm5SelFEY0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk9rRnJhWFJoVTI5amFXRnNSM0poY0dndWFYTkNZVzV1WldRb1lXTmpiM1Z1ZERvZ1lubDBaWE1wSUMwK0lIVnBiblEyTkRvS2FYTkNZVzV1WldRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklIQnlhWFpoZEdVZ2FYTkNZVzV1WldRb1lXTmpiM1Z1ZERvZ1FXTmpiM1Z1ZENrNklHSnZiMnhsWVc0Z2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUdOdmJuTjBJSHNnYlc5a1pYSmhkR2x2YmlCOUlEMGdaMlYwUVd0cGRHRlRiMk5wWVd4QmNIQk1hWE4wS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakUyQ2lBZ0lDQXZMeUJoYTJsMFlVUkJUeUE5SUVkc2IySmhiRk4wWVhSbFBFRndjR3hwWTJGMGFXOXVQaWg3SUd0bGVUb2dSMnh2WW1Gc1UzUmhkR1ZMWlhsQmEybDBZVVJCVHlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXdHBkR0ZmWkdGdklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QmpiMjV6ZENCN0lHMXZaR1Z5WVhScGIyNGdmU0E5SUdkbGRFRnJhWFJoVTI5amFXRnNRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qRXhDaUFnSUNBdkx5QmpiMjV6ZENCYllYQndUR2x6ZEVKNWRHVnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLR0ZyYVhSaFJFRlBMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzBGcmFYUmhVMjlqYVdGc1FYQndUR2x6ZENrcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKellXd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUdOdmJuTjBJSHNnYlc5a1pYSmhkR2x2YmlCOUlEMGdaMlYwUVd0cGRHRlRiMk5wWVd4QmNIQk1hWE4wS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVcENpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pNMExUTTNDaUFnSUNBdkx5QnlaWFIxY200Z1lXSnBRMkZzYkR4MGVYQmxiMllnUVd0cGRHRlRiMk5wWVd4TmIyUmxjbUYwYVc5dUxuQnliM1J2ZEhsd1pTNXBjMEpoYm01bFpENG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2diVzlrWlhKaGRHbHZiaXdLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXMkZqWTI5MWJuUmRDaUFnSUNBdkx5QjlLUzV5WlhSMWNtNVdZV3gxWlFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0TkRJMk9XTTNPQ0F2THlCdFpYUm9iMlFnSW1selFtRnVibVZrS0dGa1pISmxjM01wWW05dmJDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUo1ZEdWeklHaGhjeUIyWVd4cFpDQndjbVZtYVhnS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1ltOXZiQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPanBCYTJsMFlWTnZZMmxoYkVkeVlYQm9MbUpzYXloMWMyVnlRV1JrY21WemN6b2dZbmwwWlhNc0lHSnNiMk5yWldSQlpHUnlaWE56T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21Kc2F6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdjSEpwZG1GMFpTQmliR3NvZFhObGNrRmtaSEpsYzNNNklFRmpZMjkxYm5Rc0lHSnNiMk5yWldSQlpHUnlaWE56T2lCQlkyTnZkVzUwS1RvZ1FteHZZMnRNYVhOMFMyVjVJSHNLSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QmpiMjV6ZENCMWMyVnlJRDBnZFhObGNrRmtaSEpsYzNNdVlubDBaWE11YzJ4cFkyVW9NQ3dnTVRZcExuUnZSbWw0WldRb2V5QnNaVzVuZEdnNklERTJJSDBwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lITjFZbk4wY21sdVp5QXdJREUyQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJNWlc1bmRHZ2diWFZ6ZENCaVpTQXhOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUJqYjI1emRDQmliRzlqYTJWa0lEMGdZbXh2WTJ0bFpFRmtaSEpsYzNNdVlubDBaWE11YzJ4cFkyVW9NQ3dnTVRZcExuUnZSbWw0WldRb2V5QnNaVzVuZEdnNklERTJJSDBwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lITjFZbk4wY21sdVp5QXdJREUyQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJNWlc1bmRHZ2diWFZ6ZENCaVpTQXhOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPalEwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdleUIxYzJWeUxDQmliRzlqYTJWa0lIMEtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPanBCYTJsMFlWTnZZMmxoYkVkeVlYQm9MbVpzZHloMWMyVnlPaUJpZVhSbGN5d2dabTlzYkc5M1pYSTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tabXgzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCd2NtbDJZWFJsSUdac2R5aDFjMlZ5T2lCQlkyTnZkVzUwTENCbWIyeHNiM2RsY2pvZ1FXTmpiM1Z1ZENrNklFWnZiR3h2ZDNOTFpYa2dld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk5Ea0tJQ0FnSUM4dklHTnZibk4wSUhWelpYSkNlWFJsY3lBOUlIVnpaWEl1WW5sMFpYTXVjMnhwWTJVb01Dd2dNVFlwTG5SdlJtbDRaV1FvZXlCc1pXNW5kR2c2SURFMklIMHBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhOMVluTjBjbWx1WnlBd0lERTJDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk1aVzVuZEdnZ2JYVnpkQ0JpWlNBeE5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QmpiMjV6ZENCbWIyeHNiM2RsY2tKNWRHVnpJRDBnWm05c2JHOTNaWEl1WW5sMFpYTXVjMnhwWTJVb01Dd2dNVFlwTG5SdlJtbDRaV1FvZXlCc1pXNW5kR2c2SURFMklIMHBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOMVluTjBjbWx1WnlBd0lERTJDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk1aVzVuZEdnZ2JYVnpkQ0JpWlNBeE5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QnlaWFIxY200Z2V5QjFjMlZ5T2lCMWMyVnlRbmwwWlhNc0lHWnZiR3h2ZDJWeU9pQm1iMnhzYjNkbGNrSjVkR1Z6SUgwS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qcEJhMmwwWVZOdlkybGhiRWR5WVhCb0xtZGxkRTFsZEdFb1lXUmtjbVZ6Y3pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwblpYUk5aWFJoT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCd2NtbDJZWFJsSUdkbGRFMWxkR0VvWVdSa2NtVnpjem9nUVdOamIzVnVkQ2s2SUUxbGRHRldZV3gxWlNCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8xTlFvZ0lDQWdMeThnWTI5dWMzUWdleUJ6YjJOcFlXd2dmU0E5SUdkbGRFRnJhWFJoVTI5amFXRnNRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveE5nb2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8xTlFvZ0lDQWdMeThnWTI5dWMzUWdleUJ6YjJOcFlXd2dmU0E5SUdkbGRFRnJhWFJoVTI5amFXRnNRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qRXhDaUFnSUNBdkx5QmpiMjV6ZENCYllYQndUR2x6ZEVKNWRHVnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLR0ZyYVhSaFJFRlBMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzBGcmFYUmhVMjlqYVdGc1FYQndUR2x6ZENrcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKellXd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUdOdmJuTjBJSHNnYzI5amFXRnNJSDBnUFNCblpYUkJhMmwwWVZOdlkybGhiRUZ3Y0V4cGMzUW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPalUyTFRVNUNpQWdJQ0F2THlCeVpYUjFjbTRnWVdKcFEyRnNiRHgwZVhCbGIyWWdRV3RwZEdGVGIyTnBZV3d1Y0hKdmRHOTBlWEJsTG1kbGRFMWxkR0UrS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUhOdlkybGhiQ3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXMkZrWkhKbGMzTmRDaUFnSUNBdkx5QjlLUzV5WlhSMWNtNVdZV3gxWlFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGczTXpsbFlUY3dZaUF2THlCdFpYUm9iMlFnSW1kbGRFMWxkR0VvWVdSa2NtVnpjeWtvWW05dmJDeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4aWIyOXNMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJREFnTkFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFSjVkR1Z6SUdoaGN5QjJZV3hwWkNCd2NtVm1hWGdLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURjMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wzUjVjR1Z6TG5Sek9qcE5aWFJoVm1Gc2RXVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzZRV3RwZEdGVGIyTnBZV3hIY21Gd2FDNTFjR1JoZEdWR2IyeHNiM2RsY2sxbGRHRW9ZV05qYjNWdWREb2dZbmwwWlhNc0lHNWxkMFp2Ykd4dmQyVnlTVzVrWlhnNklIVnBiblEyTkN3Z2JtVjNSbTlzYkc5M1pYSkRiM1Z1ZERvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1ZHYjJ4c2IzZGxjazFsZEdFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklIQnlhWFpoZEdVZ2RYQmtZWFJsUm05c2JHOTNaWEpOWlhSaEtHRmpZMjkxYm5RNklFRmpZMjkxYm5Rc0lHNWxkMFp2Ykd4dmQyVnlTVzVrWlhnNklIVnBiblEyTkN3Z2JtVjNSbTlzYkc5M1pYSkRiM1Z1ZERvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdZMjl1YzNRZ2V5QnpiMk5wWVd3Z2ZTQTlJR2RsZEVGcmFYUmhVMjlqYVdGc1FYQndUR2x6ZENoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem94TmdvZ0lDQWdMeThnWVd0cGRHRkVRVThnUFNCSGJHOWlZV3hUZEdGMFpUeEJjSEJzYVdOaGRHbHZiajRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVFXdHBkR0ZFUVU4Z2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRnJhWFJoWDJSaGJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdZMjl1YzNRZ2V5QnpiMk5wWVd3Z2ZTQTlJR2RsZEVGcmFYUmhVMjlqYVdGc1FYQndUR2x6ZENoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbEtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TWpFeENpQWdJQ0F2THlCamIyNXpkQ0JiWVhCd1RHbHpkRUo1ZEdWelhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRUo1ZEdWektHRnJhWFJoUkVGUExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMEZyYVhSaFUyOWphV0ZzUVhCd1RHbHpkQ2twQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0p6WVd3aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJR052Ym5OMElIc2djMjlqYVdGc0lIMGdQU0JuWlhSQmEybDBZVk52WTJsaGJFRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qWTBMVFkzQ2lBZ0lDQXZMeUJoWW1sRFlXeHNQSFI1Y0dWdlppQkJhMmwwWVZOdlkybGhiQzV3Y205MGIzUjVjR1V1ZFhCa1lYUmxSbTlzYkc5M1pYSk5aWFJoUGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCemIyTnBZV3dzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnRoWTJOdmRXNTBMQ0J1WlhkR2IyeHNiM2RsY2tsdVpHVjRMQ0J1WlhkR2IyeHNiM2RsY2tOdmRXNTBYUW9nSUNBZ0x5OGdmU2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdZWEpuY3pvZ1cyRmpZMjkxYm5Rc0lHNWxkMFp2Ykd4dmQyVnlTVzVrWlhnc0lHNWxkMFp2Ykd4dmQyVnlRMjkxYm5SZENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8yTkMwMk53b2dJQ0FnTHk4Z1lXSnBRMkZzYkR4MGVYQmxiMllnUVd0cGRHRlRiMk5wWVd3dWNISnZkRzkwZVhCbExuVndaR0YwWlVadmJHeHZkMlZ5VFdWMFlUNG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2djMjlqYVdGc0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYllXTmpiM1Z1ZEN3Z2JtVjNSbTlzYkc5M1pYSkpibVJsZUN3Z2JtVjNSbTlzYkc5M1pYSkRiM1Z1ZEYwS0lDQWdJQzh2SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnek16QTJZak15WVNBdkx5QnRaWFJvYjJRZ0luVndaR0YwWlVadmJHeHZkMlZ5VFdWMFlTaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02T2tGcmFYUmhVMjlqYVdGc1IzSmhjR2d1Wm05c2JHOTNTVzF3YkNodFluSlFZWGx0Wlc1ME9pQjFhVzUwTmpRc0lHRmtaSEpsYzNNNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwbWIyeHNiM2RKYlhCc09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTJNZ29nSUNBZ0x5OGdjSEpwZG1GMFpTQm1iMnhzYjNkSmJYQnNLRzFpY2xCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaXdnWVdSa2NtVnpjem9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UWXpDaUFnSUNBdkx5QmpiMjV6ZENCN0lHWnZiR3h2ZDNNZ2ZTQTlJSFJvYVhNdWJXSnlLRUo1ZEdWektDY25LU3dnSnljc0lFSjVkR1Z6S0NjbktTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0lpSUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ1kyRnNiSE4xWWlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZPa0poYzJWVGIyTnBZV3d1YldKeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE5qWUtJQ0FnSUM4dklHRnpjMlZ5ZEVWNFlXTjBVR0Y1YldWdWRDaHRZbkpRWVhsdFpXNTBMQ0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d2dabTlzYkc5M2N5QXJJSE53YjI1emIzSkRiM04wS0cxaWNsQmhlVzFsYm5RdWMyVnVaR1Z5TENCVWVHNHVjMlZ1WkdWeUtTa0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdkMGVHNXpJRk5sYm1SbGNnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pFd01Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhCaGVXVnlJRDA5UFNCdmQyNWxjaUEvSURBZ09pQlFZWGxsY2xKbFkyOXlaRTFDVWdvZ0lDQWdQVDBLSUNBZ0lHbHVkR01nTkNBdkx5QXlPRFV3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVFkyQ2lBZ0lDQXZMeUJoYzNObGNuUkZlR0ZqZEZCaGVXMWxiblFvYldKeVVHRjViV1Z1ZEN3Z1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zSUdadmJHeHZkM01nS3lCemNHOXVjMjl5UTI5emRDaHRZbkpRWVhsdFpXNTBMbk5sYm1SbGNpd2dWSGh1TG5ObGJtUmxjaWtwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJoYzNObGNuUkZlR0ZqZEZCaGVXMWxiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TmpnS0lDQWdJQzh2SUhSb2FYTXVZM0psWVhSbFJtOXNiRzkzS0ZSNGJpNXpaVzVrWlhJc0lHRmtaSEpsYzNNcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtDRjBhR2x6TG1selFtRnVibVZrS0hObGJtUmxjaWtzSUdWeWNrSmhibTVsWkNrS0lDQWdJR05oYkd4emRXSWdhWE5DWVc1dVpXUUtJQ0FnSUdKNklHWnZiR3h2ZDBsdGNHeGZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJR0o1ZEdWaklEa2dMeThnSWtWU1VqcGxjbkpDWVc1a0lnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrSmhibVFLQ21admJHeHZkMGx0Y0d4ZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TWpBeENpQWdJQ0F2THlCamIyNXpkQ0JpYkc5amEzTkxaWGtnUFNCMGFHbHpMbUpzYXloMWMyVnlMQ0JpYkc5amEyVmtLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyRnNiSE4xWWlCaWJHc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdZbXh2WTJ0eklEMGdRbTk0VFdGd1BFSnNiMk5yVEdsemRFdGxlU3dnWW5sMFpYTThNRDQrS0hzZ2EyVjVVSEpsWm1sNE9pQkJhMmwwWVZOdlkybGhiRUp2ZUZCeVpXWnBlRUpzYjJOcmN5QjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pJd01nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZbXh2WTJ0ektHSnNiMk5yYzB0bGVTa3VaWGhwYzNSekNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8zTWdvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtDRjBhR2x6TG1selFteHZZMnRsWkNoaFpHUnlaWE56TENCelpXNWtaWElwTENCbGNuSkNiRzlqYTJWa0tRb2dJQ0FnWW5vZ1ptOXNiRzkzU1cxd2JGOWhablJsY2w5aGMzTmxjblJBTlFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWxJNlpYSnlRbXhyWkNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBsY25KQ2JHdGtDZ3BtYjJ4c2IzZEpiWEJzWDJGbWRHVnlYMkZ6YzJWeWRFQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPamN6Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2MyVnVaR1Z5SUNFOVBTQmhaR1J5WlhOekxDQmxjbkpUWld4bVJtOXNiRzkzS1FvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDRTlDaUFnSUNCaWJub2dabTlzYkc5M1NXMXdiRjloWm5SbGNsOWhjM05sY25SQU53b2dJQ0FnY0hWemFHSjVkR1Z6SUNKRlVsSTZaWEp5VTJac2R5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSlRabXgzQ2dwbWIyeHNiM2RKYlhCc1gyRm1kR1Z5WDJGemMyVnlkRUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCamIyNXpkQ0I3SUdGMWRHOXRZWFJsWkNCOUlEMGdkR2hwY3k1blpYUk5aWFJoS0hObGJtUmxjaWtLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCblpYUk5aWFJoQ2lBZ0lDQndkWE5vYVc1MElETTVNZ29nSUNBZ1oyVjBZbWwwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TnpjS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDZ2hZWFYwYjIxaGRHVmtMQ0JsY25KQmRYUnZiV0YwWldSQlkyTnZkVzUwS1FvZ0lDQWdZbm9nWm05c2JHOTNTVzF3YkY5aFpuUmxjbDloYzNObGNuUkFPUW9nSUNBZ2NIVnphR0o1ZEdWeklDSkZVbEk2WlhKeVFYVjBieUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGxjbkpCZFhSdkNncG1iMnhzYjNkSmJYQnNYMkZtZEdWeVgyRnpjMlZ5ZEVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qZ3dDaUFnSUNBdkx5QmpiMjV6ZENCbWIyeHNiM2R6UzJWNUlEMGdkR2hwY3k1bWJIY29ZV1JrY21WemN5d2djMlZ1WkdWeUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJR1pzZHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCbWIyeHNiM2R6SUQwZ1FtOTRUV0Z3UEVadmJHeHZkM05MWlhrc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJRUZyYVhSaFUyOWphV0ZzUW05NFVISmxabWw0Um05c2JHOTNjeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWmlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk9ETUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2doZEdocGN5NW1iMnhzYjNkektHWnZiR3h2ZDNOTFpYa3BMbVY0YVhOMGN5d2daWEp5UVd4eVpXRmtlVVp2Ykd4dmQybHVaeWtLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1ptOXNiRzkzU1cxd2JGOWhablJsY2w5aGMzTmxjblJBTVRFS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09tVnlja0ZtYkhjaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVFXWnNkd29LWm05c2JHOTNTVzF3YkY5aFpuUmxjbDloYzNObGNuUkFNVEU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUdOdmJuTjBJSHNnWm05c2JHOTNaWEpEYjNWdWRDd2dabTlzYkc5M1pYSkpibVJsZUNCOUlEMGdkR2hwY3k1blpYUk5aWFJoS0dGa1pISmxjM01wQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBUV1YwWVFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEUXhDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBek13b2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzRPUW9nSUNBZ0x5OGdkR2hwY3k1bWIyeHNiM2R6S0dadmJHeHZkM05MWlhrcExuWmhiSFZsSUQwZ1ptOXNiRzkzWlhKSmJtUmxlQ0FySURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qa3hDaUFnSUNBdkx5QjBhR2x6TG5Wd1pHRjBaVVp2Ykd4dmQyVnlUV1YwWVNoaFpHUnlaWE56TENCbWIyeHNiM2RsY2tsdVpHVjRJQ3NnTVN3Z1ptOXNiRzkzWlhKRGIzVnVkQ0FySURFcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlIVndaR0YwWlVadmJHeHZkMlZ5VFdWMFlRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTJPUW9nSUNBZ0x5OGdjbVZqYjNKa1VHRjVaWElvZEdocGN5NW1iMnhzYjNkektIUm9hWE11Wm14M0tHRmtaSEpsYzNNc0lGUjRiaTV6Wlc1a1pYSXBLUzVyWlhrc0lHMWljbEJoZVcxbGJuUXVjMlZ1WkdWeUxDQlVlRzR1YzJWdVpHVnlLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqWVd4c2MzVmlJR1pzZHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCbWIyeHNiM2R6SUQwZ1FtOTRUV0Z3UEVadmJHeHZkM05MWlhrc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJRUZyYVhSaFUyOWphV0ZzUW05NFVISmxabWw0Um05c2JHOTNjeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWmlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTJPUW9nSUNBZ0x5OGdjbVZqYjNKa1VHRjVaWElvZEdocGN5NW1iMnhzYjNkektIUm9hWE11Wm14M0tHRmtaSEpsYzNNc0lGUjRiaTV6Wlc1a1pYSXBLUzVyWlhrc0lHMWljbEJoZVcxbGJuUXVjMlZ1WkdWeUxDQlVlRzR1YzJWdVpHVnlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCeVpXTnZjbVJRWVhsbGNnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPanBDWVhObFUyOWphV0ZzTG0xaWNpaHlaV1k2SUdKNWRHVnpMQ0J5WldaVWVYQmxUbUZ0WlRvZ1lubDBaWE1zSUhKbFpsUjVjR1ZUWTJobGJXRTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pwQ1lYTmxVMjlqYVdGc0xtMWljam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pveE5Rb2dJQ0FnTHk4Z2JXSnlLSEpsWmpvZ1lubDBaWE1zSUhKbFpsUjVjR1ZPWVcxbE9pQnpkSEpwYm1jc0lISmxabFI1Y0dWVFkyaGxiV0U2SUdKNWRHVnpLVG9nUVd0cGRHRlRiMk5wWVd4TlFsSkVZWFJoSUhzS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pFNUNpQWdJQ0F2THlCd2IzTjBjem9nVFdsdVVHOXpkSE5OUWxJZ0t5QW9RbTk0UTI5emRGQmxja0o1ZEdVZ0tpQnlaV1l1YkdWdVozUm9LU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURRd01Bb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQTBOek13TUFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pNd0NpQWdJQ0F2THlCeVpXWlVlWEJsY3pvZ1VtVm1WSGx3WlhOQ1lYTmxUVUpTSUNzZ0tFSnZlRU52YzNSUVpYSkNlWFJsSUNvZ0tFSjVkR1Z6S0hKbFpsUjVjR1ZPWVcxbEtTNXNaVzVuZEdnZ0t5QkNlWFJsY3loeVpXWlVlWEJsVTJOb1pXMWhLUzVzWlc1bmRHZ3BLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCc1pXNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0FyQ2lBZ0lDQndkWE5vYVc1MElEUXdNQW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0E1TXpBd0NpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk1UZ0tJQ0FnSUM4dklHSnNiMk5yY3pvZ1FteHZZMnR6VFVKU0xBb2dJQ0FnY0hWemFHbHVkQ0F4TlRjd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPakUyTFRNeENpQWdJQ0F2THlCeVpYUjFjbTRnZXdvZ0lDQWdMeThnSUNCbWIyeHNiM2R6T2lCR2IyeHNiM2R6VFVKU0xBb2dJQ0FnTHk4Z0lDQmliRzlqYTNNNklFSnNiMk5yYzAxQ1Vpd0tJQ0FnSUM4dklDQWdjRzl6ZEhNNklFMXBibEJ2YzNSelRVSlNJQ3NnS0VKdmVFTnZjM1JRWlhKQ2VYUmxJQ29nY21WbUxteGxibWQwYUNrc0NpQWdJQ0F2THlBZ0lIWnZkR1Z6T2lCV2IzUmxjMDFDVWl3S0lDQWdJQzh2SUNBZ2RtOTBaV3hwYzNRNklGWnZkR1ZzYVhOMFRVSlNMQW9nSUNBZ0x5OGdJQ0J5WldGamRHbHZibk02SUZKbFlXTjBhVzl1YzAxQ1Vpd0tJQ0FnSUM4dklDQWdjbVZoWTNScGIyNXNhWE4wT2lCU1pXRmpkR2x2YmxKbFkyOXlaRTFDVWl3S0lDQWdJQzh2SUNBZ2JXVjBZVG9nVFdWMFlVMUNVaXdLSUNBZ0lDOHZJQ0FnYlc5a1pYSmhkRzl5Y3pvZ1RXOWtaWEpoZEc5eWMwMUNVaXdLSUNBZ0lDOHZJQ0FnWW1GdWJtVmtPaUJDWVc1dVpXUk5RbElzQ2lBZ0lDQXZMeUFnSUdGamRHbHZibk02SUVGamRHbHZibk5OUWxJc0NpQWdJQ0F2THlBZ0lDOHZJRUp2ZUNCclpYazZJSEJ5WldacGVDZ3hLU0FySUhWcGJuUTJOQ2c0S1NBOUlEa2dZbmwwWlhNS0lDQWdJQzh2SUNBZ0x5OGdRbTk0SUhaaGJIVmxPaUJCVWtNdE5DQm9aV0ZrWlhJb05Da2dLeUJ6ZEhKcGJtY2diR1Z1WjNSb0tESXBJQ3NnYm1GdFpTQXJJR0o1ZEdWeklHeGxibWQwYUNneUtTQXJJSE5qYUdWdFlRb2dJQ0FnTHk4Z0lDQnlaV1pVZVhCbGN6b2dVbVZtVkhsd1pYTkNZWE5sVFVKU0lDc2dLRUp2ZUVOdmMzUlFaWEpDZVhSbElDb2dLRUo1ZEdWektISmxabFI1Y0dWT1lXMWxLUzVzWlc1bmRHZ2dLeUJDZVhSbGN5aHlaV1pVZVhCbFUyTm9aVzFoS1M1c1pXNW5kR2dwS1FvZ0lDQWdMeThnZlFvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREEzWW1RME1EQXdNREF3TURBd01EQXdNMlExTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZNakFLSUNBZ0lDOHZJSFp2ZEdWek9pQldiM1JsYzAxQ1Vpd0tJQ0FnSUhCMWMyaHBiblFnTVRrek1EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem94Tmkwek1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhzS0lDQWdJQzh2SUNBZ1ptOXNiRzkzY3pvZ1JtOXNiRzkzYzAxQ1Vpd0tJQ0FnSUM4dklDQWdZbXh2WTJ0ek9pQkNiRzlqYTNOTlFsSXNDaUFnSUNBdkx5QWdJSEJ2YzNSek9pQk5hVzVRYjNOMGMwMUNVaUFySUNoQ2IzaERiM04wVUdWeVFubDBaU0FxSUhKbFppNXNaVzVuZEdncExBb2dJQ0FnTHk4Z0lDQjJiM1JsY3pvZ1ZtOTBaWE5OUWxJc0NpQWdJQ0F2THlBZ0lIWnZkR1ZzYVhOME9pQldiM1JsYkdsemRFMUNVaXdLSUNBZ0lDOHZJQ0FnY21WaFkzUnBiMjV6T2lCU1pXRmpkR2x2Ym5OTlFsSXNDaUFnSUNBdkx5QWdJSEpsWVdOMGFXOXViR2x6ZERvZ1VtVmhZM1JwYjI1U1pXTnZjbVJOUWxJc0NpQWdJQ0F2THlBZ0lHMWxkR0U2SUUxbGRHRk5RbElzQ2lBZ0lDQXZMeUFnSUcxdlpHVnlZWFJ2Y25NNklFMXZaR1Z5WVhSdmNuTk5RbElzQ2lBZ0lDQXZMeUFnSUdKaGJtNWxaRG9nUW1GdWJtVmtUVUpTTEFvZ0lDQWdMeThnSUNCaFkzUnBiMjV6T2lCQlkzUnBiMjV6VFVKU0xBb2dJQ0FnTHk4Z0lDQXZMeUJDYjNnZ2EyVjVPaUJ3Y21WbWFYZ29NU2tnS3lCMWFXNTBOalFvT0NrZ1BTQTVJR0o1ZEdWekNpQWdJQ0F2THlBZ0lDOHZJRUp2ZUNCMllXeDFaVG9nUVZKRExUUWdhR1ZoWkdWeUtEUXBJQ3NnYzNSeWFXNW5JR3hsYm1kMGFDZ3lLU0FySUc1aGJXVWdLeUJpZVhSbGN5QnNaVzVuZEdnb01pa2dLeUJ6WTJobGJXRUtJQ0FnSUM4dklDQWdjbVZtVkhsd1pYTTZJRkpsWmxSNWNHVnpRbUZ6WlUxQ1VpQXJJQ2hDYjNoRGIzTjBVR1Z5UW5sMFpTQXFJQ2hDZVhSbGN5aHlaV1pVZVhCbFRtRnRaU2t1YkdWdVozUm9JQ3NnUW5sMFpYTW9jbVZtVkhsd1pWTmphR1Z0WVNrdWJHVnVaM1JvS1NrS0lDQWdJQzh2SUgwS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pJeUNpQWdJQ0F2THlCeVpXRmpkR2x2Ym5NNklGSmxZV04wYVc5dWMwMUNVaXdLSUNBZ0lIQjFjMmhwYm5RZ01qSXhNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pveE5pMHpNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdabTlzYkc5M2N6b2dSbTlzYkc5M2MwMUNVaXdLSUNBZ0lDOHZJQ0FnWW14dlkydHpPaUJDYkc5amEzTk5RbElzQ2lBZ0lDQXZMeUFnSUhCdmMzUnpPaUJOYVc1UWIzTjBjMDFDVWlBcklDaENiM2hEYjNOMFVHVnlRbmwwWlNBcUlISmxaaTVzWlc1bmRHZ3BMQW9nSUNBZ0x5OGdJQ0IyYjNSbGN6b2dWbTkwWlhOTlFsSXNDaUFnSUNBdkx5QWdJSFp2ZEdWc2FYTjBPaUJXYjNSbGJHbHpkRTFDVWl3S0lDQWdJQzh2SUNBZ2NtVmhZM1JwYjI1ek9pQlNaV0ZqZEdsdmJuTk5RbElzQ2lBZ0lDQXZMeUFnSUhKbFlXTjBhVzl1YkdsemREb2dVbVZoWTNScGIyNVNaV052Y21STlFsSXNDaUFnSUNBdkx5QWdJRzFsZEdFNklFMWxkR0ZOUWxJc0NpQWdJQ0F2THlBZ0lHMXZaR1Z5WVhSdmNuTTZJRTF2WkdWeVlYUnZjbk5OUWxJc0NpQWdJQ0F2THlBZ0lHSmhibTVsWkRvZ1FtRnVibVZrVFVKU0xBb2dJQ0FnTHk4Z0lDQmhZM1JwYjI1ek9pQkJZM1JwYjI1elRVSlNMQW9nSUNBZ0x5OGdJQ0F2THlCQ2IzZ2dhMlY1T2lCd2NtVm1hWGdvTVNrZ0t5QjFhVzUwTmpRb09Da2dQU0E1SUdKNWRHVnpDaUFnSUNBdkx5QWdJQzh2SUVKdmVDQjJZV3gxWlRvZ1FWSkRMVFFnYUdWaFpHVnlLRFFwSUNzZ2MzUnlhVzVuSUd4bGJtZDBhQ2d5S1NBcklHNWhiV1VnS3lCaWVYUmxjeUJzWlc1bmRHZ29NaWtnS3lCelkyaGxiV0VLSUNBZ0lDOHZJQ0FnY21WbVZIbHdaWE02SUZKbFpsUjVjR1Z6UW1GelpVMUNVaUFySUNoQ2IzaERiM04wVUdWeVFubDBaU0FxSUNoQ2VYUmxjeWh5WldaVWVYQmxUbUZ0WlNrdWJHVnVaM1JvSUNzZ1FubDBaWE1vY21WbVZIbHdaVk5qYUdWdFlTa3ViR1Z1WjNSb0tTa0tJQ0FnSUM4dklIMEtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk1qUUtJQ0FnSUM4dklHMWxkR0U2SUUxbGRHRk5RbElzQ2lBZ0lDQndkWE5vYVc1MElEUTFNekF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk1UWXRNekVLSUNBZ0lDOHZJSEpsZEhWeWJpQjdDaUFnSUNBdkx5QWdJR1p2Ykd4dmQzTTZJRVp2Ykd4dmQzTk5RbElzQ2lBZ0lDQXZMeUFnSUdKc2IyTnJjem9nUW14dlkydHpUVUpTTEFvZ0lDQWdMeThnSUNCd2IzTjBjem9nVFdsdVVHOXpkSE5OUWxJZ0t5QW9RbTk0UTI5emRGQmxja0o1ZEdVZ0tpQnlaV1l1YkdWdVozUm9LU3dLSUNBZ0lDOHZJQ0FnZG05MFpYTTZJRlp2ZEdWelRVSlNMQW9nSUNBZ0x5OGdJQ0IyYjNSbGJHbHpkRG9nVm05MFpXeHBjM1JOUWxJc0NpQWdJQ0F2THlBZ0lISmxZV04wYVc5dWN6b2dVbVZoWTNScGIyNXpUVUpTTEFvZ0lDQWdMeThnSUNCeVpXRmpkR2x2Ym14cGMzUTZJRkpsWVdOMGFXOXVVbVZqYjNKa1RVSlNMQW9nSUNBZ0x5OGdJQ0J0WlhSaE9pQk5aWFJoVFVKU0xBb2dJQ0FnTHk4Z0lDQnRiMlJsY21GMGIzSnpPaUJOYjJSbGNtRjBiM0p6VFVKU0xBb2dJQ0FnTHk4Z0lDQmlZVzV1WldRNklFSmhibTVsWkUxQ1Vpd0tJQ0FnSUM4dklDQWdZV04wYVc5dWN6b2dRV04wYVc5dWMwMUNVaXdLSUNBZ0lDOHZJQ0FnTHk4Z1FtOTRJR3RsZVRvZ2NISmxabWw0S0RFcElDc2dkV2x1ZERZMEtEZ3BJRDBnT1NCaWVYUmxjd29nSUNBZ0x5OGdJQ0F2THlCQ2IzZ2dkbUZzZFdVNklFRlNReTAwSUdobFlXUmxjaWcwS1NBcklITjBjbWx1WnlCc1pXNW5kR2dvTWlrZ0t5QnVZVzFsSUNzZ1lubDBaWE1nYkdWdVozUm9LRElwSUNzZ2MyTm9aVzFoQ2lBZ0lDQXZMeUFnSUhKbFpsUjVjR1Z6T2lCU1pXWlVlWEJsYzBKaGMyVk5RbElnS3lBb1FtOTRRMjl6ZEZCbGNrSjVkR1VnS2lBb1FubDBaWE1vY21WbVZIbHdaVTVoYldVcExteGxibWQwYUNBcklFSjVkR1Z6S0hKbFpsUjVjR1ZUWTJobGJXRXBMbXhsYm1kMGFDa3BDaUFnSUNBdkx5QjlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pveU5Rb2dJQ0FnTHk4Z2JXOWtaWEpoZEc5eWN6b2dUVzlrWlhKaGRHOXljMDFDVWl3S0lDQWdJSEIxYzJocGJuUWdNVGc1TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6b3hOaTB6TVFvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnWm05c2JHOTNjem9nUm05c2JHOTNjMDFDVWl3S0lDQWdJQzh2SUNBZ1lteHZZMnR6T2lCQ2JHOWphM05OUWxJc0NpQWdJQ0F2THlBZ0lIQnZjM1J6T2lCTmFXNVFiM04wYzAxQ1VpQXJJQ2hDYjNoRGIzTjBVR1Z5UW5sMFpTQXFJSEpsWmk1c1pXNW5kR2dwTEFvZ0lDQWdMeThnSUNCMmIzUmxjem9nVm05MFpYTk5RbElzQ2lBZ0lDQXZMeUFnSUhadmRHVnNhWE4wT2lCV2IzUmxiR2x6ZEUxQ1Vpd0tJQ0FnSUM4dklDQWdjbVZoWTNScGIyNXpPaUJTWldGamRHbHZibk5OUWxJc0NpQWdJQ0F2THlBZ0lISmxZV04wYVc5dWJHbHpkRG9nVW1WaFkzUnBiMjVTWldOdmNtUk5RbElzQ2lBZ0lDQXZMeUFnSUcxbGRHRTZJRTFsZEdGTlFsSXNDaUFnSUNBdkx5QWdJRzF2WkdWeVlYUnZjbk02SUUxdlpHVnlZWFJ2Y25OTlFsSXNDaUFnSUNBdkx5QWdJR0poYm01bFpEb2dRbUZ1Ym1Wa1RVSlNMQW9nSUNBZ0x5OGdJQ0JoWTNScGIyNXpPaUJCWTNScGIyNXpUVUpTTEFvZ0lDQWdMeThnSUNBdkx5QkNiM2dnYTJWNU9pQndjbVZtYVhnb01Ta2dLeUIxYVc1ME5qUW9PQ2tnUFNBNUlHSjVkR1Z6Q2lBZ0lDQXZMeUFnSUM4dklFSnZlQ0IyWVd4MVpUb2dRVkpETFRRZ2FHVmhaR1Z5S0RRcElDc2djM1J5YVc1bklHeGxibWQwYUNneUtTQXJJRzVoYldVZ0t5QmllWFJsY3lCc1pXNW5kR2dvTWlrZ0t5QnpZMmhsYldFS0lDQWdJQzh2SUNBZ2NtVm1WSGx3WlhNNklGSmxabFI1Y0dWelFtRnpaVTFDVWlBcklDaENiM2hEYjNOMFVHVnlRbmwwWlNBcUlDaENlWFJsY3loeVpXWlVlWEJsVG1GdFpTa3ViR1Z1WjNSb0lDc2dRbmwwWlhNb2NtVm1WSGx3WlZOamFHVnRZU2t1YkdWdVozUm9LU2tLSUNBZ0lDOHZJSDBLSUNBZ0lHbDBiMklLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPakkzQ2lBZ0lDQXZMeUJoWTNScGIyNXpPaUJCWTNScGIyNXpUVUpTTEFvZ0lDQWdjSFZ6YUdsdWRDQXlPVGN3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qRTJMVE14Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdld29nSUNBZ0x5OGdJQ0JtYjJ4c2IzZHpPaUJHYjJ4c2IzZHpUVUpTTEFvZ0lDQWdMeThnSUNCaWJHOWphM002SUVKc2IyTnJjMDFDVWl3S0lDQWdJQzh2SUNBZ2NHOXpkSE02SUUxcGJsQnZjM1J6VFVKU0lDc2dLRUp2ZUVOdmMzUlFaWEpDZVhSbElDb2djbVZtTG14bGJtZDBhQ2tzQ2lBZ0lDQXZMeUFnSUhadmRHVnpPaUJXYjNSbGMwMUNVaXdLSUNBZ0lDOHZJQ0FnZG05MFpXeHBjM1E2SUZadmRHVnNhWE4wVFVKU0xBb2dJQ0FnTHk4Z0lDQnlaV0ZqZEdsdmJuTTZJRkpsWVdOMGFXOXVjMDFDVWl3S0lDQWdJQzh2SUNBZ2NtVmhZM1JwYjI1c2FYTjBPaUJTWldGamRHbHZibEpsWTI5eVpFMUNVaXdLSUNBZ0lDOHZJQ0FnYldWMFlUb2dUV1YwWVUxQ1Vpd0tJQ0FnSUM4dklDQWdiVzlrWlhKaGRHOXljem9nVFc5a1pYSmhkRzl5YzAxQ1Vpd0tJQ0FnSUM4dklDQWdZbUZ1Ym1Wa09pQkNZVzV1WldSTlFsSXNDaUFnSUNBdkx5QWdJR0ZqZEdsdmJuTTZJRUZqZEdsdmJuTk5RbElzQ2lBZ0lDQXZMeUFnSUM4dklFSnZlQ0JyWlhrNklIQnlaV1pwZUNneEtTQXJJSFZwYm5RMk5DZzRLU0E5SURrZ1lubDBaWE1LSUNBZ0lDOHZJQ0FnTHk4Z1FtOTRJSFpoYkhWbE9pQkJVa010TkNCb1pXRmtaWElvTkNrZ0t5QnpkSEpwYm1jZ2JHVnVaM1JvS0RJcElDc2dibUZ0WlNBcklHSjVkR1Z6SUd4bGJtZDBhQ2d5S1NBcklITmphR1Z0WVFvZ0lDQWdMeThnSUNCeVpXWlVlWEJsY3pvZ1VtVm1WSGx3WlhOQ1lYTmxUVUpTSUNzZ0tFSnZlRU52YzNSUVpYSkNlWFJsSUNvZ0tFSjVkR1Z6S0hKbFpsUjVjR1ZPWVcxbEtTNXNaVzVuZEdnZ0t5QkNlWFJsY3loeVpXWlVlWEJsVTJOb1pXMWhLUzVzWlc1bmRHZ3BLUW9nSUNBZ0x5OGdmUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQUFFZ0F0VGVBU1lPQ1dGcmFYUmhYMlJoYndRVkgzeDFBV1lBQVdJQkFBTmhZV3dEYzJGc0IzWmxjbk5wYjI0TFJWSlNPbVZ5Y2tKaGJtUUxSVkpTT21WeWNrWm5kR1VHZDJGc2JHVjBDMFZTVWpwbGNuSk9aR0Z2QTNCaGJJQUU2cEdBM1RZYUFJNEJBSU14R1JSRU1SaEJBR3lDRGdTMW5JcFVCSzdyczNnRW4xd1l2UVNHWjFTVUJFdHZrSDhFRmhzNmVnUkRBMmFPQk90aTlRZ0VDWU9BcEFRejZTeVVCSVZON2VBRUZESlB0d1NoTktKNEJEUkJkZkEyR2dDT0RnRUdBWThCM1FRT0JKY0V4d1VtQlV3RmNnWGVBQUVHQWdZN0Jvd0FJME9BQkcrWUYvWTJHZ0NPQVFEU0FERVpnUVFTTVJnUVJFSUZkb29EQUl2OU9Ba3lBeEpBQUErQUMwVlNVanBsY25KT1kyeHpzQUNML1RnZ01nTVNRQUFQZ0F0RlVsSTZaWEp5VG5KcmViQUFpLzA0QjR2K0VrQUFENEFMUlZKU09tVnlja2x3YlhLd0FJdjlPQWlML3hKQUFBK0FDMFZTVWpwbGNuSkpjRzFoc0FDSmlnTUFpLzZML3hOQkFBdUwvUUdBQVNSTVVJdit2NG1LQXdHTC9RR0FBU1JNVUVtK1FBQUtpLzhXaS81TVVJd0FpVXk4U0l2L0lRUUlTd0Z6QUVVQlFBQUhTVElCRDBFQUVDTkJBQVZNVEJaUWlVVUJpLzVDLy9VaVF2L3ROaG9CU1JXQkNCSkVGellhQWtraVdTVUlTd0VWRWtSWEFnQW9Ud0puSndoTVp5TkRNUllqQ1VrNEVDTVNSRFlhQVVrVkpCSkVNUUNJQmg1QkFBUW5DYkFBTVFCTEFSTkFBQStBQzBWU1VqcGxjbkpUWW14cnNBQXlDaXRIQW9nSHA0RUlXMDhEU1U0Q09BQkpUZ1F4QUJJaEJDSlBBazBJVEU0Q2lQNjlNUUJQQW9nR0RpY0VURkJKdlVVQlFRQVBnQXRGVWxJNlpYSnlSV0pzYTdBQVNTSzVTREVBVEU0Q2lQNzRJME0yR2dGSkZTUVNSREVBVElnRjJDY0VURkJKdlVVQlFBQVBnQXRGVWxJNlpYSnlWVzVpYTdBQVNieElNUUFyUndLSUJ5aUJDRnVJL3RSSlZ3QWdUQ1Jic2JJSXNnY2pzaEFpc2dHekkwTWlSd014RmlVSlNUZ1FJeEpFTVJZakNVbE9BamdRZ1FZU1JEWWFBVWtWSkJKRU5ob0NTUldCQ0JKRUYwa2lLR1ZFSndabFNJRllXMDRFTVFCT0FqSU5URElPVGdaQUFKSkdBaklEU1NJV1R3TkpUZ0pRVHdOUVRGQk1VQ2NGVUVzQmlBVnFWeklJUlFvaUtHVkVURWxYQ0NCTEFWY0FDRThDVjBnZ1RnSlFURkJGQ0VzRk9CaE1Kd1psU0lFb1d4SkJBRU5MQkRnWlFBQThTd1E0RzRFRUVrRUFNa3NFT1JvQWdBU2JGSDBzRWtFQUkwc0VPUm9CU3djU1FRQVlTd1E1R2dKTENSSkJBQTBqUUFBRUp3cXdBSWdGWkNORElrTC84RXNCUVFBRlN3WkFBU2dpUUFBUGdBdEZVbEk2WlhKeVNHNTNiTEFBU1VBQUQ0QUxSVkpTT21WeWNraDBiM0N3QUNKT0Ewc0JFMEVBUjA4Q1NFbUFFSE53Wlc1a2FXNW5YMkZrWkhKbGMzTmxURVVKUVFBWVN3Y1ZKQkpCQUJCTEIwc0NFa0VBQ0VzQlN3VVRRQUFQZ0F0RlVsSTZaWEp5U0c1aVpMQUFJMDRDU1lBU1kyOXVkSEp2Ykd4bFpGOWhaR1J5WlhOelpVRUFCMGtWSkJKQUFBK0FDMFZTVWpwbGNuSkpkMngwc0FCSlN3TVNRUUJPSTB4TEFvQUljbVZtWlhKeVpYSmxRUUEwU1JVa0VrRUFMVTRFU3dOTEFVOERTVTREVFU0Q1FRQVdUd0lXVHdKUVRGQk1VRXhRSndVaVR3TlVVRUwrajBneUEwTC81RWd5QTA0RVF2L05Td0Z5Q0V4T0FrQUFCMFVCSWt4Qy82TkpTd0lTUVFBTFRITUNTRElERWt4Qy81Rkpjd0pJVHdJU1RFTC9oa3NCY2dkTVJReEJBQmRMQmhhQUJXRndjRWxFVEZBRFN3c1NRUUFFSTBMK3VDSkMvclF4RmlVSlNUZ1FJeEpFTVJZakNVbE9Ba2s0RUlFR0VrUTJHZ0ZKVGdKSkZTUVNSSWdEZDFjeUNFNERJaWhsUkRFQVRnUk1PQmhNSndabFNJRW9XeEpCQUVOTEJEZ1pRQUE4U3dRNEc0RUVFa0VBTWtzRU9Sb0FnQVJEa2laVkVrRUFJMHNFT1JvQlN3TVNRUUFZU3dRNUdnSkxCQkpCQUEwalFBQUVKd3F3QUlnRGhDTkRJa0wvOERFV0l3bEpPQkFqRWtRMkdnRkhBaFVrRWtTSUF2NkJNbHRCQUErQUMwVlNVanBsY25KSVozUmxzQUNJQTFBalF6WWFBVWNDRlNRU1JERUFpQUs3S2t4UVNiMUZBVUFBRDRBTFJWSlNPbVZ5Y2s1bWJIZXdBRXhKaUFLNFNZRXBXMHlCSVZ0TUl3bUlBdUpKdkVneEFDdEhBb2dEM2lKYmlQdUxTVmNBSUV3a1c3R3lDTElISTdJUUlySUJzeU5ETmhvQlNSVWtFa1EyR2dKSkZTUVNSSWdDUENjRVRGQzlSUUVuQlNKUEFsUXBURkN3STBNMkdnRkpGU1FTUkRZYUFra1ZKQkpFVElnQ01DcE1VTDFGQVNjRklrOENWQ2xNVUxBalF6WWFBVWtWSkJKRU5ob0NTUlVrRWtSTWlBSUtLa3hRdmtRWEZpbE1VTEFqUXpZYUFVa2lXU1VJU3dFVkVrUlhBZ0F4QUNJb1pVUW5DMlZJY2doRUVrQUFCQ2NNc0FBaUtHVkVKdzFsU0lFUVd6SU5Fa0FBRDRBTFJWSlNPbVZ5Y2tsMWNHZXdBQ2NJVEdjalF6WWFBVWtWZ1FnU1JCY3hBQ0lvWlVRbkMyVkljZ2hFRWtBQUJDY01zQUFvVEdjalF6WWFBVWtpV1NVSVN3RVZFa1JYQWdBMkdnSkpJbGtsQ0VzQkZSSkVWd0lBTmhvRFNTSlpKUWhMQVJVU1JGY0NBSWdDdFNsTVVMQWpRellhQVVrVlN3RWlXVW1CQkJKRVN3SkxBVXNEVWlKWmdSRUxnUVlJU3dNbFdVbExBaEpFU3dSTEFVc0ZVaUpaU1lFUkN5VUlUd01JVHdRU1JFNERVaUpaQ0lHUU5RdUIxRWdJRmlsTVVMQWpRellhQVVrVmdRZ1NSQmRKTmhvQ1NVNENGU1FTUkRZYUEwa1ZnUWdTUkJkSlR3S0FER0ZyYVhSaFgyRnpjMlYwYzJWSUlsdE1RUUJwU3dKTEFYQUFSUUZBQUY2eFN3TW5EV1ZJVndBSUl4WXlBMHNFc2hpQUJMTmlOS1d5R2s4Q3NocE1zaHF5R29BQ0FBQ3lHb0FFYURYanZMSWFnUWF5RUNLeUFiTzBQa2xYQkFCTVZ3QUVLUkpFU1JVakVrUWlVMEVBRGpJUUZvQUJGRXhRS1V4UXNDTkRnQWtLQUFBQUFBQUFBQUJDLyt5S0FRRWlLR1ZFSndkbFNJRVlXN0d5R0lBRWhDYWNlTElhaS8reUdvRUdzaEFpc2dHenRENUpWd1FBVEZjQUJDa1NSRWtWSXhKRUlsT0ppZ0lCaS81UkFCQkpGWUVRRWtTTC8xRUFFRWtWZ1JBU1JGQ0ppZ0lCaS81UkFCQkpGWUVRRWtTTC8xRUFFRWtWZ1JBU1JGQ0ppZ0VCSWlobFJDY0haVWdpVzdHeUdJQUVjNTZuQzdJYWkvK3lHb0VHc2hBaXNnR3p0RDVKVndRQVRGY0FCQ2tTUkVrVmdVb1NSSW1LQXdBaUtHVkVKd2RsU0NKYnNZditGb3YvRms4Q3NoaUFCRE1Hc3lxeUdvdjlzaHBNc2hxeUdvRUdzaEFpc2dHemlZb0NBQ3RIQW9nQXpDSmJNZ3FML2pnQVNVNERNUUFTSVFRaVR3Sk5Ud0lJaS81T0FvajM0VEVBU1lqKytVRUFCQ2NKc0FDTC8wc0JpUDhsSndSTVVMMUZBVUVBRDRBTFJWSlNPbVZ5Y2tKc2EyU3dBRW1ML3hOQUFBK0FDMFZTVWpwbGNuSlRabXgzc0FCSmlQOG9nWWdEVTBFQUQ0QUxSVkpTT21WeWNrRjFkRyt3QUl2L1RJais4U3BNVUVtOVJRRkJBQStBQzBWU1VqcGxjbkpCWm14M3NBQ0wvNGorN2ttQktWdE1nU0ZiSXdoSkZrOERUTDlNSXdpTC8wNENpUDhNaS84eEFJaitzaXBNVURFQVRFNENpUGVjaVlvREFZdjlGWUdRQXd1QnhQRUNDSXYrRll2L0ZRaUJrQU1MZ2RSSUNJSFVlaFpQQWhhQUVBQUFBQUFBQUh2VUFBQUFBQUFBUFZSTVVJSGtsZ0VXVEVzQlVFeFFnZFNzQVJaUVRGQ0I5T0VDRmxDQjFKTUJGa3hMQVZCTVVJR0U2QUVXVUV3V1VJaz0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
