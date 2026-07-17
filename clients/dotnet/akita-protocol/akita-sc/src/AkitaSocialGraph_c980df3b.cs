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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWtpdGFTb2NpYWxHcmFwaCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBa2l0YVNvY2lhbE1CUkRhdGEiOlt7Im5hbWUiOiJmb2xsb3dzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImJsb2NrcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwb3N0cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2b3RlbGlzdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZWFjdGlvbnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmVhY3Rpb25saXN0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1ldGEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibW9kZXJhdG9ycyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiYW5uZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWN0aW9ucyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZWZUeXBlcyIsInR5cGUiOiJ1aW50NjQifV0sIkJsb2NrTGlzdEtleSI6W3sibmFtZSI6InVzZXIiLCJ0eXBlIjoiYnl0ZVsxNl0ifSx7Im5hbWUiOiJibG9ja2VkIiwidHlwZSI6ImJ5dGVbMTZdIn1dLCJGb2xsb3dzS2V5IjpbeyJuYW1lIjoidXNlciIsInR5cGUiOiJieXRlWzE2XSJ9LHsibmFtZSI6ImZvbGxvd2VyIiwidHlwZSI6ImJ5dGVbMTZdIn1dLCJWaWV3UGF5V2FsbFZhbHVlIjpbeyJuYW1lIjoidXNlclBheUluZm8iLCJ0eXBlIjoiVmlld1BheVdhbGxWYWx1ZVVzZXJQYXlJbmZvW10ifSx7Im5hbWUiOiJhZ2VudFBheUluZm8iLCJ0eXBlIjoiVmlld1BheVdhbGxWYWx1ZVVzZXJQYXlJbmZvW10ifV0sInRpcE1CUkluZm8iOlt7Im5hbWUiOiJ0eXBlIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoiYXJjNTgiLCJ0eXBlIjoidWludDY0In1dLCJWaWV3UGF5V2FsbFZhbHVlVXNlclBheUluZm8iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjoiQ3JlYXRlIG1ldGhvZCB0byBpbml0aWFsaXplIHRoZSBjb250cmFjdCB3aXRoIHRoZSBEQU8gcmVmZXJlbmNlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhRGFvIiwiZGVzYyI6IlRoZSBBa2l0YSBEQU8gYXBwIElEIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2ZXJzaW9uIiwiZGVzYyI6IlRoZSB2ZXJzaW9uIHN0cmluZyBmb3IgdGhpcyBjb250cmFjdCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJibG9jayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bmJsb2NrIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdhdGVkRm9sbG93IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFwcGwiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnYXRlVHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmb2xsb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5mb2xsb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNCbG9ja2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmxvY2tlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzRm9sbG93aW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmb2xsb3dlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRGb2xsb3dJbmRleCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZm9sbG93ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtYnIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWZUeXBlTmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVmVHlwZVNjaGVtYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQWtpdGFTb2NpYWxNQlJEYXRhIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF5V2FsbE1iciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoKHVpbnQ4LHVpbnQ2NCx1aW50NjQpW10sKHVpbnQ4LHVpbnQ2NCx1aW50NjQpW10pIiwic3RydWN0IjoiVmlld1BheVdhbGxWYWx1ZSIsIm5hbWUiOiJwYXl3YWxsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hlY2tUaXBNYnJSZXF1aXJlbWVudHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ4LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJ0aXBNQlJJbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1ZlcnNpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUFraXRhREFPIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wVXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4OTldLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE3NiwxMzc0LDE0ODVdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY2Ml0sImVycm9yTWVzc2FnZSI6IkVSUjpBRkxXIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYzMF0sImVycm9yTWVzc2FnZSI6IkVSUjpBVVRPIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkyLDM3Nyw3MTYsMTU1N10sImVycm9yTWVzc2FnZSI6IkVSUjpCQU5EIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU4Nl0sImVycm9yTWVzc2FnZSI6IkVSUjpCTEtEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc0XSwiZXJyb3JNZXNzYWdlIjoiRVJSOkZHVEUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NTddLCJlcnJvck1lc3NhZ2UiOiJFUlI6SEdURSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0MSw2MDQsNjg3XSwiZXJyb3JNZXNzYWdlIjoiRVJSOklQQVkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjgwXSwiZXJyb3JNZXNzYWdlIjoiRVJSOklVUEciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjUxLDEzMThdLCJlcnJvck1lc3NhZ2UiOiJFUlI6TkRBTyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0N10sImVycm9yTWVzc2FnZSI6IkVSUjpORkxXIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEyXSwiZXJyb3JNZXNzYWdlIjoiRVJSOlNCTEsiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjA2XSwiZXJyb3JNZXNzYWdlIjoiRVJSOlNGTFciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDldLCJlcnJvck1lc3NhZ2UiOiJFUlI6VU5CSyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzOTYsMTQwNywxNDIzLDE0MzRdLCJlcnJvck1lc3NhZ2UiOiJMZW5ndGggbXVzdCBiZSAxNiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNDMsMTMxMF0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4MiwxMjM2LDEyNTUsMTMwMywxMzMxLDE0NDMsMTQ5OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0Myw5MTMsOTI5LDk0NSw5ODcsMTAxMSwxMDI5LDEyMjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTAsOTIwLDkzNiw5NTIsMTIyN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODEsMzY2LDQ3MSw2MzYsNzA1LDgwMiw4MTAsODQxLDg0OSw4ODEsODg5LDEwNjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM2LDEwNTQsMTA3MywxMjk2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4MSwxMzc5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDkxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9zb2NpYWwvdHlwZXMudHM6Ok1ldGFWYWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL3NvY2lhbC90eXBlcy50czo6Vmlld1BheVdhbGxWYWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk3OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rKHVpbnQ4LHVpbnQ2NCx1aW50NjQpW10pLChsZW4rKHVpbnQ4LHVpbnQ2NCx1aW50NjQpW10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICgobGVuKyh1aW50OCx1aW50NjQsdWludDY0KVtdKSwobGVuKyh1aW50OCx1aW50NjQsdWludDY0KVtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NzMsOTk3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2MF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXBwbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3Myw0NDgsNjI3XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRE15SURJS0lDQWdJR0o1ZEdWallteHZZMnNnSW1GcmFYUmhYMlJoYnlJZ01IZ3hOVEZtTjJNM05TQWlJaUFpUlZKU09rSkJUa1FpSUNKaUlpQWlaaUlnSWtWU1VqcEpVRUZaSWlBaWMyRnNJaUFpZG1WeWMybHZiaUlnSW5CaGJDSWdJbmRoYkd4bGRDSWdJa1ZTVWpwT1JFRlBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FXdHBkR0ZUYjJOcFlXeEhjbUZ3YUNCbGVIUmxibVJ6SUdOc1lYTnpaWE1vUW1GelpWTnZZMmxoYkN3Z1ZYQm5jbUZrWldGaWJHVkJhMmwwWVVKaGMyVkRiMjUwY21GamRDa2dld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRaV0U1TVRnd1pHUWdMeThnYldWMGFHOWtJQ0oxY0dSaGRHVW9jM1J5YVc1bktYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYM1Z3WkdGMFpWOXliM1YwWlVBMENncHRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZyYVhSaFUyOWphV0ZzUjNKaGNHZ2daWGgwWlc1a2N5QmpiR0Z6YzJWektFSmhjMlZUYjJOcFlXd3NJRlZ3WjNKaFpHVmhZbXhsUVd0cGRHRkNZWE5sUTI5dWRISmhZM1FwSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNakVLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhpTlRsak9HRTFOQ0F3ZUdGbFpXSmlNemM0SURCNE9EWTJOelUwT1RRZ01IZzBZalptT1RBM1ppQXdlREUyTVdJellUZGhJREI0TkRNd016WTJPR1VnTUhobFlqWXlaalV3T0NBd2VEQTVPRE00TUdFMElEQjRNVFF6TWpSbVlqY2dNSGhoTVRNMFlUSTNPQ0F3ZURNME5ERTNOV1l3SURCNE16TmxPVEpqT1RRZ01IZzROVFJrWldSbE1DQXZMeUJ0WlhSb2IyUWdJbUpzYjJOcktIQmhlU3hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luVnVZbXh2WTJzb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0puWVhSbFpFWnZiR3h2ZHlod1lYa3NZWEJ3YkN4aFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbVp2Ykd4dmR5aHdZWGtzWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSjFibVp2Ykd4dmR5aGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1selFteHZZMnRsWkNoaFpHUnlaWE56TEdGa1pISmxjM01wWW05dmJDSXNJRzFsZEdodlpDQWlhWE5HYjJ4c2IzZHBibWNvWVdSa2NtVnpjeXhoWkdSeVpYTnpLV0p2YjJ3aUxDQnRaWFJvYjJRZ0ltZGxkRVp2Ykd4dmQwbHVaR1Y0S0dGa1pISmxjM01zWVdSa2NtVnpjeWwxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbTFpY2loaWVYUmxXMTBzYzNSeWFXNW5MR0o1ZEdWYlhTa29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKd1lYbFhZV3hzVFdKeUtDZ29kV2x1ZERnc2RXbHVkRFkwTEhWcGJuUTJOQ2xiWFN3b2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RMk5DbGJYU2twZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pqYUdWamExUnBjRTFpY2xKbGNYVnBjbVZ0Wlc1MGN5aDFhVzUwTmpRc1lXUmtjbVZ6Y3l4MWFXNTBOalFwS0hWcGJuUTRMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJblZ3WkdGMFpVRnJhWFJoUkVGUEtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p2Y0ZWd0tDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1lteHZZMnNnZFc1aWJHOWpheUJuWVhSbFpFWnZiR3h2ZHlCbWIyeHNiM2NnZFc1bWIyeHNiM2NnYVhOQ2JHOWphMlZrSUdselJtOXNiRzkzYVc1bklHZGxkRVp2Ykd4dmQwbHVaR1Y0SUcxaWNpQndZWGxYWVd4c1RXSnlJR05vWldOclZHbHdUV0p5VW1WeGRXbHlaVzFsYm5SeklIVndaR0YwWlVGcmFYUmhSRUZQSUcxaGFXNWZiM0JWY0Y5eWIzVjBaVUF4T1FvZ0lDQWdaWEp5Q2dwdFlXbHVYMjl3VlhCZmNtOTFkR1ZBTVRrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvME1Rb2dJQ0FnTHk4Z2IzQlZjQ2dwT2lCMmIybGtJSHNnZlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeU1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGcmFYUmhVMjlqYVdGc1IzSmhjR2dnWlhoMFpXNWtjeUJqYkdGemMyVnpLRUpoYzJWVGIyTnBZV3dzSUZWd1ozSmhaR1ZoWW14bFFXdHBkR0ZDWVhObFEyOXVkSEpoWTNRcElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEWm1PVGd4TjJZMklDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtIVnBiblEyTkN4emRISnBibWNwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR055WldGMFpRb2dJQ0FnWlhKeUNncHRZV2x1WDNWd1pHRjBaVjl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZORFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJRnNuVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRuWFNCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2NIVnphR2x1ZENBMElDOHZJRlZ3WkdGMFpVRndjR3hwWTJGMGFXOXVDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHSWdkWEJrWVhSbENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pwQmEybDBZVk52WTJsaGJFZHlZWEJvTG1OeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHOXVRM0psWVhSbE9pQW5jbVZ4ZFdseVpTY2dmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk1qY0tJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUhSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVZ1BTQmhhMmwwWVVSaGJ3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TWpVS0lDQWdJQzh2SUhabGNuTnBiMjRnUFNCSGJHOWlZV3hUZEdGMFpUeHpkSEpwYm1jK0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVlpsY25OcGIyNGdmU2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblpsY25OcGIyNGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNak1LSUNBZ0lDOHZJSFJvYVhNdWRtVnljMmx2Ymk1MllXeDFaU0E5SUhabGNuTnBiMjRLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TWpBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnZia055WldGMFpUb2dKM0psY1hWcGNtVW5JSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPanBCYTJsMFlWTnZZMmxoYkVkeVlYQm9MbUpzYjJOclczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZbXh2WTJzNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk9UVUtJQ0FnSUM4dklHSnNiMk5yS0cxaWNsQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3Z1lXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzVOZ29nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0NGMGFHbHpMbWx6UW1GdWJtVmtLRlI0Ymk1elpXNWtaWElwTENCRlVsSmZRa0ZPVGtWRUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMkZzYkhOMVlpQnBjMEpoYm01bFpBb2dJQ0FnWW5vZ1lteHZZMnRmWVdaMFpYSmZZWE56WlhKMFFETUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0lrVlNVanBDUVU1RUlnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT2tKQlRrUUtDbUpzYjJOclgyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2prM0NpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9WSGh1TG5ObGJtUmxjaUFoUFQwZ1lXUmtjbVZ6Y3l3Z1JWSlNYMU5GVEVaZlFreFBRMHNwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNUW9nSUNBZ0lUMEtJQ0FnSUdKdWVpQmliRzlqYTE5aFpuUmxjbDloYzNObGNuUkFOUW9nSUNBZ2NIVnphR0o1ZEdWeklDSkZVbEk2VTBKTVN5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwVFFreExDZ3BpYkc5amExOWhablJsY2w5aGMzTmxjblJBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE1EQXRNVEEyQ2lBZ0lDQXZMeUJ0WVhSamFDZ0tJQ0FnSUM4dklDQWdiV0p5VUdGNWJXVnVkQ3dLSUNBZ0lDOHZJQ0FnZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklIUm9hWE11YldKeUtFSjVkR1Z6S0NjbktTd2dKeWNzSUVKNWRHVnpLQ2NuS1NrdVlteHZZMnR6Q2lBZ0lDQXZMeUFnSUgwS0lDQWdJQzh2SUNrc0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRXdNd29nSUNBZ0x5OGdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNREF0TVRBMkNpQWdJQ0F2THlCdFlYUmphQ2dLSUNBZ0lDOHZJQ0FnYldKeVVHRjViV1Z1ZEN3S0lDQWdJQzh2SUNBZ2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJSFJvYVhNdWJXSnlLRUo1ZEdWektDY25LU3dnSnljc0lFSjVkR1Z6S0NjbktTa3VZbXh2WTJ0ekNpQWdJQ0F2THlBZ0lIMEtJQ0FnSUM4dklDa3NDaUFnSUNBOVBRb2dJQ0FnYzNkaGNBb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UQTBDaUFnSUNBdkx5QmhiVzkxYm5RNklIUm9hWE11YldKeUtFSjVkR1Z6S0NjbktTd2dKeWNzSUVKNWRHVnpLQ2NuS1NrdVlteHZZMnR6Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0lpQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR05oYkd4emRXSWdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pwQ1lYTmxVMjlqYVdGc0xtMWljZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRXdNQzB4TURZS0lDQWdJQzh2SUcxaGRHTm9LQW9nSUNBZ0x5OGdJQ0J0WW5KUVlYbHRaVzUwTEFvZ0lDQWdMeThnSUNCN0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dkR2hwY3k1dFluSW9RbmwwWlhNb0p5Y3BMQ0FuSnl3Z1FubDBaWE1vSnljcEtTNWliRzlqYTNNS0lDQWdJQzh2SUNBZ2ZRb2dJQ0FnTHk4Z0tTd0tJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2prNUxURXdPQW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0FvZ0lDQWdMeThnSUNCdFlYUmphQ2dLSUNBZ0lDOHZJQ0FnSUNCdFluSlFZWGx0Wlc1MExBb2dJQ0FnTHk4Z0lDQWdJSHNLSUNBZ0lDOHZJQ0FnSUNBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQWdJR0Z0YjNWdWREb2dkR2hwY3k1dFluSW9RbmwwWlhNb0p5Y3BMQ0FuSnl3Z1FubDBaWE1vSnljcEtTNWliRzlqYTNNS0lDQWdJQzh2SUNBZ0lDQjlDaUFnSUNBdkx5QWdJQ2tzQ2lBZ0lDQXZMeUFnSUVWU1VsOUpUbFpCVEVsRVgxQkJXVTFGVGxRS0lDQWdJQzh2SUNrS0lDQWdJR0p1ZWlCaWJHOWphMTloWm5SbGNsOWhjM05sY25SQU53b2dJQ0FnWW5sMFpXTWdOaUF2THlBaVJWSlNPa2xRUVZraUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2U1ZCQldRb0tZbXh2WTJ0ZllXWjBaWEpmWVhOelpYSjBRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRFd0NpQWdJQ0F2THlCamIyNXpkQ0JpYkc5amEzTkxaWGtnUFNCMGFHbHpMbUpzYXloVWVHNHVjMlZ1WkdWeUxDQmhaR1J5WlhOektRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdZbXhyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUdKc2IyTnJjeUE5SUVKdmVFMWhjRHhDYkc5amEweHBjM1JMWlhrc0lHSjVkR1Z6UERBK1BpaDdJR3RsZVZCeVpXWnBlRG9nUVd0cGRHRlRiMk5wWVd4Q2IzaFFjbVZtYVhoQ2JHOWphM01nZlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1JaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNVEVLSUNBZ0lDOHZJSFJvYVhNdVlteHZZMnR6S0dKc2IyTnJjMHRsZVNrdVkzSmxZWFJsS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzVOUW9nSUNBZ0x5OGdZbXh2WTJzb2JXSnlVR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhodUxDQmhaR1J5WlhOek9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pwQmEybDBZVk52WTJsaGJFZHlZWEJvTG5WdVlteHZZMnRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWJtSnNiMk5yT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TVRRS0lDQWdJQzh2SUhWdVlteHZZMnNvWVdSa2NtVnpjem9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVEUxQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb0lYUm9hWE11YVhOQ1lXNXVaV1FvVkhodUxuTmxibVJsY2lrc0lFVlNVbDlDUVU1T1JVUXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqWVd4c2MzVmlJR2x6UW1GdWJtVmtDaUFnSUNCaWVpQjFibUpzYjJOclgyRm1kR1Z5WDJGemMyVnlkRUF6Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pGVWxJNlFrRk9SQ0lLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcENRVTVFQ2dwMWJtSnNiMk5yWDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakV4TndvZ0lDQWdMeThnWTI5dWMzUWdZbXh2WTJ0elMyVjVJRDBnZEdocGN5NWliR3NvVkhodUxuTmxibVJsY2l3Z1lXUmtjbVZ6Y3lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlHSnNhd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJpYkc5amEzTWdQU0JDYjNoTllYQThRbXh2WTJ0TWFYTjBTMlY1TENCaWVYUmxjend3UGo0b2V5QnJaWGxRY21WbWFYZzZJRUZyYVhSaFUyOWphV0ZzUW05NFVISmxabWw0UW14dlkydHpJSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0ppSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRXhPQW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0hSb2FYTXVZbXh2WTJ0ektHSnNiMk5yYzB0bGVTa3VaWGhwYzNSekxDQkZVbEpmVlZORlVsOU9UMVJmUWt4UFEwdEZSQ2tLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklIVnVZbXh2WTJ0ZllXWjBaWEpmWVhOelpYSjBRRFVLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT2xWT1Frc2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlZVNUNTd29LZFc1aWJHOWphMTloWm5SbGNsOWhjM05sY25SQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNVGtLSUNBZ0lDOHZJSFJvYVhNdVlteHZZMnR6S0dKc2IyTnJjMHRsZVNrdVpHVnNaWFJsS0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hNakV0TVRJMkNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJSFJvYVhNdWJXSnlLRUo1ZEdWektDY25LU3dnSnljc0lFSjVkR1Z6S0NjbktTa3VZbXh2WTJ0ekNpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRXlNd29nSUNBZ0x5OGdjbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVEkwQ2lBZ0lDQXZMeUJoYlc5MWJuUTZJSFJvYVhNdWJXSnlLRUo1ZEdWektDY25LU3dnSnljc0lFSjVkR1Z6S0NjbktTa3VZbXh2WTJ0ekNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNJaUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUdOaGJHeHpkV0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qcENZWE5sVTI5amFXRnNMbTFpY2dvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TWpFdE1USTFDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUhSb2FYTXViV0p5S0VKNWRHVnpLQ2NuS1N3Z0p5Y3NJRUo1ZEdWektDY25LU2t1WW14dlkydHpDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1USXhMVEV5TmdvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQjBhR2x6TG0xaWNpaENlWFJsY3lnbkp5a3NJQ2NuTENCQ2VYUmxjeWduSnlrcExtSnNiMk5yY3dvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1URTBDaUFnSUNBdkx5QjFibUpzYjJOcktHRmtaSEpsYzNNNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02T2tGcmFYUmhVMjlqYVdGc1IzSmhjR2d1WjJGMFpXUkdiMnhzYjNkYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5ZWFJsWkVadmJHeHZkem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TWprdE1UTXpDaUFnSUNBdkx5Qm5ZWFJsWkVadmJHeHZkeWdLSUNBZ0lDOHZJQ0FnYldKeVVHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1TEFvZ0lDQWdMeThnSUNCbllYUmxWSGh1T2lCbmRIaHVMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JGUjRiaXdLSUNBZ0lDOHZJQ0FnWVdSa2NtVnpjem9nUVdOamIzVnVkQW9nSUNBZ0x5OGdLVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaGNIQnNDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakV6TkFvZ0lDQWdMeThnWTI5dWMzUWdleUJtYjJ4c2IzZEhZWFJsU1VRZ2ZTQTlJSFJvYVhNdVoyVjBUV1YwWVNoaFpHUnlaWE56S1FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJOWlhSaENpQWdJQ0JsZUhSeVlXTjBJRFV3SURnS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE16VUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2huWVhSbFEyaGxZMnNvWjJGMFpWUjRiaXdnZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlN3Z1ZIaHVMbk5sYm1SbGNpd2dabTlzYkc5M1IyRjBaVWxFS1N3Z1JWSlNYMFpCU1V4RlJGOUhRVlJGS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTlpWVhObExuUnpPakkzQ2lBZ0lDQXZMeUJoYTJsMFlVUkJUeUE5SUVkc2IySmhiRk4wWVhSbFBFRndjR3hwWTJGMGFXOXVQaWg3SUd0bGVUb2dSMnh2WW1Gc1UzUmhkR1ZMWlhsQmEybDBZVVJCVHlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXdHBkR0ZmWkdGdklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRXpOUW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0dkaGRHVkRhR1ZqYXlobllYUmxWSGh1TENCMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQlVlRzR1YzJWdVpHVnlMQ0JtYjJ4c2IzZEhZWFJsU1VRcExDQkZVbEpmUmtGSlRFVkVYMGRCVkVVcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem95TXpNS0lDQWdJQzh2SUdkaGRHVlVlRzR1WVhCd1NXUWdQVDA5SUVGd2NHeHBZMkYwYVc5dUtHZGxkRUZyYVhSaFFYQndUR2x6ZENoaGEybDBZVVJCVHlrdVoyRjBaU2tnSmlZS0lDQWdJSE4zWVhBS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZORFFLSUNBZ0lDOHZJR052Ym5OMElGdGhjSEJNYVhOMFFubDBaWE5kSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFFubDBaWE1vWVd0cGRHRkVRVThzSUVKNWRHVnpLRUZyYVhSaFJFRlBSMnh2WW1Gc1UzUmhkR1ZMWlhselFXdHBkR0ZCY0hCTWFYTjBLU2tLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlZV0ZzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveU16TUtJQ0FnSUM4dklHZGhkR1ZVZUc0dVlYQndTV1FnUFQwOUlFRndjR3hwWTJGMGFXOXVLR2RsZEVGcmFYUmhRWEJ3VEdsemRDaGhhMmwwWVVSQlR5a3VaMkYwWlNrZ0ppWUtJQ0FnSUhCMWMyaHBiblFnTkRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0E5UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem95TXpNdE1qTTBDaUFnSUNBdkx5Qm5ZWFJsVkhodUxtRndjRWxrSUQwOVBTQkJjSEJzYVdOaGRHbHZiaWhuWlhSQmEybDBZVUZ3Y0V4cGMzUW9ZV3RwZEdGRVFVOHBMbWRoZEdVcElDWW1DaUFnSUNBdkx5Qm5ZWFJsVkhodUxtOXVRMjl0Y0d4bGRHbHZiaUE5UFQwZ1QyNURiMjF3YkdWMFpVRmpkR2x2Ymk1T2IwOXdJQ1ltQ2lBZ0lDQmllaUJuWVhSbFpFWnZiR3h2ZDE5aWIyOXNYMlpoYkhObFFERXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qSXpOQW9nSUNBZ0x5OGdaMkYwWlZSNGJpNXZia052YlhCc1pYUnBiMjRnUFQwOUlFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVRtOVBjQ0FtSmdvZ0lDQWdaR2xuSURNS0lDQWdJR2QwZUc1eklFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3lNek10TWpNMENpQWdJQ0F2THlCbllYUmxWSGh1TG1Gd2NFbGtJRDA5UFNCQmNIQnNhV05oZEdsdmJpaG5aWFJCYTJsMFlVRndjRXhwYzNRb1lXdHBkR0ZFUVU4cExtZGhkR1VwSUNZbUNpQWdJQ0F2THlCbllYUmxWSGh1TG05dVEyOXRjR3hsZEdsdmJpQTlQVDBnVDI1RGIyMXdiR1YwWlVGamRHbHZiaTVPYjA5d0lDWW1DaUFnSUNCaWJub2daMkYwWldSR2IyeHNiM2RmWW05dmJGOW1ZV3h6WlVBeE13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveU16VUtJQ0FnSUM4dklHZGhkR1ZVZUc0dWJuVnRRWEJ3UVhKbmN5QTlQVDBnTkNBbUpnb2dJQ0FnWkdsbklETUtJQ0FnSUdkMGVHNXpJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TWpNekxUSXpOUW9nSUNBZ0x5OGdaMkYwWlZSNGJpNWhjSEJKWkNBOVBUMGdRWEJ3YkdsallYUnBiMjRvWjJWMFFXdHBkR0ZCY0hCTWFYTjBLR0ZyYVhSaFJFRlBLUzVuWVhSbEtTQW1KZ29nSUNBZ0x5OGdaMkYwWlZSNGJpNXZia052YlhCc1pYUnBiMjRnUFQwOUlFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVRtOVBjQ0FtSmdvZ0lDQWdMeThnWjJGMFpWUjRiaTV1ZFcxQmNIQkJjbWR6SUQwOVBTQTBJQ1ltQ2lBZ0lDQmllaUJuWVhSbFpFWnZiR3h2ZDE5aWIyOXNYMlpoYkhObFFERXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qSXpOZ29nSUNBZ0x5OGdaMkYwWlZSNGJpNWhjSEJCY21kektEQXBJRDA5UFNCdFpYUm9iMlJUWld4bFkzUnZjangwZVhCbGIyWWdSMkYwWlM1d2NtOTBiM1I1Y0dVdWJYVnpkRU5vWldOclBpZ3BJQ1ltQ2lBZ0lDQmthV2NnTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZDBlRzV6WVhNZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwTXpreU1qWTFOU0F2THlCdFpYUm9iMlFnSW0xMWMzUkRhR1ZqYXloaFpHUnlaWE56TEhWcGJuUTJOQ3hpZVhSbFcxMWJYU2wyYjJsa0lnb2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TWpNekxUSXpOZ29nSUNBZ0x5OGdaMkYwWlZSNGJpNWhjSEJKWkNBOVBUMGdRWEJ3YkdsallYUnBiMjRvWjJWMFFXdHBkR0ZCY0hCTWFYTjBLR0ZyYVhSaFJFRlBLUzVuWVhSbEtTQW1KZ29nSUNBZ0x5OGdaMkYwWlZSNGJpNXZia052YlhCc1pYUnBiMjRnUFQwOUlFOXVRMjl0Y0d4bGRHVkJZM1JwYjI0dVRtOVBjQ0FtSmdvZ0lDQWdMeThnWjJGMFpWUjRiaTV1ZFcxQmNIQkJjbWR6SUQwOVBTQTBJQ1ltQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbUZ3Y0VGeVozTW9NQ2tnUFQwOUlHMWxkR2h2WkZObGJHVmpkRzl5UEhSNWNHVnZaaUJIWVhSbExuQnliM1J2ZEhsd1pTNXRkWE4wUTJobFkycytLQ2tnSmlZS0lDQWdJR0o2SUdkaGRHVmtSbTlzYkc5M1gySnZiMnhmWm1Gc2MyVkFNVE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNak0zQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbUZ3Y0VGeVozTW9NU2tnUFQwOUlHNWxkeUJCWkdSeVpYTnpLR05oYkd4bGNpa3VZbmwwWlhNZ0ppWUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWjNSNGJuTmhjeUJCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdScFp5QXhDaUFnSUNBOVBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pveU16TXRNak0zQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbUZ3Y0Vsa0lEMDlQU0JCY0hCc2FXTmhkR2x2YmloblpYUkJhMmwwWVVGd2NFeHBjM1FvWVd0cGRHRkVRVThwTG1kaGRHVXBJQ1ltQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbTl1UTI5dGNHeGxkR2x2YmlBOVBUMGdUMjVEYjIxd2JHVjBaVUZqZEdsdmJpNU9iMDl3SUNZbUNpQWdJQ0F2THlCbllYUmxWSGh1TG01MWJVRndjRUZ5WjNNZ1BUMDlJRFFnSmlZS0lDQWdJQzh2SUdkaGRHVlVlRzR1WVhCd1FYSm5jeWd3S1NBOVBUMGdiV1YwYUc5a1UyVnNaV04wYjNJOGRIbHdaVzltSUVkaGRHVXVjSEp2ZEc5MGVYQmxMbTExYzNSRGFHVmphejRvS1NBbUpnb2dJQ0FnTHk4Z1oyRjBaVlI0Ymk1aGNIQkJjbWR6S0RFcElEMDlQU0J1WlhjZ1FXUmtjbVZ6Y3loallXeHNaWElwTG1KNWRHVnpJQ1ltQ2lBZ0lDQmllaUJuWVhSbFpFWnZiR3h2ZDE5aWIyOXNYMlpoYkhObFFERXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qSXpPQW9nSUNBZ0x5OGdaMkYwWlZSNGJpNWhjSEJCY21kektESXBJRDA5UFNCcGRHOWlLR2xrS1FvZ0lDQWdaR2xuSURNS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQm5kSGh1YzJGeklFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURJS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakl6TXkweU16Z0tJQ0FnSUM4dklHZGhkR1ZVZUc0dVlYQndTV1FnUFQwOUlFRndjR3hwWTJGMGFXOXVLR2RsZEVGcmFYUmhRWEJ3VEdsemRDaGhhMmwwWVVSQlR5a3VaMkYwWlNrZ0ppWUtJQ0FnSUM4dklHZGhkR1ZVZUc0dWIyNURiMjF3YkdWMGFXOXVJRDA5UFNCUGJrTnZiWEJzWlhSbFFXTjBhVzl1TGs1dlQzQWdKaVlLSUNBZ0lDOHZJR2RoZEdWVWVHNHViblZ0UVhCd1FYSm5jeUE5UFQwZ05DQW1KZ29nSUNBZ0x5OGdaMkYwWlZSNGJpNWhjSEJCY21kektEQXBJRDA5UFNCdFpYUm9iMlJUWld4bFkzUnZjangwZVhCbGIyWWdSMkYwWlM1d2NtOTBiM1I1Y0dVdWJYVnpkRU5vWldOclBpZ3BJQ1ltQ2lBZ0lDQXZMeUJuWVhSbFZIaHVMbUZ3Y0VGeVozTW9NU2tnUFQwOUlHNWxkeUJCWkdSeVpYTnpLR05oYkd4bGNpa3VZbmwwWlhNZ0ppWUtJQ0FnSUM4dklHZGhkR1ZVZUc0dVlYQndRWEpuY3lneUtTQTlQVDBnYVhSdllpaHBaQ2tLSUNBZ0lHSjZJR2RoZEdWa1JtOXNiRzkzWDJKdmIyeGZabUZzYzJWQU1UTUtJQ0FnSUdsdWRHTmZNU0F2THlBeENncG5ZWFJsWkVadmJHeHZkMTlpYjI5c1gyMWxjbWRsUURFME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRXpOUW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0dkaGRHVkRhR1ZqYXlobllYUmxWSGh1TENCMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQlVlRzR1YzJWdVpHVnlMQ0JtYjJ4c2IzZEhZWFJsU1VRcExDQkZVbEpmUmtGSlRFVkVYMGRCVkVVcENpQWdJQ0JpYm5vZ1oyRjBaV1JHYjJ4c2IzZGZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09rWkhWRVVpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZSa2RVUlFvS1oyRjBaV1JHYjJ4c2IzZGZZV1owWlhKZllYTnpaWEowUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UTTNDaUFnSUNBdkx5QmpiMjV6ZENCN0lHWnZiR3h2ZDNNZ2ZTQTlJSFJvYVhNdWJXSnlLRUo1ZEdWektDY25LU3dnSnljc0lFSjVkR1Z6S0NjbktTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0lpSUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ1kyRnNiSE4xWWlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZPa0poYzJWVGIyTnBZV3d1YldKeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE16a3RNVFExQ2lBZ0lDQXZMeUJ0WVhSamFDZ0tJQ0FnSUM4dklDQWdiV0p5VUdGNWJXVnVkQ3dLSUNBZ0lDOHZJQ0FnZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklHWnZiR3h2ZDNNS0lDQWdJQzh2SUNBZ2ZRb2dJQ0FnTHk4Z0tTd0tJQ0FnSUdScFp5QTFDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVFF5Q2lBZ0lDQXZMeUJ5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakV6T1MweE5EVUtJQ0FnSUM4dklHMWhkR05vS0FvZ0lDQWdMeThnSUNCdFluSlFZWGx0Wlc1MExBb2dJQ0FnTHk4Z0lDQjdDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nWm05c2JHOTNjd29nSUNBZ0x5OGdJQ0I5Q2lBZ0lDQXZMeUFwTEFvZ0lDQWdQVDBLSUNBZ0lITjNZWEFLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TXpndE1UUTNDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvQ2lBZ0lDQXZMeUFnSUcxaGRHTm9LQW9nSUNBZ0x5OGdJQ0FnSUcxaWNsQmhlVzFsYm5Rc0NpQWdJQ0F2THlBZ0lDQWdld29nSUNBZ0x5OGdJQ0FnSUNBZ2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lDQWdZVzF2ZFc1ME9pQm1iMnhzYjNkekNpQWdJQ0F2THlBZ0lDQWdmUW9nSUNBZ0x5OGdJQ0FwTEFvZ0lDQWdMeThnSUNCRlVsSmZTVTVXUVV4SlJGOVFRVmxOUlU1VUNpQWdJQ0F2THlBcENpQWdJQ0JpYm5vZ1oyRjBaV1JHYjJ4c2IzZGZZV1owWlhKZllYTnpaWEowUURVS0lDQWdJR0o1ZEdWaklEWWdMeThnSWtWU1VqcEpVRUZaSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPa2xRUVZrS0NtZGhkR1ZrUm05c2JHOTNYMkZtZEdWeVgyRnpjMlZ5ZEVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTBPUW9nSUNBZ0x5OGdkR2hwY3k1amNtVmhkR1ZHYjJ4c2IzY29WSGh1TG5ObGJtUmxjaXdnWVdSa2NtVnpjeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUdOeVpXRjBaVVp2Ykd4dmR3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRXlPUzB4TXpNS0lDQWdJQzh2SUdkaGRHVmtSbTlzYkc5M0tBb2dJQ0FnTHk4Z0lDQnRZbkpRWVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHNDaUFnSUNBdkx5QWdJR2RoZEdWVWVHNDZJR2QwZUc0dVFYQndiR2xqWVhScGIyNURZV3hzVkhodUxBb2dJQ0FnTHk4Z0lDQmhaR1J5WlhOek9pQkJZMk52ZFc1MENpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZGhkR1ZrUm05c2JHOTNYMkp2YjJ4ZlptRnNjMlZBTVRNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJuWVhSbFpFWnZiR3h2ZDE5aWIyOXNYMjFsY21kbFFERTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qcEJhMmwwWVZOdlkybGhiRWR5WVhCb0xtWnZiR3h2ZDF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtWnZiR3h2ZHpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE5USUtJQ0FnSUM4dklHWnZiR3h2ZHlodFluSlFZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0c0lHRmtaSEpsYzNNNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRVekNpQWdJQ0F2THlCamIyNXpkQ0I3SUdadmJHeHZkMGRoZEdWSlJDQjlJRDBnZEdocGN5NW5aWFJOWlhSaEtHRmtaSEpsYzNNcENpQWdJQ0JqWVd4c2MzVmlJR2RsZEUxbGRHRUtJQ0FnSUhCMWMyaHBiblFnTlRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UVTBDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvWm05c2JHOTNSMkYwWlVsRUlEMDlQU0F3TENCRlVsSmZTRUZUWDBkQlZFVXBDaUFnSUNCaWVpQm1iMnhzYjNkZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT2toSFZFVWlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlNFZFVSUW9LWm05c2JHOTNYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTFOZ29nSUNBZ0x5OGdZMjl1YzNRZ2V5Qm1iMnhzYjNkeklIMGdQU0IwYUdsekxtMWljaWhDZVhSbGN5Z25KeWtzSUNjbkxDQkNlWFJsY3lnbkp5a3BDaUFnSUNCaWVYUmxZMTh5SUM4dklDSWlDaUFnSUNCa2RYQnVJRElLSUNBZ0lHTmhiR3h6ZFdJZ2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPanBDWVhObFUyOWphV0ZzTG0xaWNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1UVTRMVEUyTkFvZ0lDQWdMeThnYldGMFkyZ29DaUFnSUNBdkx5QWdJRzFpY2xCaGVXMWxiblFzQ2lBZ0lDQXZMeUFnSUhzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQm1iMnhzYjNkekNpQWdJQ0F2THlBZ0lIMEtJQ0FnSUM4dklDa3NDaUFnSUNCa2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakUyTVFvZ0lDQWdMeThnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94TlRndE1UWTBDaUFnSUNBdkx5QnRZWFJqYUNnS0lDQWdJQzh2SUNBZ2JXSnlVR0Y1YldWdWRDd0tJQ0FnSUM4dklDQWdld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUdadmJHeHZkM01LSUNBZ0lDOHZJQ0FnZlFvZ0lDQWdMeThnS1N3S0lDQWdJRDA5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRVM0xURTJOZ29nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0FvZ0lDQWdMeThnSUNCdFlYUmphQ2dLSUNBZ0lDOHZJQ0FnSUNCdFluSlFZWGx0Wlc1MExBb2dJQ0FnTHk4Z0lDQWdJSHNLSUNBZ0lDOHZJQ0FnSUNBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQWdJR0Z0YjNWdWREb2dabTlzYkc5M2N3b2dJQ0FnTHk4Z0lDQWdJSDBLSUNBZ0lDOHZJQ0FnS1N3S0lDQWdJQzh2SUNBZ1JWSlNYMGxPVmtGTVNVUmZVRUZaVFVWT1ZBb2dJQ0FnTHk4Z0tRb2dJQ0FnWW01NklHWnZiR3h2ZDE5aFpuUmxjbDloYzNObGNuUkFOUW9nSUNBZ1lubDBaV01nTmlBdkx5QWlSVkpTT2tsUVFWa2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlNWQkJXUW9LWm05c2JHOTNYMkZtZEdWeVgyRnpjMlZ5ZEVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTJPQW9nSUNBZ0x5OGdkR2hwY3k1amNtVmhkR1ZHYjJ4c2IzY29WSGh1TG5ObGJtUmxjaXdnWVdSa2NtVnpjeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXhDaUFnSUNCallXeHNjM1ZpSUdOeVpXRjBaVVp2Ykd4dmR3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTFNZ29nSUNBZ0x5OGdabTlzYkc5M0tHMWljbEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSNGJpd2dZV1JrY21WemN6b2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvNlFXdHBkR0ZUYjJOcFlXeEhjbUZ3YUM1MWJtWnZiR3h2ZDF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVnVabTlzYkc5M09nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE56RUtJQ0FnSUM4dklIVnVabTlzYkc5M0tHRmtaSEpsYzNNNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFM01nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLQ0YwYUdsekxtbHpRbUZ1Ym1Wa0tGUjRiaTV6Wlc1a1pYSXBMQ0JGVWxKZlFrRk9Ua1ZFS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyRnNiSE4xWWlCcGMwSmhibTVsWkFvZ0lDQWdZbm9nZFc1bWIyeHNiM2RmWVdaMFpYSmZZWE56WlhKMFFETUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0lrVlNVanBDUVU1RUlnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT2tKQlRrUUtDblZ1Wm05c2JHOTNYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTNOQW9nSUNBZ0x5OGdZMjl1YzNRZ1ptOXNiRzkzYzB0bGVTQTlJSFJvYVhNdVpteDNLR0ZrWkhKbGMzTXNJRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQmtkWEFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOaGJHeHpkV0lnWm14M0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklHWnZiR3h2ZDNNZ1BTQkNiM2hOWVhBOFJtOXNiRzkzYzB0bGVTd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nUVd0cGRHRlRiMk5wWVd4Q2IzaFFjbVZtYVhoR2IyeHNiM2R6SUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKbUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakUzTmdvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtIUm9hWE11Wm05c2JHOTNjeWhtYjJ4c2IzZHpTMlY1S1M1bGVHbHpkSE1zSUVWU1VsOU9UMVJmUms5TVRFOVhTVTVIS1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dkVzVtYjJ4c2IzZGZZV1owWlhKZllYTnpaWEowUURVS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09rNUdURmNpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZUa1pNVndvS2RXNW1iMnhzYjNkZllXWjBaWEpmWVhOelpYSjBRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRjNENpQWdJQ0F2THlCamIyNXpkQ0I3SUdadmJHeHZkMlZ5UTI5MWJuUXNJR1p2Ykd4dmQyVnlTVzVrWlhnZ2ZTQTlJSFJvYVhNdVoyVjBUV1YwWVNoaFpHUnlaWE56S1FvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JqWVd4c2MzVmlJR2RsZEUxbGRHRUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EwTVFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdNek1LSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRnd0NpQWdJQ0F2THlCMGFHbHpMblZ3WkdGMFpVWnZiR3h2ZDJWeVRXVjBZU2hoWkdSeVpYTnpMQ0JtYjJ4c2IzZGxja2x1WkdWNExDQm1iMnhzYjNkbGNrTnZkVzUwSUMwZ01Ta0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmpZV3hzYzNWaUlIVndaR0YwWlVadmJHeHZkMlZ5VFdWMFlRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTRNUW9nSUNBZ0x5OGdkR2hwY3k1bWIyeHNiM2R6S0dadmJHeHZkM05MWlhrcExtUmxiR1YwWlNncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVGd6TFRFNE9Bb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUIwYUdsekxtMWljaWhDZVhSbGN5Z25KeWtzSUNjbkxDQkNlWFJsY3lnbkp5a3BMbVp2Ykd4dmQzTUtJQ0FnSUM4dklDQWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVGcxQ2lBZ0lDQXZMeUJ5WldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94T0RZS0lDQWdJQzh2SUdGdGIzVnVkRG9nZEdocGN5NXRZbklvUW5sMFpYTW9KeWNwTENBbkp5d2dRbmwwWlhNb0p5Y3BLUzVtYjJ4c2IzZHpDaUFnSUNCaWVYUmxZMTh5SUM4dklDSWlDaUFnSUNCa2RYQnVJRElLSUNBZ0lHTmhiR3h6ZFdJZ2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPanBDWVhObFUyOWphV0ZzTG0xaWNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTRNeTB4T0RjS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dkR2hwY3k1dFluSW9RbmwwWlhNb0p5Y3BMQ0FuSnl3Z1FubDBaWE1vSnljcEtTNW1iMnhzYjNkekNpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TVRnekxURTRPQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCMGFHbHpMbTFpY2loQ2VYUmxjeWduSnlrc0lDY25MQ0JDZVhSbGN5Z25KeWtwTG1admJHeHZkM01LSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pFM01Rb2dJQ0FnTHk4Z2RXNW1iMnhzYjNjb1lXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem82UVd0cGRHRlRiMk5wWVd4SGNtRndhQzVwYzBKc2IyTnJaV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGMwSnNiMk5yWldRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1Ua3hDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNVGt6Q2lBZ0lDQXZMeUJqYjI1emRDQmliRzlqYTNOTFpYa2dQU0IwYUdsekxtSnNheWgxYzJWeUxDQmliRzlqYTJWa0tRb2dJQ0FnWTJGc2JITjFZaUJpYkdzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z1lteHZZMnR6SUQwZ1FtOTRUV0Z3UEVKc2IyTnJUR2x6ZEV0bGVTd2dZbmwwWlhNOE1ENCtLSHNnYTJWNVVISmxabWw0T2lCQmEybDBZVk52WTJsaGJFSnZlRkJ5WldacGVFSnNiMk5yY3lCOUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlpSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakU1TkFvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVlteHZZMnR6S0dKc2IyTnJjMHRsZVNrdVpYaHBjM1J6Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3hPVEVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzZRV3RwZEdGVGIyTnBZV3hIY21Gd2FDNXBjMFp2Ykd4dmQybHVaMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21selJtOXNiRzkzYVc1bk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qRTVOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakU1T1FvZ0lDQWdMeThnWTI5dWMzUWdabTlzYkc5M2MwdGxlU0E5SUhSb2FYTXVabXgzS0hWelpYSXNJR1p2Ykd4dmQyVnlLUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCbWJIY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdabTlzYkc5M2N5QTlJRUp2ZUUxaGNEeEdiMnhzYjNkelMyVjVMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lCQmEybDBZVk52WTJsaGJFSnZlRkJ5WldacGVFWnZiR3h2ZDNNZ2ZTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltWWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem95TURBS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtWnZiR3h2ZDNNb1ptOXNiRzkzYzB0bGVTa3VaWGhwYzNSekNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem94T1RjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem82UVd0cGRHRlRiMk5wWVd4SGNtRndhQzVuWlhSR2IyeHNiM2RKYm1SbGVGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEVadmJHeHZkMGx1WkdWNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qSXdNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPakl3TlFvZ0lDQWdMeThnWTI5dWMzUWdabTlzYkc5M2MwdGxlU0E5SUhSb2FYTXVabXgzS0hWelpYSXNJR1p2Ykd4dmQyVnlLUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCbWJIY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdabTlzYkc5M2N5QTlJRUp2ZUUxaGNEeEdiMnhzYjNkelMyVjVMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lCQmEybDBZVk52WTJsaGJFSnZlRkJ5WldacGVFWnZiR3h2ZDNNZ2ZTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltWWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem95TURZS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtWnZiR3h2ZDNNb1ptOXNiRzkzYzB0bGVTa3VkbUZzZFdVS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1qQXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02T2tKaGMyVlRiMk5wWVd3dWJXSnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYldKeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPakUxQ2lBZ0lDQXZMeUJ0WW5Jb2NtVm1PaUJpZVhSbGN5d2djbVZtVkhsd1pVNWhiV1U2SUhOMGNtbHVaeXdnY21WbVZIbHdaVk5qYUdWdFlUb2dZbmwwWlhNcE9pQkJhMmwwWVZOdlkybGhiRTFDVWtSaGRHRWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZMkZzYkhOMVlpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02T2tKaGMyVlRiMk5wWVd3dWJXSnlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPanBDWVhObFUyOWphV0ZzTG5CaGVWZGhiR3hOWW5KYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdZWGxYWVd4c1RXSnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pNMENpQWdJQ0F2THlCd1lYbFhZV3hzVFdKeUtIQmhlWGRoYkd3NklGWnBaWGRRWVhsWFlXeHNWbUZzZFdVcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElEQWdiMllnS0Noc1pXNHJLSFZwYm5RNExIVnBiblEyTkN4MWFXNTBOalFwVzEwcExDaHNaVzRyS0hWcGJuUTRMSFZwYm5RMk5DeDFhVzUwTmpRcFcxMHBLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNVGNLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdLd29nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXhJRzltSUNnb2JHVnVLeWgxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwS1Z0ZEtTd29iR1Z1S3loMWFXNTBPQ3gxYVc1ME5qUXNkV2x1ZERZMEtWdGRLU2tLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaR2xuSURVS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVGNLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUNzS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzkwZVhCbGN5NTBjem82Vm1sbGQxQmhlVmRoYkd4V1lXeDFaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pNM0NpQWdJQ0F2THlCUVlYbFhZV3hzVUdGNVQzQjBhVzl1VTJsNlpTQXFJQ2h3WVhsM1lXeHNMbUZuWlc1MFVHRjVTVzVtYnk1c1pXNW5kR2dnS3lCd1lYbDNZV3hzTG5WelpYSlFZWGxKYm1adkxteGxibWQwYUNrS0lDQWdJR052ZG1WeUlETUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZNell0TXpnS0lDQWdJQzh2SUVKdmVFTnZjM1JRWlhKQ2VYUmxJQ29nS0FvZ0lDQWdMeThnSUNCUVlYbFhZV3hzVUdGNVQzQjBhVzl1VTJsNlpTQXFJQ2h3WVhsM1lXeHNMbUZuWlc1MFVHRjVTVzVtYnk1c1pXNW5kR2dnS3lCd1lYbDNZV3hzTG5WelpYSlFZWGxKYm1adkxteGxibWQwYUNrS0lDQWdJQzh2SUNrS0lDQWdJSEIxYzJocGJuUWdOamd3TUFvZ0lDQWdLZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pNMUNpQWdJQ0F2THlCeVpYUjFjbTRnVFdsdVVHRjVWMkZzYkUxQ1VpQXJJQ2dLSUNBZ0lIQjFjMmhwYm5RZ05USXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pNMUxUTTVDaUFnSUNBdkx5QnlaWFIxY200Z1RXbHVVR0Y1VjJGc2JFMUNVaUFySUNnS0lDQWdJQzh2SUNBZ1FtOTRRMjl6ZEZCbGNrSjVkR1VnS2lBb0NpQWdJQ0F2THlBZ0lDQWdVR0Y1VjJGc2JGQmhlVTl3ZEdsdmJsTnBlbVVnS2lBb2NHRjVkMkZzYkM1aFoyVnVkRkJoZVVsdVptOHViR1Z1WjNSb0lDc2djR0Y1ZDJGc2JDNTFjMlZ5VUdGNVNXNW1ieTVzWlc1bmRHZ3BDaUFnSUNBdkx5QWdJQ2tLSUNBZ0lDOHZJQ2tLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem96TkFvZ0lDQWdMeThnY0dGNVYyRnNiRTFpY2lod1lYbDNZV3hzT2lCV2FXVjNVR0Y1VjJGc2JGWmhiSFZsS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk9rSmhjMlZUYjJOcFlXd3VZMmhsWTJ0VWFYQk5ZbkpTWlhGMWFYSmxiV1Z1ZEhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGphR1ZqYTFScGNFMWljbEpsY1hWcGNtVnRaVzUwY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6bzFOUW9nSUNBZ0x5OGdZMmhsWTJ0VWFYQk5ZbkpTWlhGMWFYSmxiV1Z1ZEhNb1lXdHBkR0ZFUVU4NklFRndjR3hwWTJGMGFXOXVMQ0JqY21WaGRHOXlPaUJCWTJOdmRXNTBMQ0IzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1S1RvZ2RHbHdUVUpTU1c1bWJ5QjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPams0Q2lBZ0lDQXZMeUJqYjI1emRDQmhhMmwwWVVGemMyVjBjMEo1ZEdWeklEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb1lXdHBkR0ZFUVU4c0lFSjVkR1Z6S0VGcmFYUmhSRUZQUjJ4dlltRnNVM1JoZEdWTFpYbHpRV3RwZEdGQmMzTmxkSE1wS1Zzd1hRb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKaGEybDBZVjloYzNObGRITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk5UWUtJQ0FnSUM4dklHTnZibk4wSUdGcmRHRWdQU0JCYzNObGRDaG5aWFJCYTJsMFlVRnpjMlYwY3loaGEybDBZVVJCVHlrdVlXdDBZU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pVNENpQWdJQ0F2THlCcFppQW9JV055WldGMGIzSXVhWE5QY0hSbFpFbHVLR0ZyZEdFcElDWW1JSGRoYkd4bGRDNXBaQ0FoUFQwZ01Da2dld29nSUNBZ1lYTnpaWFJmYUc5c1pHbHVaMTluWlhRZ1FYTnpaWFJDWVd4aGJtTmxDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJqYUdWamExUnBjRTFpY2xKbGNYVnBjbVZ0Wlc1MGMxOWhablJsY2w5cFpsOWxiSE5sUURZS0lDQWdJR1IxY0FvZ0lDQWdZbm9nWTJobFkydFVhWEJOWW5KU1pYRjFhWEpsYldWdWRITmZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZORE10TlRJS0lDQWdJQzh2SUhKbGRIVnliaUJoWW1sRFlXeHNQSFI1Y0dWdlppQkJZbk4wY21GamRHVmtRV05qYjNWdWRDNXdjbTkwYjNSNWNHVXVZWEpqTlRoZlkyRnVRMkZzYkQ0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkN3S0lDQWdJQzh2SUNBZ1lYSm5jem9nV3dvZ0lDQWdMeThnSUNBZ0lHZGxkRkJzZFdkcGJrRndjRXhwYzNRb1lXdHBkR0ZFUVU4cExtOXdkR2x1TEFvZ0lDQWdMeThnSUNBZ0lFTmhiR3hsY2xSNWNHVkhiRzlpWVd3c0NpQWdJQ0F2THlBZ0lDQWdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUNjbkxBb2dJQ0FnTHk4Z0lDQWdJRzFsZEdodlpGTmxiR1ZqZEc5eVBIUjVjR1Z2WmlCUGNIUkpibEJzZFdkcGJpNXdjbTkwYjNSNWNHVXViM0IwU1c0K0tDa0tJQ0FnSUM4dklDQWdYUW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZOVFFLSUNBZ0lDOHZJR052Ym5OMElGdHdiSFZuYVc1QmNIQk1hWE4wUW5sMFpYTmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0UW5sMFpYTW9ZV3RwZEdGRVFVOHNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6VUd4MVoybHVRWEJ3VEdsemRDa3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1lubDBaV01nT1NBdkx5QWljR0ZzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPalEyQ2lBZ0lDQXZMeUJuWlhSUWJIVm5hVzVCY0hCTWFYTjBLR0ZyYVhSaFJFRlBLUzV2Y0hScGJpd0tJQ0FnSUdWNGRISmhZM1FnTUNBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZORGNLSUNBZ0lDOHZJRU5oYkd4bGNsUjVjR1ZIYkc5aVlXd3NDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPalE0Q2lBZ0lDQXZMeUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUdScFp5QXpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pvME15MDFNZ29nSUNBZ0x5OGdjbVYwZFhKdUlHRmlhVU5oYkd3OGRIbHdaVzltSUVGaWMzUnlZV04wWldSQlkyTnZkVzUwTG5CeWIzUnZkSGx3WlM1aGNtTTFPRjlqWVc1RFlXeHNQaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJDaUFnSUNBdkx5QWdJQ0FnWjJWMFVHeDFaMmx1UVhCd1RHbHpkQ2hoYTJsMFlVUkJUeWt1YjNCMGFXNHNDaUFnSUNBdkx5QWdJQ0FnUTJGc2JHVnlWSGx3WlVkc2IySmhiQ3dLSUNBZ0lDOHZJQ0FnSUNCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdKeWNzQ2lBZ0lDQXZMeUFnSUNBZ2JXVjBhRzlrVTJWc1pXTjBiM0k4ZEhsd1pXOW1JRTl3ZEVsdVVHeDFaMmx1TG5CeWIzUnZkSGx3WlM1dmNIUkpiajRvS1FvZ0lDQWdMeThnSUNCZENpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZak0yTWpNMFlUVWdMeThnYldWMGFHOWtJQ0poY21NMU9GOWpZVzVEWVd4c0tIVnBiblEyTkN4MWFXNTBOalFzWVdSa2NtVnpjeXh6ZEhKcGJtY3NZbmwwWlZzMFhTbGliMjlzSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPalE1Q2lBZ0lDQXZMeUFuSnl3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk5UQUtJQ0FnSUM4dklHMWxkR2h2WkZObGJHVmpkRzl5UEhSNWNHVnZaaUJQY0hSSmJsQnNkV2RwYmk1d2NtOTBiM1I1Y0dVdWIzQjBTVzQrS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURZNE16VmxNMkpqSUM4dklHMWxkR2h2WkNBaWIzQjBTVzRvZFdsdWREWTBMR0p2YjJ3c2RXbHVkRFkwVzEwc2NHRjVLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pRekxUVXlDaUFnSUNBdkx5QnlaWFIxY200Z1lXSnBRMkZzYkR4MGVYQmxiMllnUVdKemRISmhZM1JsWkVGalkyOTFiblF1Y0hKdmRHOTBlWEJsTG1GeVl6VTRYMk5oYmtOaGJHdytLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGc0tJQ0FnSUM4dklDQWdJQ0JuWlhSUWJIVm5hVzVCY0hCTWFYTjBLR0ZyYVhSaFJFRlBLUzV2Y0hScGJpd0tJQ0FnSUM4dklDQWdJQ0JEWVd4c1pYSlVlWEJsUjJ4dlltRnNMQW9nSUNBZ0x5OGdJQ0FnSUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQW5KeXdLSUNBZ0lDOHZJQ0FnSUNCdFpYUm9iMlJUWld4bFkzUnZjangwZVhCbGIyWWdUM0IwU1c1UWJIVm5hVzR1Y0hKdmRHOTBlWEJsTG05d2RFbHVQaWdwQ2lBZ0lDQXZMeUFnSUYwS0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKNWRHVnpJR2hoY3lCMllXeHBaQ0J3Y21WbWFYZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZbTl2YkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qWXdDaUFnSUNBdkx5QnBaaUFvWTJGdVEyRnNiRUZ5WXpVNFQzQjBTVzRwSUhzS0lDQWdJR0o2SUdOb1pXTnJWR2x3VFdKeVVtVnhkV2x5WlcxbGJuUnpYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPall6Q2lBZ0lDQXZMeUJoY21NMU9Eb2dSMnh2WW1Gc0xtRnpjMlYwVDNCMFNXNU5hVzVDWVd4aGJtTmxDaUFnSUNCbmJHOWlZV3dnUVhOelpYUlBjSFJKYmsxcGJrSmhiR0Z1WTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6bzJNUzAyTkFvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnZEhsd1pUb2dWR2x3VTJWdVpGUjVjR1ZCVWtNMU9Dd0tJQ0FnSUM4dklDQWdZWEpqTlRnNklFZHNiMkpoYkM1aGMzTmxkRTl3ZEVsdVRXbHVRbUZzWVc1alpRb2dJQ0FnTHk4Z2ZRb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPall5Q2lBZ0lDQXZMeUIwZVhCbE9pQlVhWEJUWlc1a1ZIbHdaVUZTUXpVNExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem8yTVMwMk5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhzS0lDQWdJQzh2SUNBZ2RIbHdaVG9nVkdsd1UyVnVaRlI1Y0dWQlVrTTFPQ3dLSUNBZ0lDOHZJQ0FnWVhKak5UZzZJRWRzYjJKaGJDNWhjM05sZEU5d2RFbHVUV2x1UW1Gc1lXNWpaUW9nSUNBZ0x5OGdmUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2dwamFHVmphMVJwY0UxaWNsSmxjWFZwY21WdFpXNTBjMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem82UW1GelpWTnZZMmxoYkM1amFHVmphMVJwY0UxaWNsSmxjWFZwY21WdFpXNTBjMEEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qVTFDaUFnSUNBdkx5QmphR1ZqYTFScGNFMWljbEpsY1hWcGNtVnRaVzUwY3loaGEybDBZVVJCVHpvZ1FYQndiR2xqWVhScGIyNHNJR055WldGMGIzSTZJRUZqWTI5MWJuUXNJSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRwT2lCMGFYQk5RbEpKYm1adklIc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbU5vWldOclZHbHdUV0p5VW1WeGRXbHlaVzFsYm5SelgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZZbUZ6WlM1MGN6bzJPQzAzTVFvZ0lDQWdMeThnY21WMGRYSnVJSHNLSUNBZ0lDOHZJQ0FnZEhsd1pUb2dWR2x3VTJWdVpGUjVjR1ZFYVhKbFkzUXNDaUFnSUNBdkx5QWdJR0Z5WXpVNE9pQXdDaUFnSUNBdkx5QjlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dZVEF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem8xTlFvZ0lDQWdMeThnWTJobFkydFVhWEJOWW5KU1pYRjFhWEpsYldWdWRITW9ZV3RwZEdGRVFVODZJRUZ3Y0d4cFkyRjBhVzl1TENCamNtVmhkRzl5T2lCQlkyTnZkVzUwTENCM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUtUb2dkR2x3VFVKU1NXNW1ieUI3Q2lBZ0lDQmlJR05vWldOclZHbHdUV0p5VW1WeGRXbHlaVzFsYm5SelgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qcENZWE5sVTI5amFXRnNMbU5vWldOclZHbHdUV0p5VW1WeGRXbHlaVzFsYm5SelFEY0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvNlZYQm5jbUZrWldGaWJHVkJhMmwwWVVKaGMyVkRiMjUwY21GamRDNTFjR1JoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDFjR1JoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvME5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5ZFZjR1JoZEdWQmNIQnNhV05oZEdsdmJpZGRJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk5EZ0tJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1kbGRFRnJhWFJoUkVGUFYyRnNiR1YwS0NrdVlXUmtjbVZ6Y3l3Z1JWSlNYMDVQVkY5QlMwbFVRVjlFUVU4cENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem96TUFvZ0lDQWdMeThnWTI5dWMzUWdXM2RoYkd4bGRFbEVYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUZWcGJuUTJOQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsTENCQ2VYUmxjeWhCYTJsMFlVUkJUMGRzYjJKaGJGTjBZWFJsUzJWNWMxZGhiR3hsZENrcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TWpjS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3pNQW9nSUNBZ0x5OGdZMjl1YzNRZ1czZGhiR3hsZEVsRVhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzFkaGJHeGxkQ2twQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbmRoYkd4bGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTlpWVhObExuUnpPalE0Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NW5aWFJCYTJsMFlVUkJUMWRoYkd4bGRDZ3BMbUZrWkhKbGMzTXNJRVZTVWw5T1QxUmZRVXRKVkVGZlJFRlBLUW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1FXUmtjbVZ6Y3dvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdKdWVpQjFjR1JoZEdWZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0pGVWxJNlRrUkJUeUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcE9SRUZQQ2dwMWNHUmhkR1ZmWVdaMFpYSmZZWE56WlhKMFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6bzBPUW9nSUNBZ0x5OGdZMjl1YzNRZ2RYQmtZWFJsVUd4MVoybHVJRDBnWjJWMFVHeDFaMmx1UVhCd1RHbHpkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsS1M1MWNHUmhkR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3lOd29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5aVlYTmxMblJ6T2pRNUNpQWdJQ0F2THlCamIyNXpkQ0IxY0dSaGRHVlFiSFZuYVc0Z1BTQm5aWFJRYkhWbmFXNUJjSEJNYVhOMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXBMblZ3WkdGMFpRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TlRRS0lDQWdJQzh2SUdOdmJuTjBJRnR3YkhWbmFXNUJjSEJNYVhOMFFubDBaWE5kSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFFubDBaWE1vWVd0cGRHRkVRVThzSUVKNWRHVnpLRUZyYVhSaFJFRlBSMnh2WW1Gc1UzUmhkR1ZMWlhselVHeDFaMmx1UVhCd1RHbHpkQ2twQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0p3WVd3aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6bzBPUW9nSUNBZ0x5OGdZMjl1YzNRZ2RYQmtZWFJsVUd4MVoybHVJRDBnWjJWMFVHeDFaMmx1UVhCd1RHbHpkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsS1M1MWNHUmhkR1VLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6bzFNQW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0Vkc2IySmhiQzVqWVd4c1pYSkJjSEJzYVdOaGRHbHZia2xrSUQwOVBTQjFjR1JoZEdWUWJIVm5hVzRzSUVWU1VsOUpUbFpCVEVsRVgxVlFSMUpCUkVVcENpQWdJQ0JuYkc5aVlXd2dRMkZzYkdWeVFYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1BUMEtJQ0FnSUdKdWVpQjFjR1JoZEdWZllXWjBaWEpmWVhOelpYSjBRRFVLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT2tsVlVFY2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlNWVlFSd29LZFhCa1lYUmxYMkZtZEdWeVgyRnpjMlZ5ZEVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk1qVUtJQ0FnSUM4dklIWmxjbk5wYjI0Z1BTQkhiRzlpWVd4VGRHRjBaVHh6ZEhKcGJtYytLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVZabGNuTnBiMjRnZlNrS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5abGNuTnBiMjRpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem8xTVFvZ0lDQWdMeThnZEdocGN5NTJaWEp6YVc5dUxuWmhiSFZsSUQwZ2JtVjNWbVZ5YzJsdmJnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6bzBOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dXeWRWY0dSaGRHVkJjSEJzYVdOaGRHbHZiaWRkSUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02T2tGcmFYUmhRbUZ6WlVOdmJuUnlZV04wTG5Wd1pHRjBaVUZyYVhSaFJFRlBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxRV3RwZEdGRVFVODZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3pOZ29nSUNBZ0x5OGdkWEJrWVhSbFFXdHBkR0ZFUVU4b1lXdHBkR0ZFUVU4NklFRndjR3hwWTJGMGFXOXVLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNemNLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxtZGxkRUZyYVhSaFJFRlBWMkZzYkdWMEtDa3VZV1JrY21WemN5d2dSVkpTWDA1UFZGOUJTMGxVUVY5RVFVOHBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvek1Bb2dJQ0FnTHk4Z1kyOXVjM1FnVzNkaGJHeGxkRWxFWFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVGVnBiblEyTkNoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMWRoYkd4bGRDa3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk1qY0tJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem96TUFvZ0lDQWdMeThnWTI5dWMzUWdXM2RoYkd4bGRFbEVYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUZWcGJuUTJOQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsTENCQ2VYUmxjeWhCYTJsMFlVUkJUMGRzYjJKaGJGTjBZWFJsUzJWNWMxZGhiR3hsZENrcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW5kaGJHeGxkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5aVlYTmxMblJ6T2pNM0NpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVuWlhSQmEybDBZVVJCVDFkaGJHeGxkQ2dwTG1Ga1pISmxjM01zSUVWU1VsOU9UMVJmUVV0SlZFRmZSRUZQS1FvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndRV1JrY21WemN3b2dJQ0FnWVhOelpYSjBJQzh2SUdGd2NHeHBZMkYwYVc5dUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUIxY0dSaGRHVkJhMmwwWVVSQlQxOWhablJsY2w5aGMzTmxjblJBTXdvZ0lDQWdZbmwwWldNZ01URWdMeThnSWtWU1VqcE9SRUZQSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPazVFUVU4S0NuVndaR0YwWlVGcmFYUmhSRUZQWDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNamNLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvek9Bb2dJQ0FnTHk4Z2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTQTlJR0ZyYVhSaFJFRlBDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTlpWVhObExuUnpPak0yQ2lBZ0lDQXZMeUIxY0dSaGRHVkJhMmwwWVVSQlR5aGhhMmwwWVVSQlR6b2dRWEJ3YkdsallYUnBiMjRwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZPa0ZyYVhSaFUyOWphV0ZzUjNKaGNHZ3VhWE5DWVc1dVpXUW9ZV05qYjNWdWREb2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0thWE5DWVc1dVpXUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJSEJ5YVhaaGRHVWdhWE5DWVc1dVpXUW9ZV05qYjNWdWREb2dRV05qYjNWdWRDazZJR0p2YjJ4bFlXNGdld29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk16SUtJQ0FnSUM4dklHTnZibk4wSUhzZ2JXOWtaWEpoZEdsdmJpQjlJRDBnWjJWMFFXdHBkR0ZUYjJOcFlXeEJjSEJNYVhOMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk1qY0tJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUdOdmJuTjBJSHNnYlc5a1pYSmhkR2x2YmlCOUlEMGdaMlYwUVd0cGRHRlRiMk5wWVd4QmNIQk1hWE4wS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8wT1FvZ0lDQWdMeThnWTI5dWMzUWdXMkZ3Y0V4cGMzUkNlWFJsYzEwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3loaGEybDBZVVJCVHl3Z1FubDBaWE1vUVd0cGRHRkVRVTlIYkc5aVlXeFRkR0YwWlV0bGVYTkJhMmwwWVZOdlkybGhiRUZ3Y0V4cGMzUXBLUW9nSUNBZ1lubDBaV01nTnlBdkx5QWljMkZzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QmpiMjV6ZENCN0lHMXZaR1Z5WVhScGIyNGdmU0E5SUdkbGRFRnJhWFJoVTI5amFXRnNRWEJ3VEdsemRDaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxLUW9nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6b3pNeTB6TmdvZ0lDQWdMeThnY21WMGRYSnVJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlFRnJhWFJoVTI5amFXRnNUVzlrWlhKaGRHbHZiaTV3Y205MGIzUjVjR1V1YVhOQ1lXNXVaV1ErS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUcxdlpHVnlZWFJwYjI0c0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0aFkyTnZkVzUwWFFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9EUXlOamxqTnpnZ0x5OGdiV1YwYUc5a0lDSnBjMEpoYm01bFpDaGhaR1J5WlhOektXSnZiMndpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2NIVnphR2x1ZENBMklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQ2VYUmxjeUJvWVhNZ2RtRnNhV1FnY0hKbFptbDRDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0p2YjJ3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvNlFXdHBkR0ZUYjJOcFlXeEhjbUZ3YUM1aWJHc29kWE5sY2tGa1pISmxjM002SUdKNWRHVnpMQ0JpYkc5amEyVmtRV1JrY21WemN6b2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGliR3M2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUhCeWFYWmhkR1VnWW14cktIVnpaWEpCWkdSeVpYTnpPaUJCWTJOdmRXNTBMQ0JpYkc5amEyVmtRV1JrY21WemN6b2dRV05qYjNWdWRDazZJRUpzYjJOclRHbHpkRXRsZVNCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnWTI5dWMzUWdkWE5sY2lBOUlIVnpaWEpCWkdSeVpYTnpMbUo1ZEdWekxuTnNhV05sS0RBc0lERTJLUzUwYjBacGVHVmtLSHNnYkdWdVozUm9PaUF4TmlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J6ZFdKemRISnBibWNnTUNBeE5nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RHVnVaM1JvSUcxMWMzUWdZbVVnTVRZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z1kyOXVjM1FnWW14dlkydGxaQ0E5SUdKc2IyTnJaV1JCWkdSeVpYTnpMbUo1ZEdWekxuTnNhV05sS0RBc0lERTJLUzUwYjBacGVHVmtLSHNnYkdWdVozUm9PaUF4TmlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6ZFdKemRISnBibWNnTUNBeE5nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RHVnVaM1JvSUcxMWMzUWdZbVVnTVRZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvME13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhzZ2RYTmxjaXdnWW14dlkydGxaQ0I5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvNlFXdHBkR0ZUYjJOcFlXeEhjbUZ3YUM1bWJIY29kWE5sY2pvZ1lubDBaWE1zSUdadmJHeHZkMlZ5T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21ac2R6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdjSEpwZG1GMFpTQm1iSGNvZFhObGNqb2dRV05qYjNWdWRDd2dabTlzYkc5M1pYSTZJRUZqWTI5MWJuUXBPaUJHYjJ4c2IzZHpTMlY1SUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUJqYjI1emRDQjFjMlZ5UW5sMFpYTWdQU0IxYzJWeUxtSjVkR1Z6TG5Oc2FXTmxLREFzSURFMktTNTBiMFpwZUdWa0tIc2diR1Z1WjNSb09pQXhOaUI5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnpkV0p6ZEhKcGJtY2dNQ0F4TmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVEdWdVozUm9JRzExYzNRZ1ltVWdNVFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8wT1FvZ0lDQWdMeThnWTI5dWMzUWdabTlzYkc5M1pYSkNlWFJsY3lBOUlHWnZiR3h2ZDJWeUxtSjVkR1Z6TG5Oc2FXTmxLREFzSURFMktTNTBiMFpwZUdWa0tIc2diR1Z1WjNSb09pQXhOaUI5S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnpkV0p6ZEhKcGJtY2dNQ0F4TmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVEdWdVozUm9JRzExYzNRZ1ltVWdNVFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnY21WMGRYSnVJSHNnZFhObGNqb2dkWE5sY2tKNWRHVnpMQ0JtYjJ4c2IzZGxjam9nWm05c2JHOTNaWEpDZVhSbGN5QjlDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem82UVd0cGRHRlRiMk5wWVd4SGNtRndhQzVuWlhSTlpYUmhLR0ZrWkhKbGMzTTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0taMlYwVFdWMFlUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdjSEpwZG1GMFpTQm5aWFJOWlhSaEtHRmtaSEpsYzNNNklFRmpZMjkxYm5RcE9pQk5aWFJoVm1Gc2RXVWdld29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk5UUUtJQ0FnSUM4dklHTnZibk4wSUhzZ2MyOWphV0ZzSUgwZ1BTQm5aWFJCYTJsMFlWTnZZMmxoYkVGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem95TndvZ0lDQWdMeThnWVd0cGRHRkVRVThnUFNCSGJHOWlZV3hUZEdGMFpUeEJjSEJzYVdOaGRHbHZiajRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVFXdHBkR0ZFUVU4Z2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRnJhWFJoWDJSaGJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzFOQW9nSUNBZ0x5OGdZMjl1YzNRZ2V5QnpiMk5wWVd3Z2ZTQTlJR2RsZEVGcmFYUmhVMjlqYVdGc1FYQndUR2x6ZENoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbEtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TkRrS0lDQWdJQzh2SUdOdmJuTjBJRnRoY0hCTWFYTjBRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb1lXdHBkR0ZFUVU4c0lFSjVkR1Z6S0VGcmFYUmhSRUZQUjJ4dlltRnNVM1JoZEdWTFpYbHpRV3RwZEdGVGIyTnBZV3hCY0hCTWFYTjBLU2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbk5oYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzFOQW9nSUNBZ0x5OGdZMjl1YzNRZ2V5QnpiMk5wWVd3Z2ZTQTlJR2RsZEVGcmFYUmhVMjlqYVdGc1FYQndUR2x6ZENoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk5UVXROVGdLSUNBZ0lDOHZJSEpsZEhWeWJpQmhZbWxEWVd4c1BIUjVjR1Z2WmlCQmEybDBZVk52WTJsaGJDNXdjbTkwYjNSNWNHVXVaMlYwVFdWMFlUNG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2djMjlqYVdGc0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYllXUmtjbVZ6YzEwS0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEY3pPV1ZoTnpCaUlDOHZJRzFsZEdodlpDQWlaMlYwVFdWMFlTaGhaR1J5WlhOektTaGliMjlzTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0p2YjJ3c2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUW5sMFpYTWdhR0Z6SUhaaGJHbGtJSEJ5WldacGVBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOelFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2ZEhsd1pYTXVkSE02T2sxbGRHRldZV3gxWlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pwQmEybDBZVk52WTJsaGJFZHlZWEJvTG5Wd1pHRjBaVVp2Ykd4dmQyVnlUV1YwWVNoaFkyTnZkVzUwT2lCaWVYUmxjeXdnYm1WM1JtOXNiRzkzWlhKSmJtUmxlRG9nZFdsdWREWTBMQ0J1WlhkR2IyeHNiM2RsY2tOdmRXNTBPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDblZ3WkdGMFpVWnZiR3h2ZDJWeVRXVjBZVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlozSmhjR2d1WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnY0hKcGRtRjBaU0IxY0dSaGRHVkdiMnhzYjNkbGNrMWxkR0VvWVdOamIzVnVkRG9nUVdOamIzVnVkQ3dnYm1WM1JtOXNiRzkzWlhKSmJtUmxlRG9nZFdsdWREWTBMQ0J1WlhkR2IyeHNiM2RsY2tOdmRXNTBPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRE1nTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pZeUNpQWdJQ0F2THlCamIyNXpkQ0I3SUhOdlkybGhiQ0I5SUQwZ1oyVjBRV3RwZEdGVGIyTnBZV3hCY0hCTWFYTjBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNamNLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklHTnZibk4wSUhzZ2MyOWphV0ZzSUgwZ1BTQm5aWFJCYTJsMFlWTnZZMmxoYkVGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalE1Q2lBZ0lDQXZMeUJqYjI1emRDQmJZWEJ3VEdsemRFSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0dGcmFYUmhSRUZQTENCQ2VYUmxjeWhCYTJsMFlVUkJUMGRzYjJKaGJGTjBZWFJsUzJWNWMwRnJhWFJoVTI5amFXRnNRWEJ3VEdsemRDa3BDaUFnSUNCaWVYUmxZeUEzSUM4dklDSnpZV3dpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk5qSUtJQ0FnSUM4dklHTnZibk4wSUhzZ2MyOWphV0ZzSUgwZ1BTQm5aWFJCYTJsMFlWTnZZMmxoYkVGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pZekxUWTJDaUFnSUNBdkx5QmhZbWxEWVd4c1BIUjVjR1Z2WmlCQmEybDBZVk52WTJsaGJDNXdjbTkwYjNSNWNHVXVkWEJrWVhSbFJtOXNiRzkzWlhKTlpYUmhQaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJ6YjJOcFlXd3NDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdGhZMk52ZFc1MExDQnVaWGRHYjJ4c2IzZGxja2x1WkdWNExDQnVaWGRHYjJ4c2IzZGxja052ZFc1MFhRb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pvMk5Rb2dJQ0FnTHk4Z1lYSm5jem9nVzJGalkyOTFiblFzSUc1bGQwWnZiR3h2ZDJWeVNXNWtaWGdzSUc1bGQwWnZiR3h2ZDJWeVEyOTFiblJkQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WjNKaGNHZ3VZV3huYnk1MGN6bzJNeTAyTmdvZ0lDQWdMeThnWVdKcFEyRnNiRHgwZVhCbGIyWWdRV3RwZEdGVGIyTnBZV3d1Y0hKdmRHOTBlWEJsTG5Wd1pHRjBaVVp2Ykd4dmQyVnlUV1YwWVQ0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2MyOWphV0ZzTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiWVdOamIzVnVkQ3dnYm1WM1JtOXNiRzkzWlhKSmJtUmxlQ3dnYm1WM1JtOXNiRzkzWlhKRGIzVnVkRjBLSUNBZ0lDOHZJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd6TXpBMllqTXlZU0F2THlCdFpYUm9iMlFnSW5Wd1pHRjBaVVp2Ykd4dmQyVnlUV1YwWVNoaFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZPa0ZyYVhSaFUyOWphV0ZzUjNKaGNHZ3VZM0psWVhSbFJtOXNiRzkzS0hObGJtUmxjam9nWW5sMFpYTXNJR0ZrWkhKbGMzTTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGpjbVZoZEdWR2IyeHNiM2M2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TmprS0lDQWdJQzh2SUhCeWFYWmhkR1VnWTNKbFlYUmxSbTlzYkc5M0tITmxibVJsY2pvZ1FXTmpiM1Z1ZEN3Z1lXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z01pQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvSVhSb2FYTXVhWE5DWVc1dVpXUW9jMlZ1WkdWeUtTd2dSVkpTWDBKQlRrNUZSQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyRnNiSE4xWWlCcGMwSmhibTVsWkFvZ0lDQWdZbm9nWTNKbFlYUmxSbTlzYkc5M1gyRm1kR1Z5WDJGemMyVnlkRUF5Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pGVWxJNlFrRk9SQ0lLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcENRVTVFQ2dwamNtVmhkR1ZHYjJ4c2IzZGZZV1owWlhKZllYTnpaWEowUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk1Ua3pDaUFnSUNBdkx5QmpiMjV6ZENCaWJHOWphM05MWlhrZ1BTQjBhR2x6TG1Kc2F5aDFjMlZ5TENCaWJHOWphMlZrS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTmhiR3h6ZFdJZ1lteHJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJkeVlYQm9MbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR0pzYjJOcmN5QTlJRUp2ZUUxaGNEeENiRzlqYTB4cGMzUkxaWGtzSUdKNWRHVnpQREErUGloN0lHdGxlVkJ5WldacGVEb2dRV3RwZEdGVGIyTnBZV3hDYjNoUWNtVm1hWGhDYkc5amEzTWdmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZaM0poY0dndVlXeG5ieTUwY3pveE9UUUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbUpzYjJOcmN5aGliRzlqYTNOTFpYa3BMbVY0YVhOMGN3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TnpFS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDZ2hkR2hwY3k1cGMwSnNiMk5yWldRb1lXUmtjbVZ6Y3l3Z2MyVnVaR1Z5S1N3Z1JWSlNYMEpNVDBOTFJVUXBDaUFnSUNCaWVpQmpjbVZoZEdWR2IyeHNiM2RmWVdaMFpYSmZZWE56WlhKMFFEUUtJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPa0pNUzBRaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2UWt4TFJBb0tZM0psWVhSbFJtOXNiRzkzWDJGbWRHVnlYMkZ6YzJWeWRFQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPamN5Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2MyVnVaR1Z5SUNFOVBTQmhaR1J5WlhOekxDQkZVbEpmVTBWTVJsOUdUMHhNVDFjcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdJVDBLSUNBZ0lHSnVlaUJqY21WaGRHVkdiMnhzYjNkZllXWjBaWEpmWVhOelpYSjBRRFlLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT2xOR1RGY2lDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlUwWk1Wd29LWTNKbFlYUmxSbTlzYkc5M1gyRm1kR1Z5WDJGemMyVnlkRUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pjMUNpQWdJQ0F2THlCamIyNXpkQ0I3SUdGMWRHOXRZWFJsWkNCOUlEMGdkR2hwY3k1blpYUk5aWFJoS0hObGJtUmxjaWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyRnNiSE4xWWlCblpYUk5aWFJoQ2lBZ0lDQndkWE5vYVc1MElETTVNZ29nSUNBZ1oyVjBZbWwwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TnpZS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDZ2hZWFYwYjIxaGRHVmtMQ0JGVWxKZlFWVlVUMDFCVkVWRVgwRkRRMDlWVGxRcENpQWdJQ0JpZWlCamNtVmhkR1ZHYjJ4c2IzZGZZV1owWlhKZllYTnpaWEowUURnS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09rRlZWRThpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZRVlZVVHdvS1kzSmxZWFJsUm05c2JHOTNYMkZtZEdWeVgyRnpjMlZ5ZEVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qYzVDaUFnSUNBdkx5QmpiMjV6ZENCbWIyeHNiM2R6UzJWNUlEMGdkR2hwY3k1bWJIY29ZV1JrY21WemN5d2djMlZ1WkdWeUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR05oYkd4emRXSWdabXgzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyZHlZWEJvTG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUdadmJHeHZkM01nUFNCQ2IzaE5ZWEE4Um05c2JHOTNjMHRsZVN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dRV3RwZEdGVGIyTnBZV3hDYjNoUWNtVm1hWGhHYjJ4c2IzZHpJSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ptSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOW5jbUZ3YUM1aGJHZHZMblJ6T2pneUNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9JWFJvYVhNdVptOXNiRzkzY3lobWIyeHNiM2R6UzJWNUtTNWxlR2x6ZEhNc0lFVlNVbDlCVEZKRlFVUlpYMFpQVEV4UFYwbE9SeWtLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1kzSmxZWFJsUm05c2JHOTNYMkZtZEdWeVgyRnpjMlZ5ZEVBeE1Bb2dJQ0FnY0hWemFHSjVkR1Z6SUNKRlVsSTZRVVpNVnlJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBCUmt4WENncGpjbVZoZEdWR2IyeHNiM2RmWVdaMFpYSmZZWE56WlhKMFFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5bmNtRndhQzVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUJqYjI1emRDQjdJR1p2Ykd4dmQyVnlRMjkxYm5Rc0lHWnZiR3h2ZDJWeVNXNWtaWGdnZlNBOUlIUm9hWE11WjJWMFRXVjBZU2hoWkdSeVpYTnpLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUdkbGRFMWxkR0VLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBME1Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTXpNS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMmR5WVhCb0xtRnNaMjh1ZEhNNk9EZ0tJQ0FnSUM4dklIUm9hWE11Wm05c2JHOTNjeWhtYjJ4c2IzZHpTMlY1S1M1MllXeDFaU0E5SUdadmJHeHZkMlZ5U1c1a1pYZ2dLeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzluY21Gd2FDNWhiR2R2TG5Sek9qa3dDaUFnSUNBdkx5QjBhR2x6TG5Wd1pHRjBaVVp2Ykd4dmQyVnlUV1YwWVNoaFpHUnlaWE56TENCbWIyeHNiM2RsY2tsdVpHVjRJQ3NnTVN3Z1ptOXNiRzkzWlhKRGIzVnVkQ0FySURFcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlIVndaR0YwWlVadmJHeHZkMlZ5VFdWMFlRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPanBDWVhObFUyOWphV0ZzTG0xaWNpaHlaV1k2SUdKNWRHVnpMQ0J5WldaVWVYQmxUbUZ0WlRvZ1lubDBaWE1zSUhKbFpsUjVjR1ZUWTJobGJXRTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pwQ1lYTmxVMjlqYVdGc0xtMWljam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pveE5Rb2dJQ0FnTHk4Z2JXSnlLSEpsWmpvZ1lubDBaWE1zSUhKbFpsUjVjR1ZPWVcxbE9pQnpkSEpwYm1jc0lISmxabFI1Y0dWVFkyaGxiV0U2SUdKNWRHVnpLVG9nUVd0cGRHRlRiMk5wWVd4TlFsSkVZWFJoSUhzS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pFNUNpQWdJQ0F2THlCd2IzTjBjem9nVFdsdVVHOXpkSE5OUWxJZ0t5QW9RbTk0UTI5emRGQmxja0o1ZEdVZ0tpQnlaV1l1YkdWdVozUm9LU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURRd01Bb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQTBOalV3TUFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5aVlYTmxMblJ6T2pNd0NpQWdJQ0F2THlCeVpXWlVlWEJsY3pvZ1VtVm1WSGx3WlhOQ1lYTmxUVUpTSUNzZ0tFSnZlRU52YzNSUVpYSkNlWFJsSUNvZ0tFSjVkR1Z6S0hKbFpsUjVjR1ZPWVcxbEtTNXNaVzVuZEdnZ0t5QkNlWFJsY3loeVpXWlVlWEJsVTJOb1pXMWhLUzVzWlc1bmRHZ3BLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCc1pXNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0FyQ2lBZ0lDQndkWE5vYVc1MElEUXdNQW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0E1TXpBd0NpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wySmhjMlV1ZEhNNk1UWXRNekVLSUNBZ0lDOHZJSEpsZEhWeWJpQjdDaUFnSUNBdkx5QWdJR1p2Ykd4dmQzTTZJRVp2Ykd4dmQzTk5RbElzQ2lBZ0lDQXZMeUFnSUdKc2IyTnJjem9nUW14dlkydHpUVUpTTEFvZ0lDQWdMeThnSUNCd2IzTjBjem9nVFdsdVVHOXpkSE5OUWxJZ0t5QW9RbTk0UTI5emRGQmxja0o1ZEdVZ0tpQnlaV1l1YkdWdVozUm9LU3dLSUNBZ0lDOHZJQ0FnZG05MFpYTTZJRlp2ZEdWelRVSlNMQW9nSUNBZ0x5OGdJQ0IyYjNSbGJHbHpkRG9nVm05MFpXeHBjM1JOUWxJc0NpQWdJQ0F2THlBZ0lISmxZV04wYVc5dWN6b2dVbVZoWTNScGIyNXpUVUpTTEFvZ0lDQWdMeThnSUNCeVpXRmpkR2x2Ym14cGMzUTZJRkpsWVdOMGFXOXViR2x6ZEUxQ1Vpd0tJQ0FnSUM4dklDQWdiV1YwWVRvZ1RXVjBZVTFDVWl3S0lDQWdJQzh2SUNBZ2JXOWtaWEpoZEc5eWN6b2dUVzlrWlhKaGRHOXljMDFDVWl3S0lDQWdJQzh2SUNBZ1ltRnVibVZrT2lCQ1lXNXVaV1JOUWxJc0NpQWdJQ0F2THlBZ0lHRmpkR2x2Ym5NNklFRmpkR2x2Ym5OTlFsSXNDaUFnSUNBdkx5QWdJQzh2SUVKdmVDQnJaWGs2SUhCeVpXWnBlQ2d4S1NBcklIVnBiblEyTkNnNEtTQTlJRGtnWW5sMFpYTUtJQ0FnSUM4dklDQWdMeThnUW05NElIWmhiSFZsT2lCQlVrTXROQ0JvWldGa1pYSW9OQ2tnS3lCemRISnBibWNnYkdWdVozUm9LRElwSUNzZ2JtRnRaU0FySUdKNWRHVnpJR3hsYm1kMGFDZ3lLU0FySUhOamFHVnRZUW9nSUNBZ0x5OGdJQ0J5WldaVWVYQmxjem9nVW1WbVZIbHdaWE5DWVhObFRVSlNJQ3NnS0VKdmVFTnZjM1JRWlhKQ2VYUmxJQ29nS0VKNWRHVnpLSEpsWmxSNWNHVk9ZVzFsS1M1c1pXNW5kR2dnS3lCQ2VYUmxjeWh5WldaVWVYQmxVMk5vWlcxaEtTNXNaVzVuZEdncEtRb2dJQ0FnTHk4Z2ZRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdOMkprTkRBd01EQXdNREF3TURBd01ETmtOVFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qSXdDaUFnSUNBdkx5QjJiM1JsY3pvZ1ZtOTBaWE5OUWxJc0NpQWdJQ0J3ZFhOb2FXNTBJREU1TXpBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZNVFl0TXpFS0lDQWdJQzh2SUhKbGRIVnliaUI3Q2lBZ0lDQXZMeUFnSUdadmJHeHZkM002SUVadmJHeHZkM05OUWxJc0NpQWdJQ0F2THlBZ0lHSnNiMk5yY3pvZ1FteHZZMnR6VFVKU0xBb2dJQ0FnTHk4Z0lDQndiM04wY3pvZ1RXbHVVRzl6ZEhOTlFsSWdLeUFvUW05NFEyOXpkRkJsY2tKNWRHVWdLaUJ5WldZdWJHVnVaM1JvS1N3S0lDQWdJQzh2SUNBZ2RtOTBaWE02SUZadmRHVnpUVUpTTEFvZ0lDQWdMeThnSUNCMmIzUmxiR2x6ZERvZ1ZtOTBaV3hwYzNSTlFsSXNDaUFnSUNBdkx5QWdJSEpsWVdOMGFXOXVjem9nVW1WaFkzUnBiMjV6VFVKU0xBb2dJQ0FnTHk4Z0lDQnlaV0ZqZEdsdmJteHBjM1E2SUZKbFlXTjBhVzl1YkdsemRFMUNVaXdLSUNBZ0lDOHZJQ0FnYldWMFlUb2dUV1YwWVUxQ1Vpd0tJQ0FnSUM4dklDQWdiVzlrWlhKaGRHOXljem9nVFc5a1pYSmhkRzl5YzAxQ1Vpd0tJQ0FnSUM4dklDQWdZbUZ1Ym1Wa09pQkNZVzV1WldSTlFsSXNDaUFnSUNBdkx5QWdJR0ZqZEdsdmJuTTZJRUZqZEdsdmJuTk5RbElzQ2lBZ0lDQXZMeUFnSUM4dklFSnZlQ0JyWlhrNklIQnlaV1pwZUNneEtTQXJJSFZwYm5RMk5DZzRLU0E5SURrZ1lubDBaWE1LSUNBZ0lDOHZJQ0FnTHk4Z1FtOTRJSFpoYkhWbE9pQkJVa010TkNCb1pXRmtaWElvTkNrZ0t5QnpkSEpwYm1jZ2JHVnVaM1JvS0RJcElDc2dibUZ0WlNBcklHSjVkR1Z6SUd4bGJtZDBhQ2d5S1NBcklITmphR1Z0WVFvZ0lDQWdMeThnSUNCeVpXWlVlWEJsY3pvZ1VtVm1WSGx3WlhOQ1lYTmxUVUpTSUNzZ0tFSnZlRU52YzNSUVpYSkNlWFJsSUNvZ0tFSjVkR1Z6S0hKbFpsUjVjR1ZPWVcxbEtTNXNaVzVuZEdnZ0t5QkNlWFJsY3loeVpXWlVlWEJsVTJOb1pXMWhLUzVzWlc1bmRHZ3BLUW9nSUNBZ0x5OGdmUW9nSUNBZ2FYUnZZZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMkpoYzJVdWRITTZNaklLSUNBZ0lDOHZJSEpsWVdOMGFXOXVjem9nVW1WaFkzUnBiMjV6VFVKU0xBb2dJQ0FnY0hWemFHbHVkQ0F5TWpFd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzlpWVhObExuUnpPakUyTFRNeENpQWdJQ0F2THlCeVpYUjFjbTRnZXdvZ0lDQWdMeThnSUNCbWIyeHNiM2R6T2lCR2IyeHNiM2R6VFVKU0xBb2dJQ0FnTHk4Z0lDQmliRzlqYTNNNklFSnNiMk5yYzAxQ1Vpd0tJQ0FnSUM4dklDQWdjRzl6ZEhNNklFMXBibEJ2YzNSelRVSlNJQ3NnS0VKdmVFTnZjM1JRWlhKQ2VYUmxJQ29nY21WbUxteGxibWQwYUNrc0NpQWdJQ0F2THlBZ0lIWnZkR1Z6T2lCV2IzUmxjMDFDVWl3S0lDQWdJQzh2SUNBZ2RtOTBaV3hwYzNRNklGWnZkR1ZzYVhOMFRVSlNMQW9nSUNBZ0x5OGdJQ0J5WldGamRHbHZibk02SUZKbFlXTjBhVzl1YzAxQ1Vpd0tJQ0FnSUM4dklDQWdjbVZoWTNScGIyNXNhWE4wT2lCU1pXRmpkR2x2Ym14cGMzUk5RbElzQ2lBZ0lDQXZMeUFnSUcxbGRHRTZJRTFsZEdGTlFsSXNDaUFnSUNBdkx5QWdJRzF2WkdWeVlYUnZjbk02SUUxdlpHVnlZWFJ2Y25OTlFsSXNDaUFnSUNBdkx5QWdJR0poYm01bFpEb2dRbUZ1Ym1Wa1RVSlNMQW9nSUNBZ0x5OGdJQ0JoWTNScGIyNXpPaUJCWTNScGIyNXpUVUpTTEFvZ0lDQWdMeThnSUNBdkx5QkNiM2dnYTJWNU9pQndjbVZtYVhnb01Ta2dLeUIxYVc1ME5qUW9PQ2tnUFNBNUlHSjVkR1Z6Q2lBZ0lDQXZMeUFnSUM4dklFSnZlQ0IyWVd4MVpUb2dRVkpETFRRZ2FHVmhaR1Z5S0RRcElDc2djM1J5YVc1bklHeGxibWQwYUNneUtTQXJJRzVoYldVZ0t5QmllWFJsY3lCc1pXNW5kR2dvTWlrZ0t5QnpZMmhsYldFS0lDQWdJQzh2SUNBZ2NtVm1WSGx3WlhNNklGSmxabFI1Y0dWelFtRnpaVTFDVWlBcklDaENiM2hEYjNOMFVHVnlRbmwwWlNBcUlDaENlWFJsY3loeVpXWlVlWEJsVG1GdFpTa3ViR1Z1WjNSb0lDc2dRbmwwWlhNb2NtVm1WSGx3WlZOamFHVnRZU2t1YkdWdVozUm9LU2tLSUNBZ0lDOHZJSDBLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOWlZWE5sTG5Sek9qSXpDaUFnSUNBdkx5QnlaV0ZqZEdsdmJteHBjM1E2SUZKbFlXTjBhVzl1YkdsemRFMUNVaXdLSUNBZ0lIQjFjMmhwYm5RZ01UZzVNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pveE5pMHpNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdabTlzYkc5M2N6b2dSbTlzYkc5M2MwMUNVaXdLSUNBZ0lDOHZJQ0FnWW14dlkydHpPaUJDYkc5amEzTk5RbElzQ2lBZ0lDQXZMeUFnSUhCdmMzUnpPaUJOYVc1UWIzTjBjMDFDVWlBcklDaENiM2hEYjNOMFVHVnlRbmwwWlNBcUlISmxaaTVzWlc1bmRHZ3BMQW9nSUNBZ0x5OGdJQ0IyYjNSbGN6b2dWbTkwWlhOTlFsSXNDaUFnSUNBdkx5QWdJSFp2ZEdWc2FYTjBPaUJXYjNSbGJHbHpkRTFDVWl3S0lDQWdJQzh2SUNBZ2NtVmhZM1JwYjI1ek9pQlNaV0ZqZEdsdmJuTk5RbElzQ2lBZ0lDQXZMeUFnSUhKbFlXTjBhVzl1YkdsemREb2dVbVZoWTNScGIyNXNhWE4wVFVKU0xBb2dJQ0FnTHk4Z0lDQnRaWFJoT2lCTlpYUmhUVUpTTEFvZ0lDQWdMeThnSUNCdGIyUmxjbUYwYjNKek9pQk5iMlJsY21GMGIzSnpUVUpTTEFvZ0lDQWdMeThnSUNCaVlXNXVaV1E2SUVKaGJtNWxaRTFDVWl3S0lDQWdJQzh2SUNBZ1lXTjBhVzl1Y3pvZ1FXTjBhVzl1YzAxQ1Vpd0tJQ0FnSUM4dklDQWdMeThnUW05NElHdGxlVG9nY0hKbFptbDRLREVwSUNzZ2RXbHVkRFkwS0RncElEMGdPU0JpZVhSbGN3b2dJQ0FnTHk4Z0lDQXZMeUJDYjNnZ2RtRnNkV1U2SUVGU1F5MDBJR2hsWVdSbGNpZzBLU0FySUhOMGNtbHVaeUJzWlc1bmRHZ29NaWtnS3lCdVlXMWxJQ3NnWW5sMFpYTWdiR1Z1WjNSb0tESXBJQ3NnYzJOb1pXMWhDaUFnSUNBdkx5QWdJSEpsWmxSNWNHVnpPaUJTWldaVWVYQmxjMEpoYzJWTlFsSWdLeUFvUW05NFEyOXpkRkJsY2tKNWRHVWdLaUFvUW5sMFpYTW9jbVZtVkhsd1pVNWhiV1VwTG14bGJtZDBhQ0FySUVKNWRHVnpLSEpsWmxSNWNHVlRZMmhsYldFcExteGxibWQwYUNrcENpQWdJQ0F2THlCOUNpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02TWpRS0lDQWdJQzh2SUcxbGRHRTZJRTFsZEdGTlFsSXNDaUFnSUNCd2RYTm9hVzUwSURRMU16QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDJKaGMyVXVkSE02TVRZdE16RUtJQ0FnSUM4dklISmxkSFZ5YmlCN0NpQWdJQ0F2THlBZ0lHWnZiR3h2ZDNNNklFWnZiR3h2ZDNOTlFsSXNDaUFnSUNBdkx5QWdJR0pzYjJOcmN6b2dRbXh2WTJ0elRVSlNMQW9nSUNBZ0x5OGdJQ0J3YjNOMGN6b2dUV2x1VUc5emRITk5RbElnS3lBb1FtOTRRMjl6ZEZCbGNrSjVkR1VnS2lCeVpXWXViR1Z1WjNSb0tTd0tJQ0FnSUM4dklDQWdkbTkwWlhNNklGWnZkR1Z6VFVKU0xBb2dJQ0FnTHk4Z0lDQjJiM1JsYkdsemREb2dWbTkwWld4cGMzUk5RbElzQ2lBZ0lDQXZMeUFnSUhKbFlXTjBhVzl1Y3pvZ1VtVmhZM1JwYjI1elRVSlNMQW9nSUNBZ0x5OGdJQ0J5WldGamRHbHZibXhwYzNRNklGSmxZV04wYVc5dWJHbHpkRTFDVWl3S0lDQWdJQzh2SUNBZ2JXVjBZVG9nVFdWMFlVMUNVaXdLSUNBZ0lDOHZJQ0FnYlc5a1pYSmhkRzl5Y3pvZ1RXOWtaWEpoZEc5eWMwMUNVaXdLSUNBZ0lDOHZJQ0FnWW1GdWJtVmtPaUJDWVc1dVpXUk5RbElzQ2lBZ0lDQXZMeUFnSUdGamRHbHZibk02SUVGamRHbHZibk5OUWxJc0NpQWdJQ0F2THlBZ0lDOHZJRUp2ZUNCclpYazZJSEJ5WldacGVDZ3hLU0FySUhWcGJuUTJOQ2c0S1NBOUlEa2dZbmwwWlhNS0lDQWdJQzh2SUNBZ0x5OGdRbTk0SUhaaGJIVmxPaUJCVWtNdE5DQm9aV0ZrWlhJb05Da2dLeUJ6ZEhKcGJtY2diR1Z1WjNSb0tESXBJQ3NnYm1GdFpTQXJJR0o1ZEdWeklHeGxibWQwYUNneUtTQXJJSE5qYUdWdFlRb2dJQ0FnTHk4Z0lDQnlaV1pVZVhCbGN6b2dVbVZtVkhsd1pYTkNZWE5sVFVKU0lDc2dLRUp2ZUVOdmMzUlFaWEpDZVhSbElDb2dLRUo1ZEdWektISmxabFI1Y0dWT1lXMWxLUzVzWlc1bmRHZ2dLeUJDZVhSbGN5aHlaV1pVZVhCbFUyTm9aVzFoS1M1c1pXNW5kR2dwS1FvZ0lDQWdMeThnZlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dlltRnpaUzUwY3pveU53b2dJQ0FnTHk4Z1lXTjBhVzl1Y3pvZ1FXTjBhVzl1YzAxQ1Vpd0tJQ0FnSUhCMWMyaHBiblFnTWprM01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2WW1GelpTNTBjem94Tmkwek1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhzS0lDQWdJQzh2SUNBZ1ptOXNiRzkzY3pvZ1JtOXNiRzkzYzAxQ1Vpd0tJQ0FnSUM4dklDQWdZbXh2WTJ0ek9pQkNiRzlqYTNOTlFsSXNDaUFnSUNBdkx5QWdJSEJ2YzNSek9pQk5hVzVRYjNOMGMwMUNVaUFySUNoQ2IzaERiM04wVUdWeVFubDBaU0FxSUhKbFppNXNaVzVuZEdncExBb2dJQ0FnTHk4Z0lDQjJiM1JsY3pvZ1ZtOTBaWE5OUWxJc0NpQWdJQ0F2THlBZ0lIWnZkR1ZzYVhOME9pQldiM1JsYkdsemRFMUNVaXdLSUNBZ0lDOHZJQ0FnY21WaFkzUnBiMjV6T2lCU1pXRmpkR2x2Ym5OTlFsSXNDaUFnSUNBdkx5QWdJSEpsWVdOMGFXOXViR2x6ZERvZ1VtVmhZM1JwYjI1c2FYTjBUVUpTTEFvZ0lDQWdMeThnSUNCdFpYUmhPaUJOWlhSaFRVSlNMQW9nSUNBZ0x5OGdJQ0J0YjJSbGNtRjBiM0p6T2lCTmIyUmxjbUYwYjNKelRVSlNMQW9nSUNBZ0x5OGdJQ0JpWVc1dVpXUTZJRUpoYm01bFpFMUNVaXdLSUNBZ0lDOHZJQ0FnWVdOMGFXOXVjem9nUVdOMGFXOXVjMDFDVWl3S0lDQWdJQzh2SUNBZ0x5OGdRbTk0SUd0bGVUb2djSEpsWm1sNEtERXBJQ3NnZFdsdWREWTBLRGdwSUQwZ09TQmllWFJsY3dvZ0lDQWdMeThnSUNBdkx5QkNiM2dnZG1Gc2RXVTZJRUZTUXkwMElHaGxZV1JsY2lnMEtTQXJJSE4wY21sdVp5QnNaVzVuZEdnb01pa2dLeUJ1WVcxbElDc2dZbmwwWlhNZ2JHVnVaM1JvS0RJcElDc2djMk5vWlcxaENpQWdJQ0F2THlBZ0lISmxabFI1Y0dWek9pQlNaV1pVZVhCbGMwSmhjMlZOUWxJZ0t5QW9RbTk0UTI5emRGQmxja0o1ZEdVZ0tpQW9RbmwwWlhNb2NtVm1WSGx3WlU1aGJXVXBMbXhsYm1kMGFDQXJJRUo1ZEdWektISmxabFI1Y0dWVFkyaGxiV0VwTG14bGJtZDBhQ2twQ2lBZ0lDQXZMeUI5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRWdBaVlNQ1dGcmFYUmhYMlJoYndRVkgzeDFBQWhGVWxJNlFrRk9SQUZpQVdZSVJWSlNPa2xRUVZrRGMyRnNCM1psY25OcGIyNERjR0ZzQm5kaGJHeGxkQWhGVWxJNlRrUkJUNEFFNnBHQTNUWWFBSTRCQUh3eEdSUkVNUmhCQUdXQ0RRUzFuSXBVQks3cnMzZ0VobWRVbEFSTGI1Qi9CQlliT25vRVF3Tm1qZ1RyWXZVSUJBbURnS1FFRkRKUHR3U2hOS0o0QkRSQmRmQUVNK2tzbEFTRlRlM2dOaG9BamcwQVFRQ2ZBUEFCb3dIeUFsUUNld0tqQXNVQy9nTlBCRUVBQVFBalE0QUViNWdYOWpZYUFJNEJBQTBBTVJtQkJCSXhHQkJFUWdQYk5ob0JTUldCQ0JKRUZ6WWFBa2tpV1NVSVN3RVZFa1JYQWdBb1R3Sm5Kd2hNWnlORE1SWWpDVWs0RUNNU1JEWWFBVWtWSkJKRU1RQ0lCQTVCQUFNcnNBQXhBRXNCRTBBQURJQUlSVkpTT2xOQ1RFdXdBRXNCU1RnSE1nb1NURGdJS2tjQ2lBVlZnUWhiRWhCQUFBUW5CckFBTVFCTEFZZ0VDaWNFVEZBaXVVZ2pReUkyR2dGSkZTUVNSREVBaUFPNVFRQURLN0FBTVFCTEFZZ0Q1aWNFVEZCSlJRTzlSUUZBQUF5QUNFVlNVanBWVGtKTHNBQkxBYnhJc1RFQUtrY0NpQVQ0Z1FoYnNnaXlCeU95RUNLeUFiTWpRekVXSlFsSk9CQWpFa1F4RmlNSlJ3STRFSUVHRWtRMkdnRkpUZ0pKRlNRU1JJZ0R3bGN5Q0V3aUtHVkVNUUJPQWt3NEdFeUFBMkZoYkdWSWdTaGJFa0VBYlVzRE9CbEFBR1pMQXpnYmdRUVNRUUJjU3dNaXdocUFCRU9TSmxVU1FRQk5Td01qd2hwTEFSSkJBRUpMQXlYQ0drc0NFa0VBTnlOQUFBeUFDRVZTVWpwR1IxUkZzQUFxUndLSUJGb2lXMHNGU1RnSE1nb1NURGdJVHdJU0VFQUFCQ2NHc0FBeEFFc0RpQU9qSTBNaVF2L0dNUllqQ1VrNEVDTVNSRFlhQVVjQ0ZTUVNSSWdESFlFeVcwRUFESUFJUlZKU09raEhWRVd3QUNwSEFvZ0VCeUpiU3dKSk9BY3lDaEpNT0FoUEFoSVFRQUFFSndhd0FERUFTd0dJQTFBalF5STJHZ0ZKRlNRU1JERUFpQUptUVFBREs3QUFTVEVBaUFLdkp3Vk1VRWxGQTcxRkFVQUFESUFJUlZKU09rNUdURmV3QUVjQ2lBS3NTWUVwVzB5QklWdE1Jd21JQXRaTEFieElzVEVBS2tjQ2lBT1RJbHV5Q0xJSEk3SVFJcklCc3lORE5ob0JTUlVrRWtRMkdnSkpGU1FTUklnQ09TY0VURkM5UlFHQUFRQWlUd0pVS1V4UXNDTkROaG9CU1JVa0VrUTJHZ0pKRlNRU1JFeUlBaXduQlV4UXZVVUJnQUVBSWs4Q1ZDbE1VTEFqUXpZYUFVa1ZKQkpFTmhvQ1NSVWtFa1JNaUFJRUp3Vk1VTDVFRnhZcFRGQ3dJME0yR2dGSklsa2xDRXNCRlJKRVZ3SUFOaG9DU1NKWkpRaExBUlVTUkZjQ0FEWWFBMGtpV1NVSVN3RVZFa1JYQWdDSUF1QXBURkN3STBNMkdnRkpGVXNCSWxsSmdRUVNSRXNDU3dGTEExSWlXWUVSQzRFR0NFc0RKVmxKU3dJU1JFc0VTd0ZMQlZJaVdVbUJFUXNsQ0U4RENFOEVFa1JPQTFJaVdRaUJrRFVMZ2RBb0NCWXBURkN3STBNMkdnRkpGWUVJRWtRWFNUWWFBa2tWSkJKRU5ob0RTUldCQ0JKRUYwNENUSUFNWVd0cGRHRmZZWE56WlhSelpVZ2lXM0FBUlFGQUFHSkpRUUJlc1VzQkp3bGxTRmNBQ0NNV01nTkxBN0lZZ0FTellqU2xzaHBQQXJJYVRMSWFzaHFBQWdBQXNocUFCR2cxNDd5eUdvRUdzaEFpc2dHenRENUpWd1FBVEZjQUJDa1NSRWtWSXhKRUlsTkJBQTR5RUJhQUFSUk1VQ2xNVUxBalE0QUpDZ0FBQUFBQUFBQUFRdi9zTmhvQlNTSlpKUWhMQVJVU1JGY0NBREVBSWlobFJDY0taVWh5Q0VRU1FBQUVKd3V3QUNJb1pVUW5DV1ZJZ1JCYk1nMFNRQUFNZ0FoRlVsSTZTVlZRUjdBQUp3aExBV2NqUXpZYUFVa1ZnUWdTUkJjeEFDSW9aVVFuQ21WSWNnaEVFa0FBQkNjTHNBQW9Td0ZuSTBPS0FRRWlLR1ZFSndkbFNJRVlXN0d5R0lBRWhDYWNlTElhaS8reUdvRUdzaEFpc2dHenRENUpWd1FBVEZjQUJDa1NSRWtWSXhKRUlsT0ppZ0lCaS81UkFCQkpGWUVRRWtTTC8xRUFFRWtWZ1JBU1JGQ0ppZ0lCaS81UkFCQkpGWUVRRWtTTC8xRUFFRWtWZ1JBU1JGQ0ppZ0VCSWlobFJDY0haVWdpVzdHeUdJQUVjNTZuQzdJYWkvK3lHb0VHc2hBaXNnR3p0RDVKVndRQVRGY0FCQ2tTUkVrVmdVb1NSSW1LQXdBaUtHVkVKd2RsU0NKYnNZditGb3YvRms4Q3NoaUFCRE1Hc3lxeUdvdjlzaHBNc2hxeUdvRUdzaEFpc2dHemlZb0NBQ0tML29qL0hVRUFBeXV3QUl2L2kvNkkvMG9uQkV4UXZVVUJRUUFNZ0FoRlVsSTZRa3hMUkxBQWkvNkwveE5BQUF5QUNFVlNVanBUUmt4WHNBQ0wvb2ovVVlHSUExTkJBQXlBQ0VWU1VqcEJWVlJQc0FDTC80ditpUDhjSndWTVVFbU1BTDFGQVVFQURJQUlSVkpTT2tGR1RGZXdBSXYvaVA4WlNZRXBXMHlCSVZzakNFa1dpd0JNdjB3akNJdi9UZ0tJL3plSmlnTUJpLzBWZ1pBREM0R2s2d0lJaS80VmkvOFZDSUdRQXd1QjFFZ0lUQmFBRUFBQUFBQUFBSHZVQUFBQUFBQUFQVlJNVUlIa2xnRVdURXNCVUV4UWdkU3NBUlpRZ2RTVEFSWk1Td0ZRZ2ZUaEFoWlFTd0ZRVEZDQmhPZ0JGbEJNRmxDSiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
