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

namespace Arc56.Generated.akita_protocol.akita_sc.AkitaSocialModeration_10f9ff8b
{


    public class AkitaSocialModerationProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AkitaSocialModerationProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ObjectAed1Fa93 : AVMObjectType
            {
                public bool Exists { get; set; }

                public ulong LastActive { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vExists.From(Exists);
                    ret.AddRange(vExists.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastActive.From(LastActive);
                    ret.AddRange(vLastActive.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ObjectAed1Fa93 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ObjectAed1Fa93();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vExists.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExists = vExists.ToValue();
                    if (valueExists is bool vExistsValue) { ret.Exists = vExistsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastActive = vLastActive.ToValue();
                    if (valueLastActive is ulong vLastActiveValue) { ret.LastActive = vLastActiveValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ObjectAed1Fa93);
                }
                public bool Equals(ObjectAed1Fa93? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ObjectAed1Fa93 left, ObjectAed1Fa93 right)
                {
                    return EqualityComparer<ObjectAed1Fa93>.Default.Equals(left, right);
                }
                public static bool operator !=(ObjectAed1Fa93 left, ObjectAed1Fa93 right)
                {
                    return !(left == right);
                }

            }

            public class Action : AVMObjectType
            {
                public byte[] Content { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vContent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[36]");
                    vContent.From(Content);
                    ret.AddRange(vContent.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Action Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Action();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vContent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[36]");
                    count = vContent.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueContent = vContent.ToValue();
                    if (valueContent is byte[] vContentValue) { ret.Content = vContentValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Action);
                }
                public bool Equals(Action? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Action left, Action right)
                {
                    return EqualityComparer<Action>.Default.Equals(left, right);
                }
                public static bool operator !=(Action left, Action right)
                {
                    return !(left == right);
                }

            }

            public class ModeratorActivity : AVMObjectType
            {
                public ulong Epoch { get; set; }

                public ulong Actions { get; set; }

                public ulong PreviousActions { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEpoch = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEpoch.From(Epoch);
                    ret.AddRange(vEpoch.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vActions.From(Actions);
                    ret.AddRange(vActions.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousActions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPreviousActions.From(PreviousActions);
                    ret.AddRange(vPreviousActions.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ModeratorActivity Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ModeratorActivity();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEpoch = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEpoch.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEpoch = vEpoch.ToValue();
                    if (valueEpoch is ulong vEpochValue) { ret.Epoch = vEpochValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vActions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActions = vActions.ToValue();
                    if (valueActions is ulong vActionsValue) { ret.Actions = vActionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousActions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPreviousActions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePreviousActions = vPreviousActions.ToValue();
                    if (valuePreviousActions is ulong vPreviousActionsValue) { ret.PreviousActions = vPreviousActionsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ModeratorActivity);
                }
                public bool Equals(ModeratorActivity? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ModeratorActivity left, ModeratorActivity right)
                {
                    return EqualityComparer<ModeratorActivity>.Default.Equals(left, right);
                }
                public static bool operator !=(ModeratorActivity left, ModeratorActivity right)
                {
                    return !(left == right);
                }

            }

            public class ModeratorActivityInfo : AVMObjectType
            {
                public bool Exists { get; set; }

                public ulong LastActive { get; set; }

                public ulong Epoch { get; set; }

                public ulong Actions { get; set; }

                public ulong PreviousActions { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vExists.From(Exists);
                    ret.AddRange(vExists.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastActive.From(LastActive);
                    ret.AddRange(vLastActive.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEpoch = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEpoch.From(Epoch);
                    ret.AddRange(vEpoch.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vActions.From(Actions);
                    ret.AddRange(vActions.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousActions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPreviousActions.From(PreviousActions);
                    ret.AddRange(vPreviousActions.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ModeratorActivityInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ModeratorActivityInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vExists.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExists = vExists.ToValue();
                    if (valueExists is bool vExistsValue) { ret.Exists = vExistsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastActive = vLastActive.ToValue();
                    if (valueLastActive is ulong vLastActiveValue) { ret.LastActive = vLastActiveValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEpoch = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEpoch.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEpoch = vEpoch.ToValue();
                    if (valueEpoch is ulong vEpochValue) { ret.Epoch = vEpochValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vActions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActions = vActions.ToValue();
                    if (valueActions is ulong vActionsValue) { ret.Actions = vActionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPreviousActions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPreviousActions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePreviousActions = vPreviousActions.ToValue();
                    if (valuePreviousActions is ulong vPreviousActionsValue) { ret.PreviousActions = vPreviousActionsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ModeratorActivityInfo);
                }
                public bool Equals(ModeratorActivityInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ModeratorActivityInfo left, ModeratorActivityInfo right)
                {
                    return EqualityComparer<ModeratorActivityInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(ModeratorActivityInfo left, ModeratorActivityInfo right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="version"> </param>
        /// <param name="akitaDAO"> </param>
        public async Task Create(string version, ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 154, 214, 126 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            var result = await base.CallApp(new List<object> { abiHandle, versionAbi, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(string version, ulong akitaDAO, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 154, 214, 126 };
            var versionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); versionAbi.From(version);
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);

            return await base.MakeTransactionList(new List<object> { abiHandle, versionAbi, akitaDAOAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        public async Task AddModerator(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 217, 184, 211 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddModerator_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 217, 184, 211 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        public async Task RemoveModerator(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 227, 171, 34 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveModerator_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 227, 171, 34 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        /// <param name="expiration"> </param>
        public async Task Ban(Algorand.Address address, ulong expiration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 131, 59, 64 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var expirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expirationAbi.From(expiration);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi, expirationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Ban_Transactions(Algorand.Address address, ulong expiration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 131, 59, 64 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var expirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expirationAbi.From(expiration);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi, expirationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        public async Task Unban(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 210, 50, 29 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Unban_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 210, 50, 29 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="ref"> </param>
        public async Task FlagPost(byte[] @ref, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 220, 210, 239 };
            var refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); refAbi.From(@ref);

            var result = await base.CallApp(new List<object> { abiHandle, refAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FlagPost_Transactions(byte[] @ref, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 220, 210, 239 };
            var refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); refAbi.From(@ref);

            return await base.MakeTransactionList(new List<object> { abiHandle, refAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="ref"> </param>
        public async Task UnflagPost(byte[] @ref, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 96, 234, 118 };
            var refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); refAbi.From(@ref);

            var result = await base.CallApp(new List<object> { abiHandle, refAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UnflagPost_Transactions(byte[] @ref, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 96, 234, 118 };
            var refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); refAbi.From(@ref);

            return await base.MakeTransactionList(new List<object> { abiHandle, refAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="ref"> </param>
        /// <param name="flags"> </param>
        public async Task SetModeratorContentFlags(byte[] @ref, ulong flags, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 244, 221, 53 };
            var refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); refAbi.From(@ref);
            var flagsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); flagsAbi.From(flags);

            var result = await base.CallApp(new List<object> { abiHandle, refAbi, flagsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetModeratorContentFlags_Transactions(byte[] @ref, ulong flags, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 244, 221, 53 };
            var refAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); refAbi.From(@ref);
            var flagsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); flagsAbi.From(flags);

            return await base.MakeTransactionList(new List<object> { abiHandle, refAbi, flagsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="actionAppID"> </param>
        /// <param name="content"> </param>
        public async Task AddAction(ulong actionAppID, byte[] content, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 106, 220, 217 };
            var actionAppIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); actionAppIDAbi.From(actionAppID);
            var contentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(36, "byte"); contentAbi.From(content);

            var result = await base.CallApp(new List<object> { abiHandle, actionAppIDAbi, contentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddAction_Transactions(ulong actionAppID, byte[] content, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 218, 106, 220, 217 };
            var actionAppIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); actionAppIDAbi.From(actionAppID);
            var contentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(36, "byte"); contentAbi.From(content);

            return await base.MakeTransactionList(new List<object> { abiHandle, actionAppIDAbi, contentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="actionAppID"> </param>
        public async Task RemoveAction(ulong actionAppID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 73, 43, 244 };
            var actionAppIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); actionAppIDAbi.From(actionAppID);

            var result = await base.CallApp(new List<object> { abiHandle, actionAppIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveAction_Transactions(ulong actionAppID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 73, 43, 244 };
            var actionAppIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); actionAppIDAbi.From(actionAppID);

            return await base.MakeTransactionList(new List<object> { abiHandle, actionAppIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task<bool> IsBanned(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 38, 156, 120 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsBanned_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 38, 156, 120 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task<bool> IsModerator(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 46, 232, 35 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsModerator_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 46, 232, 35 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        public async Task<Structs.ObjectAed1Fa93> ModeratorMeta(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 31, 60, 97, 140 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ObjectAed1Fa93.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ModeratorMeta_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 31, 60, 97, 140 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Counted actions in the current epoch (`actions`) and the epoch before it (`previousActions`)
        ///</summary>
        /// <param name="user"> </param>
        public async Task<Structs.ModeratorActivityInfo> ModeratorActivity(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 56, 230, 237 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ModeratorActivityInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ModeratorActivity_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 56, 230, 237 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWtpdGFTb2NpYWxNb2RlcmF0aW9uIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdEFFRDFGQTkzIjpbeyJuYW1lIjoiZXhpc3RzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJsYXN0QWN0aXZlIiwidHlwZSI6InVpbnQ2NCJ9XSwiQWN0aW9uIjpbeyJuYW1lIjoiY29udGVudCIsInR5cGUiOiJieXRlWzM2XSJ9XSwiTW9kZXJhdG9yQWN0aXZpdHkiOlt7Im5hbWUiOiJlcG9jaCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhY3Rpb25zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByZXZpb3VzQWN0aW9ucyIsInR5cGUiOiJ1aW50NjQifV0sIk1vZGVyYXRvckFjdGl2aXR5SW5mbyI6W3sibmFtZSI6ImV4aXN0cyIsInR5cGUiOiJib29sIn0seyJuYW1lIjoibGFzdEFjdGl2ZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJlcG9jaCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhY3Rpb25zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByZXZpb3VzQWN0aW9ucyIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcnNpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFraXRhREFPIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZE1vZGVyYXRvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW1vdmVNb2RlcmF0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmFuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBpcmF0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVuYmFuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZsYWdQb3N0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVuZmxhZ1Bvc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0TW9kZXJhdG9yQ29udGVudEZsYWdzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmbGFncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRBY3Rpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWN0aW9uQXBwSUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzZdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udGVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW1vdmVBY3Rpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWN0aW9uQXBwSUQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNCYW5uZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc01vZGVyYXRvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1vZGVyYXRvck1ldGEiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsdWludDY0KSIsInN0cnVjdCI6Ik9iamVjdEFFRDFGQTkzIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtb2RlcmF0b3JBY3Rpdml0eSIsImRlc2MiOiJDb3VudGVkIGFjdGlvbnMgaW4gdGhlIGN1cnJlbnQgZXBvY2ggKGBhY3Rpb25zYCkgYW5kIHRoZSBlcG9jaCBiZWZvcmUgaXQgKGBwcmV2aW91c0FjdGlvbnNgKSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiTW9kZXJhdG9yQWN0aXZpdHlJbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3VmVyc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQWtpdGFEQU8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3BVcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzgyNyw4OTksMTAwMiwxMDI2LDEyMzBdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM3MF0sImVycm9yTWVzc2FnZSI6IkJ5dGVzIGhhcyB2YWxpZCBwcmVmaXgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTldLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyQm1vZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5NF0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJCbnhwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzUyLDgwMV0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJFYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDcyXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyckViYW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDddLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyRW1vZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMzVdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJySXVwZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3NV0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJOYmFuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIxLDM4Nyw3MzQsNzg0LDExMDAsMTE2OV0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJOZGFvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDAyLDQ0Myw1NDksNjA2LDY0MCw2ODNdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyTm1vZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNCwzODAsNzI3LDc3NywxMDkzLDExNjJdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDgsMzc0LDcyMSw3NzEsMTA4NywxMTA0LDExNTYsMTMyMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2NCwxMDcwLDEzOTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzIsMTA3OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDIsMzY4LDQyMCw1MzUsNTkyLDYyNiw2NjAsODEzLDg2MCw4ODcsOTMzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzNj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODMsNDI4LDY2OCw3MDUsNzY0LDExNDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzk1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9zb2NpYWwvdHlwZXMudHM6OlBvc3RWYWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzODJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA5IG9mICh1aW50OFszMl0sdWludDY0LHVpbnQ2NCxib29sMSx1aW50NjQsYm9vbDEsdWludDgsdWludDY0LHVpbnQ2NCwobGVuK3VpbnQ4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHR1cGxlIGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURnZ016SWdOakEwT0RBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySUNKa0lpQWlZV3RwZEdGZlpHRnZJaUFpZDJGc2JHVjBJaUFpUlZKU09tVnljazVrWVc4aUlDSnJJaUFpUlZKU09tVnljazV0YjJRaUlEQjRNVFV4Wmpkak56VWdJbTRpSURCNE1EQWdJblpsY25OcGIyNGlJQ0pGVWxJNlpYSnlSV0ZqZENJZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRV3RwZEdGVGIyTnBZV3hOYjJSbGNtRjBhVzl1SUdWNGRHVnVaSE1nVlhCbmNtRmtaV0ZpYkdWQmEybDBZVUpoYzJWRGIyNTBjbUZqZENCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobFlUa3hPREJrWkNBdkx5QnRaWFJvYjJRZ0luVndaR0YwWlNoemRISnBibWNwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmRYQmtZWFJsWDNKdmRYUmxRRElLQ20xaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCYTJsMFlWTnZZMmxoYkUxdlpHVnlZWFJwYjI0Z1pYaDBaVzVrY3lCVmNHZHlZV1JsWVdKc1pVRnJhWFJoUW1GelpVTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTWpFS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoalkyUTVZamhrTXlBd2VEQXpaVE5oWWpJeUlEQjROMkU0TXpOaU5EQWdNSGhoTUdReU16SXhaQ0F3ZURZeFpHTmtNbVZtSURCNE56azJNR1ZoTnpZZ01IaG1ZbVkwWkdRek5TQXdlR1JoTm1Ga1kyUTVJREI0WmpFME9USmlaalFnTUhnNE5ESTJPV00zT0NBd2VEY3hNbVZsT0RJeklEQjRNV1l6WXpZeE9HTWdNSGhsTVRNNFpUWmxaQ0F3ZURNelpUa3lZemswSURCNE9EVTBaR1ZrWlRBZ0x5OGdiV1YwYUc5a0lDSmhaR1JOYjJSbGNtRjBiM0lvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnlaVzF2ZG1WTmIyUmxjbUYwYjNJb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0ppWVc0b1lXUmtjbVZ6Y3l4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlkVzVpWVc0b1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0ptYkdGblVHOXpkQ2hpZVhSbFd6TXlYU2wyYjJsa0lpd2diV1YwYUc5a0lDSjFibVpzWVdkUWIzTjBLR0o1ZEdWYk16SmRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRTF2WkdWeVlYUnZja052Ym5SbGJuUkdiR0ZuY3loaWVYUmxXek15WFN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZV1JrUVdOMGFXOXVLSFZwYm5RMk5DeGllWFJsV3pNMlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpXMXZkbVZCWTNScGIyNG9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1selFtRnVibVZrS0dGa1pISmxjM01wWW05dmJDSXNJRzFsZEdodlpDQWlhWE5OYjJSbGNtRjBiM0lvWVdSa2NtVnpjeWxpYjI5c0lpd2diV1YwYUc5a0lDSnRiMlJsY21GMGIzSk5aWFJoS0dGa1pISmxjM01wS0dKdmIyd3NkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWliVzlrWlhKaGRHOXlRV04wYVhacGRIa29ZV1JrY21WemN5a29ZbTl2YkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSjFjR1JoZEdWQmEybDBZVVJCVHloMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWliM0JWY0NncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdGa1pFMXZaR1Z5WVhSdmNpQnlaVzF2ZG1WTmIyUmxjbUYwYjNJZ1ltRnVJSFZ1WW1GdUlHWnNZV2RRYjNOMElIVnVabXhoWjFCdmMzUWdjMlYwVFc5a1pYSmhkRzl5UTI5dWRHVnVkRVpzWVdkeklHRmtaRUZqZEdsdmJpQnlaVzF2ZG1WQlkzUnBiMjRnYVhOQ1lXNXVaV1FnYVhOTmIyUmxjbUYwYjNJZ2JXOWtaWEpoZEc5eVRXVjBZU0J0YjJSbGNtRjBiM0pCWTNScGRtbDBlU0IxY0dSaGRHVkJhMmwwWVVSQlR5QnRZV2x1WDI5d1ZYQmZjbTkxZEdWQU1Ua0tJQ0FnSUdWeWNnb0tiV0ZwYmw5dmNGVndYM0p2ZFhSbFFERTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qTXdDaUFnSUNBdkx5QnZjRlZ3S0NrNklIWnZhV1FnZXlCOUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FESXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCYTJsMFlWTnZZMmxoYkUxdlpHVnlZWFJwYjI0Z1pYaDBaVzVrY3lCVmNHZHlZV1JsWVdKc1pVRnJhWFJoUW1GelpVTnZiblJ5WVdOMElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHTmtPV0ZrTmpkbElDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtITjBjbWx1Wnl4MWFXNTBOalFwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR055WldGMFpRb2dJQ0FnWlhKeUNncHRZV2x1WDNWd1pHRjBaVjl5YjNWMFpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qTTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQmJKMVZ3WkdGMFpVRndjR3hwWTJGMGFXOXVKMTBnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QlZjR1JoZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCaUlIVndaR0YwWlFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qcEJhMmwwWVZOdlkybGhiRTF2WkdWeVlYUnBiMjR1WTNKbFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ2YmtOeVpXRjBaVG9nSjNKbGNYVnBjbVVuSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hOQW9nSUNBZ0x5OGdkbVZ5YzJsdmJpQTlJRWRzYjJKaGJGTjBZWFJsUEhOMGNtbHVaejRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVZtVnljMmx2YmlCOUtRb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRtVnljMmx2YmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUIwYUdsekxuWmxjbk5wYjI0dWRtRnNkV1VnUFNCMlpYSnphVzl1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1UWUtJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdkR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU0E5SUdGcmFYUmhSRUZQQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZOamdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02T2tGcmFYUmhVMjlqYVdGc1RXOWtaWEpoZEdsdmJpNWhaR1JOYjJSbGNtRjBiM0piY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaFpHUk5iMlJsY21GMGIzSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pvM05nb2dJQ0FnTHk4Z1lXUmtUVzlrWlhKaGRHOXlLR0ZrWkhKbGMzTTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TnpjS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbWRsZEVGcmFYUmhSRUZQVjJGc2JHVjBLQ2t1WVdSa2NtVnpjeXdnWlhKeVRtOTBRV3RwZEdGRVlXOHBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TVRrS0lDQWdJQzh2SUdOdmJuTjBJRnQzWVd4c1pYUkpSRjBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoVmFXNTBOalFvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlN3Z1FubDBaWE1vUVd0cGRHRkVRVTlIYkc5aVlXeFRkR0YwWlV0bGVYTlhZV3hzWlhRcEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem94TmdvZ0lDQWdMeThnWVd0cGRHRkVRVThnUFNCSGJHOWlZV3hUZEdGMFpUeEJjSEJzYVdOaGRHbHZiajRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVFXdHBkR0ZFUVU4Z2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRnJhWFJoWDJSaGJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pveE9Rb2dJQ0FnTHk4Z1kyOXVjM1FnVzNkaGJHeGxkRWxFWFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVGVnBiblEyTkNoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMWRoYkd4bGRDa3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTmZNaUF2THlBaWQyRnNiR1YwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TnpjS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbWRsZEVGcmFYUmhSRUZQVjJGc2JHVjBLQ2t1WVdSa2NtVnpjeXdnWlhKeVRtOTBRV3RwZEdGRVlXOHBDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCQlpHUnlaWE56Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3YkdsallYUnBiMjRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW01NklHRmtaRTF2WkdWeVlYUnZjbDloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVJWSlNPbVZ5Y2s1a1lXOGlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlUbVJoYndvS1lXUmtUVzlrWlhKaGRHOXlYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUcxdlpHVnlZWFJ2Y25NZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dRV3RwZEdGVGIyTnBZV3hDYjNoUWNtVm1hWGhOYjJSbGNtRjBiM0p6SUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKa0lnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLQ0YwYUdsekxtMXZaR1Z5WVhSdmNuTW9ZV1JrY21WemN5a3VaWGhwYzNSekxDQmxjbkpCYkhKbFlXUjVRVTF2WkdWeVlYUnZjaWtLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1lXUmtUVzlrWlhKaGRHOXlYMkZtZEdWeVgyRnpjMlZ5ZEVBMUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtWU1VqcGxjbkpGYlc5a0lnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrVnRiMlFLQ21Ga1pFMXZaR1Z5WVhSdmNsOWhablJsY2w5aGMzTmxjblJBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPamM1Q2lBZ0lDQXZMeUIwYUdsekxtMXZaR1Z5WVhSdmNuTW9ZV1JrY21WemN5a3VZM0psWVhSbEtDa0tJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JpYjNoZlkzSmxZWFJsQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QmhZM1JwZG1sMGVTQTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQk5iMlJsY21GMGIzSkJZM1JwZG1sMGVUNG9leUJyWlhsUWNtVm1hWGc2SUVGcmFYUmhVMjlqYVdGc1FtOTRVSEpsWm1sNFRXOWtaWEpoZEc5eVFXTjBhWFpwZEhrZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltc2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qZ3dDaUFnSUNBdkx5QjBhR2x6TG1GamRHbDJhWFI1S0dGa1pISmxjM01wTG1OeVpXRjBaU2dwQ2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCaWIzaGZZM0psWVhSbENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJoWkdSTmIyUmxjbUYwYjNJb1lXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qcEJhMmwwWVZOdlkybGhiRTF2WkdWeVlYUnBiMjR1Y21WdGIzWmxUVzlrWlhKaGRHOXlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WdGIzWmxUVzlrWlhKaGRHOXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk9ETUtJQ0FnSUM4dklISmxiVzkyWlUxdlpHVnlZWFJ2Y2loaFpHUnlaWE56T2lCQlkyTnZkVzUwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qZzBDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1blpYUkJhMmwwWVVSQlQxZGhiR3hsZENncExtRmtaSEpsYzNNc0lHVnljazV2ZEVGcmFYUmhSR0Z2S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qRTVDaUFnSUNBdkx5QmpiMjV6ZENCYmQyRnNiR1YwU1VSZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRWV2x1ZERZMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6VjJGc2JHVjBLU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1UWUtJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNVGtLSUNBZ0lDOHZJR052Ym5OMElGdDNZV3hzWlhSSlJGMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhWYVc1ME5qUW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU3dnUW5sMFpYTW9RV3RwZEdGRVFVOUhiRzlpWVd4VGRHRjBaVXRsZVhOWFlXeHNaWFFwS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbmRoYkd4bGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qZzBDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1blpYUkJhMmwwWVVSQlQxZGhiR3hsZENncExtRmtaSEpsYzNNc0lHVnljazV2ZEVGcmFYUmhSR0Z2S1FvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndRV1JrY21WemN3b2dJQ0FnWVhOelpYSjBJQzh2SUdGd2NHeHBZMkYwYVc5dUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ5WlcxdmRtVk5iMlJsY21GMGIzSmZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJR0o1ZEdWalh6TWdMeThnSWtWU1VqcGxjbkpPWkdGdklnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrNWtZVzhLQ25KbGJXOTJaVTF2WkdWeVlYUnZjbDloWm5SbGNsOWhjM05sY25SQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCdGIyUmxjbUYwYjNKeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJRUZyYVhSaFUyOWphV0ZzUW05NFVISmxabWw0VFc5a1pYSmhkRzl5Y3lCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpDSUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk9EVUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2gwYUdsekxtMXZaR1Z5WVhSdmNuTW9ZV1JrY21WemN5a3VaWGhwYzNSekxDQmxjbkpPYjNSQlRXOWtaWEpoZEc5eUtRb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nY21WdGIzWmxUVzlrWlhKaGRHOXlYMkZtZEdWeVgyRnpjMlZ5ZEVBMUNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKRlVsSTZaWEp5VG0xdlpDSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSk9iVzlrQ2dweVpXMXZkbVZOYjJSbGNtRjBiM0pmWVdaMFpYSmZZWE56WlhKMFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pvNE5nb2dJQ0FnTHk4Z2RHaHBjeTV0YjJSbGNtRjBiM0p6S0dGa1pISmxjM01wTG1SbGJHVjBaU2dwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJoWTNScGRtbDBlU0E5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0JOYjJSbGNtRjBiM0pCWTNScGRtbDBlVDRvZXlCclpYbFFjbVZtYVhnNklFRnJhWFJoVTI5amFXRnNRbTk0VUhKbFptbDRUVzlrWlhKaGRHOXlRV04wYVhacGRIa2dmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbXNpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUIwYUdsekxtRmpkR2wyYVhSNUtHRmtaSEpsYzNNcExtUmxiR1YwWlNncENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pnekNpQWdJQ0F2THlCeVpXMXZkbVZOYjJSbGNtRjBiM0lvWVdSa2NtVnpjem9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pwQmEybDBZVk52WTJsaGJFMXZaR1Z5WVhScGIyNHVZbUZ1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ltRnVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk9UQUtJQ0FnSUM4dklHSmhiaWhoWkdSeVpYTnpPaUJCWTJOdmRXNTBMQ0JsZUhCcGNtRjBhVzl1T2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJRzF2WkdWeVlYUnZjbk1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ1FXdHBkR0ZUYjJOcFlXeENiM2hRY21WbWFYaE5iMlJsY21GMGIzSnpJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0prSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZPVEVLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoMGFHbHpMbTF2WkdWeVlYUnZjbk1vVkhodUxuTmxibVJsY2lrdVpYaHBjM1J6TENCbGNuSk9iM1JCVFc5a1pYSmhkRzl5S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklHMXZaR1Z5WVhSdmNuTWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nUVd0cGRHRlRiMk5wWVd4Q2IzaFFjbVZtYVhoTmIyUmxjbUYwYjNKeklIMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qa3hDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvZEdocGN5NXRiMlJsY21GMGIzSnpLRlI0Ymk1elpXNWtaWElwTG1WNGFYTjBjeXdnWlhKeVRtOTBRVTF2WkdWeVlYUnZjaWtLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHSmhibDloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnWW5sMFpXTWdOU0F2THlBaVJWSlNPbVZ5Y2s1dGIyUWlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlUbTF2WkFvS1ltRnVYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TWpBS0lDQWdJQzh2SUdKaGJtNWxaQ0E5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lCQmEybDBZVk52WTJsaGJFSnZlRkJ5WldacGVFSmhibTVsWkNCOUtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWJpSUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZPVElLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENnaGRHaHBjeTVpWVc1dVpXUW9ZV1JrY21WemN5a3VaWGhwYzNSekxDQmxjbkpCYkhKbFlXUjVRbUZ1Ym1Wa0tRb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJpWVc1ZllXWjBaWEpmWVhOelpYSjBRRFVLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVkpTT21WeWNrVmlZVzRpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5UldKaGJnb0tZbUZ1WDJGbWRHVnlYMkZ6YzJWeWRFQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk9UWUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hsZUhCcGNtRjBhVzl1SUQ0Z1IyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ3dnWlhKeVFtRnVSWGh3YVhKbFpDa0tJQ0FnSUdSMWNBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnUGdvZ0lDQWdZbTU2SUdKaGJsOWhablJsY2w5aGMzTmxjblJBTndvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVWxJNlpYSnlRbTU0Y0NJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBsY25KQ2JuaHdDZ3BpWVc1ZllXWjBaWEpmWVhOelpYSjBRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdiVzlrWlhKaGRHOXljeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lCQmEybDBZVk52WTJsaGJFSnZlRkJ5WldacGVFMXZaR1Z5WVhSdmNuTWdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVFpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk9UY0tJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2doZEdocGN5NXRiMlJsY21GMGIzSnpLR0ZrWkhKbGMzTXBMbVY0YVhOMGN5d2daWEp5UTJGdWJtOTBRbUZ1VFc5a1pYSmhkRzl5S1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQmlZVzVmWVdaMFpYSmZZWE56WlhKMFFEa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPbVZ5Y2tKdGIyUWlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlRbTF2WkFvS1ltRnVYMkZtZEdWeVgyRnpjMlZ5ZEVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02T1RnS0lDQWdJQzh2SUhSb2FYTXVZbUZ1Ym1Wa0tHRmtaSEpsYzNNcExuWmhiSFZsSUQwZ1pYaHdhWEpoZEdsdmJnb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk9Ua0tJQ0FnSUM4dklIUm9hWE11Y21WamIzSmtRV04wYVc5dUtFMXZaR1Z5WVhScGIyNUZabVpsWTNSR2IzSjNZWEprS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHTmhiR3h6ZFdJZ2NtVmpiM0prUVdOMGFXOXVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pvNU1Bb2dJQ0FnTHk4Z1ltRnVLR0ZrWkhKbGMzTTZJRUZqWTI5MWJuUXNJR1Y0Y0dseVlYUnBiMjQ2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pwQmEybDBZVk52WTJsaGJFMXZaR1Z5WVhScGIyNHVkVzVpWVc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDFibUpoYmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakV3TWdvZ0lDQWdMeThnZFc1aVlXNG9ZV1JrY21WemN6b2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnYlc5a1pYSmhkRzl5Y3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCMWFXNTBOalErS0hzZ2EyVjVVSEpsWm1sNE9pQkJhMmwwWVZOdlkybGhiRUp2ZUZCeVpXWnBlRTF2WkdWeVlYUnZjbk1nZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem94TURNS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaDBhR2x6TG0xdlpHVnlZWFJ2Y25Nb1ZIaHVMbk5sYm1SbGNpa3VaWGhwYzNSekxDQmxjbkpPYjNSQlRXOWtaWEpoZEc5eUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJRzF2WkdWeVlYUnZjbk1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ1FXdHBkR0ZUYjJOcFlXeENiM2hRY21WbWFYaE5iMlJsY21GMGIzSnpJSDBwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakV3TXdvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtIUm9hWE11Ylc5a1pYSmhkRzl5Y3loVWVHNHVjMlZ1WkdWeUtTNWxlR2x6ZEhNc0lHVnljazV2ZEVGTmIyUmxjbUYwYjNJcENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUIxYm1KaGJsOWhablJsY2w5aGMzTmxjblJBTXdvZ0lDQWdZbmwwWldNZ05TQXZMeUFpUlZKU09tVnljazV0YjJRaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVRtMXZaQW9LZFc1aVlXNWZZV1owWlhKZllYTnpaWEowUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnWW1GdWJtVmtJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJSFZwYm5RMk5ENG9leUJyWlhsUWNtVm1hWGc2SUVGcmFYUmhVMjlqYVdGc1FtOTRVSEpsWm1sNFFtRnVibVZrSUgwcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKdUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFd05Bb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLSFJvYVhNdVltRnVibVZrS0dGa1pISmxjM01wTG1WNGFYTjBjeXdnWlhKeVZYTmxjazV2ZEVKaGJtNWxaQ2tLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklIVnVZbUZ1WDJGbWRHVnlYMkZ6YzJWeWRFQTFDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBsY25KT1ltRnVJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnljazVpWVc0S0NuVnVZbUZ1WDJGbWRHVnlYMkZ6YzJWeWRFQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1UQTFDaUFnSUNBdkx5QjBhR2x6TG1KaGJtNWxaQ2hoWkdSeVpYTnpLUzVrWld4bGRHVW9LUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hNRFlLSUNBZ0lDOHZJSFJvYVhNdWNtVmpiM0prUVdOMGFXOXVLRTF2WkdWeVlYUnBiMjVGWm1abFkzUlNaWFpsY25OaGJDa0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdZMkZzYkhOMVlpQnlaV052Y21SQlkzUnBiMjRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qRXdNZ29nSUNBZ0x5OGdkVzVpWVc0b1lXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qcEJhMmwwWVZOdlkybGhiRTF2WkdWeVlYUnBiMjR1Wm14aFoxQnZjM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbWJHRm5VRzl6ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakV3T1FvZ0lDQWdMeThnWm14aFoxQnZjM1FvY21WbU9pQmllWFJsY3p3ek1qNHBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUcxdlpHVnlZWFJ2Y25NZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dRV3RwZEdGVGIyTnBZV3hDYjNoUWNtVm1hWGhOYjJSbGNtRjBiM0p6SUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRFd0NpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9kR2hwY3k1dGIyUmxjbUYwYjNKektGUjRiaTV6Wlc1a1pYSXBMbVY0YVhOMGN5d2daWEp5VG05MFFVMXZaR1Z5WVhSdmNpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUJ0YjJSbGNtRjBiM0p6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUhWcGJuUTJORDRvZXlCclpYbFFjbVZtYVhnNklFRnJhWFJoVTI5amFXRnNRbTk0VUhKbFptbDRUVzlrWlhKaGRHOXljeUI5S1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaDBhR2x6TG0xdlpHVnlZWFJ2Y25Nb1ZIaHVMbk5sYm1SbGNpa3VaWGhwYzNSekxDQmxjbkpPYjNSQlRXOWtaWEpoZEc5eUtRb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nWm14aFoxQnZjM1JmWVdaMFpYSmZZWE56WlhKMFFETUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lrVlNVanBsY25KT2JXOWtJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnljazV0YjJRS0NtWnNZV2RRYjNOMFgyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNVEV4Q2lBZ0lDQXZMeUIwYUdsekxuSmxZMjl5WkVGamRHbHZiaWgwYUdsekxtRndjR3g1VFc5a1pYSmhkR2x2YmloeVpXWXNJSFJ5ZFdVc0lIUnlkV1VzSURBc0lHWmhiSE5sS1NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2RYQUtJQ0FnSUdOaGJHeHpkV0lnWVhCd2JIbE5iMlJsY21GMGFXOXVDaUFnSUNCallXeHNjM1ZpSUhKbFkyOXlaRUZqZEdsdmJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRBNUNpQWdJQ0F2THlCbWJHRm5VRzl6ZENoeVpXWTZJR0o1ZEdWelBETXlQaWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pwQmEybDBZVk52WTJsaGJFMXZaR1Z5WVhScGIyNHVkVzVtYkdGblVHOXpkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25WdVpteGhaMUJ2YzNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem94TVRRS0lDQWdJQzh2SUhWdVpteGhaMUJ2YzNRb2NtVm1PaUJpZVhSbGN6d3pNajRwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklHMXZaR1Z5WVhSdmNuTWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nUVd0cGRHRlRiMk5wWVd4Q2IzaFFjbVZtYVhoTmIyUmxjbUYwYjNKeklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1URTFDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvZEdocGN5NXRiMlJsY21GMGIzSnpLRlI0Ymk1elpXNWtaWElwTG1WNGFYTjBjeXdnWlhKeVRtOTBRVTF2WkdWeVlYUnZjaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCdGIyUmxjbUYwYjNKeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJRUZyYVhSaFUyOWphV0ZzUW05NFVISmxabWw0VFc5a1pYSmhkRzl5Y3lCOUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveE1UVUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2gwYUdsekxtMXZaR1Z5WVhSdmNuTW9WSGh1TG5ObGJtUmxjaWt1WlhocGMzUnpMQ0JsY25KT2IzUkJUVzlrWlhKaGRHOXlLUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ2RXNW1iR0ZuVUc5emRGOWhablJsY2w5aGMzTmxjblJBTXdvZ0lDQWdZbmwwWldNZ05TQXZMeUFpUlZKU09tVnljazV0YjJRaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVRtMXZaQW9LZFc1bWJHRm5VRzl6ZEY5aFpuUmxjbDloYzNObGNuUkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qRXhOZ29nSUNBZ0x5OGdkR2hwY3k1eVpXTnZjbVJCWTNScGIyNG9kR2hwY3k1aGNIQnNlVTF2WkdWeVlYUnBiMjRvY21WbUxDQjBjblZsTENCbVlXeHpaU3dnTUN3Z1ptRnNjMlVwS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2RYQnVJRElLSUNBZ0lHTmhiR3h6ZFdJZ1lYQndiSGxOYjJSbGNtRjBhVzl1Q2lBZ0lDQmpZV3hzYzNWaUlISmxZMjl5WkVGamRHbHZiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1URTBDaUFnSUNBdkx5QjFibVpzWVdkUWIzTjBLSEpsWmpvZ1lubDBaWE04TXpJK0tUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZPa0ZyYVhSaFUyOWphV0ZzVFc5a1pYSmhkR2x2Ymk1elpYUk5iMlJsY21GMGIzSkRiMjUwWlc1MFJteGhaM05iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUk5iMlJsY21GMGIzSkRiMjUwWlc1MFJteGhaM002Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hNVGtLSUNBZ0lDOHZJSE5sZEUxdlpHVnlZWFJ2Y2tOdmJuUmxiblJHYkdGbmN5aHlaV1k2SUdKNWRHVnpQRE15UGl3Z1pteGhaM002SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdiVzlrWlhKaGRHOXljeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lCQmEybDBZVk52WTJsaGJFSnZlRkJ5WldacGVFMXZaR1Z5WVhSdmNuTWdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hNakFLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoMGFHbHpMbTF2WkdWeVlYUnZjbk1vVkhodUxuTmxibVJsY2lrdVpYaHBjM1J6TENCbGNuSk9iM1JCVFc5a1pYSmhkRzl5S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklHMXZaR1Z5WVhSdmNuTWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nUVd0cGRHRlRiMk5wWVd4Q2IzaFFjbVZtYVhoTmIyUmxjbUYwYjNKeklIMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qRXlNQW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0hSb2FYTXViVzlrWlhKaGRHOXljeWhVZUc0dWMyVnVaR1Z5S1M1bGVHbHpkSE1zSUdWeWNrNXZkRUZOYjJSbGNtRjBiM0lwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQnpaWFJOYjJSbGNtRjBiM0pEYjI1MFpXNTBSbXhoWjNOZllXWjBaWEpmWVhOelpYSjBRRE1LSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJa1ZTVWpwbGNuSk9iVzlrSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2s1dGIyUUtDbk5sZEUxdlpHVnlZWFJ2Y2tOdmJuUmxiblJHYkdGbmMxOWhablJsY2w5aGMzTmxjblJBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakV5TVFvZ0lDQWdMeThnZEdocGN5NXlaV052Y21SQlkzUnBiMjRvZEdocGN5NWhjSEJzZVUxdlpHVnlZWFJwYjI0b2NtVm1MQ0JtWVd4elpTd2dabUZzYzJVc0lHWnNZV2R6TENCMGNuVmxLU2tLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHTmhiR3h6ZFdJZ1lYQndiSGxOYjJSbGNtRjBhVzl1Q2lBZ0lDQmpZV3hzYzNWaUlISmxZMjl5WkVGamRHbHZiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1URTVDaUFnSUNBdkx5QnpaWFJOYjJSbGNtRjBiM0pEYjI1MFpXNTBSbXhoWjNNb2NtVm1PaUJpZVhSbGN6d3pNajRzSUdac1lXZHpPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem82UVd0cGRHRlRiMk5wWVd4TmIyUmxjbUYwYVc5dUxtRmtaRUZqZEdsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZrWkVGamRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qRTJNUW9nSUNBZ0x5OGdZV1JrUVdOMGFXOXVLR0ZqZEdsdmJrRndjRWxFT2lCMWFXNTBOalFzSUdOdmJuUmxiblE2SUVOSlJDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNMlBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRZeUNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVuWlhSQmEybDBZVVJCVDFkaGJHeGxkQ2dwTG1Ga1pISmxjM01zSUdWeWNrNXZkRUZyYVhSaFJHRnZLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pFNUNpQWdJQ0F2THlCamIyNXpkQ0JiZDJGc2JHVjBTVVJkSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFZXbHVkRFkwS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVc0lFSjVkR1Z6S0VGcmFYUmhSRUZQUjJ4dlltRnNVM1JoZEdWTFpYbHpWMkZzYkdWMEtTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TVRZS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1Ua0tJQ0FnSUM4dklHTnZibk4wSUZ0M1lXeHNaWFJKUkYwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaFZhVzUwTmpRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTd2dRbmwwWlhNb1FXdHBkR0ZFUVU5SGJHOWlZV3hUZEdGMFpVdGxlWE5YWVd4c1pYUXBLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luZGhiR3hsZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFMk1nb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WjJWMFFXdHBkR0ZFUVU5WFlXeHNaWFFvS1M1aFpHUnlaWE56TENCbGNuSk9iM1JCYTJsMFlVUmhieWtLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRmtaSEpsYzNNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoY0hCc2FXTmhkR2x2YmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWJub2dZV1JrUVdOMGFXOXVYMkZtZEdWeVgyRnpjMlZ5ZEVBekNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKRlVsSTZaWEp5VG1SaGJ5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSk9aR0Z2Q2dwaFpHUkJZM1JwYjI1ZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hOak1LSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENnaGRHaHBjeTVoWTNScGIyNXpLR0ZqZEdsdmJrRndjRWxFS1M1bGVHbHpkSE1zSUdWeWNrRnNjbVZoWkhsQmJrRmpkR2x2YmlrS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUJoWTNScGIyNXpJRDBnUW05NFRXRndQSFZwYm5RMk5Dd2dRV04wYVc5dVBpaDdJR3RsZVZCeVpXWnBlRG9nUVd0cGRHRlRiMk5wWVd4Q2IzaFFjbVZtYVhoQlkzUnBiMjV6SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW1FaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRZekNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9JWFJvYVhNdVlXTjBhVzl1Y3loaFkzUnBiMjVCY0hCSlJDa3VaWGhwYzNSekxDQmxjbkpCYkhKbFlXUjVRVzVCWTNScGIyNHBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdGa1pFRmpkR2x2Ymw5aFpuUmxjbDloYzNObGNuUkFOUW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdJa1ZTVWpwbGNuSkZZV04wSWdvZ0lDQWdiRzluQ2lBZ0lDQmxjbklnTHk4Z1JWSlNPbVZ5Y2tWaFkzUUtDbUZrWkVGamRHbHZibDloWm5SbGNsOWhjM05sY25SQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFMk5Bb2dJQ0FnTHk4Z2RHaHBjeTVoWTNScGIyNXpLR0ZqZEdsdmJrRndjRWxFS1M1MllXeDFaU0E5SUhzZ1kyOXVkR1Z1ZENCOUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveE5qRUtJQ0FnSUM4dklHRmtaRUZqZEdsdmJpaGhZM1JwYjI1QmNIQkpSRG9nZFdsdWREWTBMQ0JqYjI1MFpXNTBPaUJEU1VRcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6bzZRV3RwZEdGVGIyTnBZV3hOYjJSbGNtRjBhVzl1TG5KbGJXOTJaVUZqZEdsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsYlc5MlpVRmpkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakUyTndvZ0lDQWdMeThnY21WdGIzWmxRV04wYVc5dUtHRmpkR2x2YmtGd2NFbEVPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qRTJPQW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVoyVjBRV3RwZEdGRVFVOVhZV3hzWlhRb0tTNWhaR1J5WlhOekxDQmxjbkpPYjNSQmEybDBZVVJoYnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hPUW9nSUNBZ0x5OGdZMjl1YzNRZ1czZGhiR3hsZEVsRVhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzFkaGJHeGxkQ2twQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qRTJDaUFnSUNBdkx5QmhhMmwwWVVSQlR5QTlJRWRzYjJKaGJGTjBZWFJsUEVGd2NHeHBZMkYwYVc5dVBpaDdJR3RsZVRvZ1IyeHZZbUZzVTNSaGRHVkxaWGxCYTJsMFlVUkJUeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVd0cGRHRmZaR0Z2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakU1Q2lBZ0lDQXZMeUJqYjI1emRDQmJkMkZzYkdWMFNVUmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0VldsdWREWTBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VzSUVKNWRHVnpLRUZyYVhSaFJFRlBSMnh2WW1Gc1UzUmhkR1ZMWlhselYyRnNiR1YwS1NrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ozWVd4c1pYUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hOamdLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxtZGxkRUZyYVhSaFJFRlBWMkZzYkdWMEtDa3VZV1JrY21WemN5d2daWEp5VG05MFFXdHBkR0ZFWVc4cENpQWdJQ0JoY0hCZmNHRnlZVzF6WDJkbGRDQkJjSEJCWkdSeVpYTnpDaUFnSUNCaGMzTmxjblFnTHk4Z1lYQndiR2xqWVhScGIyNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhKbGJXOTJaVUZqZEdsdmJsOWhablJsY2w5aGMzTmxjblJBTXdvZ0lDQWdZbmwwWldOZk15QXZMeUFpUlZKU09tVnljazVrWVc4aUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVRtUmhid29LY21WdGIzWmxRV04wYVc5dVgyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNVFk1Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2RHaHBjeTVoWTNScGIyNXpLR0ZqZEdsdmJrRndjRWxFS1M1bGVHbHpkSE1zSUdWeWNrRnNjbVZoWkhsQmJrRmpkR2x2YmlrS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUJoWTNScGIyNXpJRDBnUW05NFRXRndQSFZwYm5RMk5Dd2dRV04wYVc5dVBpaDdJR3RsZVZCeVpXWnBlRG9nUVd0cGRHRlRiMk5wWVd4Q2IzaFFjbVZtYVhoQlkzUnBiMjV6SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW1FaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRZNUNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9kR2hwY3k1aFkzUnBiMjV6S0dGamRHbHZia0Z3Y0VsRUtTNWxlR2x6ZEhNc0lHVnlja0ZzY21WaFpIbEJia0ZqZEdsdmJpa0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUhKbGJXOTJaVUZqZEdsdmJsOWhablJsY2w5aGMzTmxjblJBTlFvZ0lDQWdZbmwwWldNZ01UQWdMeThnSWtWU1VqcGxjbkpGWVdOMElnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrVmhZM1FLQ25KbGJXOTJaVUZqZEdsdmJsOWhablJsY2w5aGMzTmxjblJBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakUzTUFvZ0lDQWdMeThnZEdocGN5NWhZM1JwYjI1ektHRmpkR2x2YmtGd2NFbEVLUzVrWld4bGRHVW9LUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hOamNLSUNBZ0lDOHZJSEpsYlc5MlpVRmpkR2x2YmloaFkzUnBiMjVCY0hCSlJEb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZPa0ZyYVhSaFUyOWphV0ZzVFc5a1pYSmhkR2x2Ymk1cGMwSmhibTVsWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHpRbUZ1Ym1Wa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRjMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TWpBS0lDQWdJQzh2SUdKaGJtNWxaQ0E5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lCQmEybDBZVk52WTJsaGJFSnZlRkJ5WldacGVFSmhibTVsWkNCOUtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWJpSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveE56Y0tJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbUpoYm01bFpDaGhZMk52ZFc1MEtTNWxlR2x6ZEhNZ0ppWWdkR2hwY3k1aVlXNXVaV1FvWVdOamIzVnVkQ2t1ZG1Gc2RXVWdQaUJIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJR2x6UW1GdWJtVmtYMkp2YjJ4ZlptRnNjMlZBTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdZblJ2YVFvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdQZ29nSUNBZ1lub2dhWE5DWVc1dVpXUmZZbTl2YkY5bVlXeHpaVUEwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LYVhOQ1lXNXVaV1JmWW05dmJGOXRaWEpuWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRjMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHBjMEpoYm01bFpGOWliMjlzWDJaaGJITmxRRFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnBjMEpoYm01bFpGOWliMjlzWDIxbGNtZGxRRFVLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pvNlFXdHBkR0ZUYjJOcFlXeE5iMlJsY21GMGFXOXVMbWx6VFc5a1pYSmhkRzl5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FYTk5iMlJsY21GMGIzSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveE9EQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z2JXOWtaWEpoZEc5eWN5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUJCYTJsMFlWTnZZMmxoYkVKdmVGQnlaV1pwZUUxdlpHVnlZWFJ2Y25NZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltUWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qRTRNZ29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11Ylc5a1pYSmhkRzl5Y3loaFkyTnZkVzUwS1M1bGVHbHpkSE1LSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRnd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZPa0ZyYVhSaFUyOWphV0ZzVFc5a1pYSmhkR2x2Ymk1dGIyUmxjbUYwYjNKTlpYUmhXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYlc5a1pYSmhkRzl5VFdWMFlUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFNE5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCdGIyUmxjbUYwYjNKeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJRUZyYVhSaFUyOWphV0ZzUW05NFVISmxabWw0VFc5a1pYSmhkRzl5Y3lCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveE9EY0tJQ0FnSUM4dklHbG1JQ2gwYUdsekxtMXZaR1Z5WVhSdmNuTW9kWE5sY2lrdVpYaHBjM1J6S1NCN0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJRzF2WkdWeVlYUnZjazFsZEdGZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hPVEFLSUNBZ0lDOHZJR3hoYzNSQlkzUnBkbVU2SUhSb2FYTXViVzlrWlhKaGRHOXljeWgxYzJWeUtTNTJZV3gxWlFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakU0T0MweE9URUtJQ0FnSUM4dklISmxkSFZ5YmlCN0NpQWdJQ0F2THlBZ0lHVjRhWE4wY3pvZ2RISjFaU3dLSUNBZ0lDOHZJQ0FnYkdGemRFRmpkR2wyWlRvZ2RHaHBjeTV0YjJSbGNtRjBiM0p6S0hWelpYSXBMblpoYkhWbENpQWdJQ0F2THlCOUNpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNE1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDZ3B0YjJSbGNtRjBiM0pOWlhSaFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZPa0ZyYVhSaFUyOWphV0ZzVFc5a1pYSmhkR2x2Ymk1dGIyUmxjbUYwYjNKTlpYUmhRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hPRFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXOWtaWEpoZEc5eVRXVjBZVjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFNU13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhzZ1pYaHBjM1J6T2lCbVlXeHpaU3dnYkdGemRFRmpkR2wyWlRvZ01DQjlDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1UZzFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSWdiVzlrWlhKaGRHOXlUV1YwWVY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qcEJhMmwwWVZOdlkybGhiRTF2WkdWeVlYUnBiMjR1Ylc5a1pYSmhkRzl5VFdWMFlVQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02T2tGcmFYUmhVMjlqYVdGc1RXOWtaWEpoZEdsdmJpNXRiMlJsY21GMGIzSkJZM1JwZG1sMGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTF2WkdWeVlYUnZja0ZqZEdsMmFYUjVPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakU1TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFNU9Rb2dJQ0FnTHk4Z1kyOXVjM1FnWlhCdlkyZzZJSFZwYm5RMk5DQTlJRWRzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBZ0x5Qk5iMlJsY21GMGIzSkJZM1JwZG1sMGVVVndiMk5vQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBiblJqSURRZ0x5OGdOakEwT0RBd0NpQWdJQ0F2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdiVzlrWlhKaGRHOXljeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lCQmEybDBZVk52WTJsaGJFSnZlRkJ5WldacGVFMXZaR1Z5WVhSdmNuTWdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbVFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNakF3Q2lBZ0lDQXZMeUJwWmlBb0lYUm9hWE11Ylc5a1pYSmhkRzl5Y3loMWMyVnlLUzVsZUdsemRITXBJSHNLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHMXZaR1Z5WVhSdmNrRmpkR2wyYVhSNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdjRzl3Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakl3TVFvZ0lDQWdMeThnY21WMGRYSnVJSHNnWlhocGMzUnpPaUJtWVd4elpTd2diR0Z6ZEVGamRHbDJaVG9nTUN3Z1pYQnZZMmdzSUdGamRHbHZibk02SURBc0lIQnlaWFpwYjNWelFXTjBhVzl1Y3pvZ01DQjlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENncHRiMlJsY21GMGIzSkJZM1JwZG1sMGVWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPanBCYTJsMFlWTnZZMmxoYkUxdlpHVnlZWFJwYjI0dWJXOWtaWEpoZEc5eVFXTjBhWFpwZEhsQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveE9UY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYlc5a1pYSmhkRzl5UVdOMGFYWnBkSGxmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1qQTBDaUFnSUNBdkx5QnNaWFFnWVdOMGFXOXVjem9nZFdsdWREWTBJRDBnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjFjbmtnTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNakExQ2lBZ0lDQXZMeUJzWlhRZ2NISmxkbWx2ZFhOQlkzUnBiMjV6T2lCMWFXNTBOalFnUFNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZblZ5ZVNBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnWVdOMGFYWnBkSGtnUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnVFc5a1pYSmhkRzl5UVdOMGFYWnBkSGsrS0hzZ2EyVjVVSEpsWm1sNE9pQkJhMmwwWVZOdlkybGhiRUp2ZUZCeVpXWnBlRTF2WkdWeVlYUnZja0ZqZEdsMmFYUjVJSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pySWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0EzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3lNRFlLSUNBZ0lDOHZJR2xtSUNoMGFHbHpMbUZqZEdsMmFYUjVLSFZ6WlhJcExtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJ0YjJSbGNtRjBiM0pCWTNScGRtbDBlVjloWm5SbGNsOXBabDlsYkhObFFERXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveU1EY0tJQ0FnSUM4dklHTnZibk4wSUhKbFkyOXlaQ0E5SUdOc2IyNWxLSFJvYVhNdVlXTjBhWFpwZEhrb2RYTmxjaWt1ZG1Gc2RXVXBDaUFnSUNCa2FXY2dOUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpZFhKNUlEY0tJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem95TURnS0lDQWdJQzh2SUdsbUlDaHlaV052Y21RdVpYQnZZMmdnUFQwOUlHVndiMk5vS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURNS0lDQWdJRDA5Q2lBZ0lDQmllaUJ0YjJSbGNtRjBiM0pCWTNScGRtbDBlVjlsYkhObFgySnZaSGxBTmdvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3lNRGtLSUNBZ0lDOHZJR0ZqZEdsdmJuTWdQU0J5WldOdmNtUXVZV04wYVc5dWN3b2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JpZFhKNUlEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pJeE1Bb2dJQ0FnTHk4Z2NISmxkbWx2ZFhOQlkzUnBiMjV6SUQwZ2NtVmpiM0prTG5CeVpYWnBiM1Z6UVdOMGFXOXVjd29nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdKMWNua2dNd29LYlc5a1pYSmhkRzl5UVdOMGFYWnBkSGxmWVdaMFpYSmZhV1pmWld4elpVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qSXhOUW9nSUNBZ0x5OGdjbVYwZFhKdUlIc2daWGhwYzNSek9pQjBjblZsTENCc1lYTjBRV04wYVhabE9pQjBhR2x6TG0xdlpHVnlZWFJ2Y25Nb2RYTmxjaWt1ZG1Gc2RXVXNJR1Z3YjJOb0xDQmhZM1JwYjI1ekxDQndjbVYyYVc5MWMwRmpkR2x2Ym5NZ2ZRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdKMGIya0tJQ0FnSUdsMGIySUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3dDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1UazNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSWdiVzlrWlhKaGRHOXlRV04wYVhacGRIbGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem82UVd0cGRHRlRiMk5wWVd4TmIyUmxjbUYwYVc5dUxtMXZaR1Z5WVhSdmNrRmpkR2wyYVhSNVFERXhDZ3B0YjJSbGNtRjBiM0pCWTNScGRtbDBlVjlsYkhObFgySnZaSGxBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakl4TVFvZ0lDQWdMeThnZlNCbGJITmxJR2xtSUNoeVpXTnZjbVF1WlhCdlkyZ2dLeUF4SUQwOVBTQmxjRzlqYUNrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lub2diVzlrWlhKaGRHOXlRV04wYVhacGRIbGZZV1owWlhKZmFXWmZaV3h6WlVBeE1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TWpFeUNpQWdJQ0F2THlCd2NtVjJhVzkxYzBGamRHbHZibk1nUFNCeVpXTnZjbVF1WVdOMGFXOXVjd29nSUNBZ1pHbG5JRFFLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1luVnllU0F6Q2lBZ0lDQmlJRzF2WkdWeVlYUnZja0ZqZEdsMmFYUjVYMkZtZEdWeVgybG1YMlZzYzJWQU1UQUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02T2xWd1ozSmhaR1ZoWW14bFFXdHBkR0ZDWVhObFEyOXVkSEpoWTNRdWRYQmtZWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPak0xQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUJiSjFWd1pHRjBaVUZ3Y0d4cFkyRjBhVzl1SjEwZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qTTNDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1blpYUkJhMmwwWVVSQlQxZGhiR3hsZENncExtRmtaSEpsYzNNc0lHVnljazV2ZEVGcmFYUmhSR0Z2S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qRTVDaUFnSUNBdkx5QmpiMjV6ZENCYmQyRnNiR1YwU1VSZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRWV2x1ZERZMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6VjJGc2JHVjBLU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk1UWUtJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12ZFhCbmNtRmtaV0ZpYkdVdWRITTZNVGtLSUNBZ0lDOHZJR052Ym5OMElGdDNZV3hzWlhSSlJGMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhWYVc1ME5qUW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU3dnUW5sMFpYTW9RV3RwZEdGRVFVOUhiRzlpWVd4VGRHRjBaVXRsZVhOWFlXeHNaWFFwS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbmRoYkd4bGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3pOd29nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVoyVjBRV3RwZEdGRVFVOVhZV3hzWlhRb0tTNWhaR1J5WlhOekxDQmxjbkpPYjNSQmEybDBZVVJoYnlrS0lDQWdJR0Z3Y0Y5d1lYSmhiWE5mWjJWMElFRndjRUZrWkhKbGMzTUtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nZFhCa1lYUmxYMkZtZEdWeVgyRnpjMlZ5ZEVBekNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKRlVsSTZaWEp5VG1SaGJ5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSk9aR0Z2Q2dwMWNHUmhkR1ZmWVdaMFpYSmZZWE56WlhKMFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZkWEJuY21Ga1pXRmliR1V1ZEhNNk16Z0tJQ0FnSUM4dklHTnZibk4wSUZ0d2JIVm5hVzV6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVc0lFSjVkR1Z6S0VGcmFYUmhSRUZQUjJ4dlltRnNVM1JoZEdWTFpYbHpVR3gxWjJsdVFYQndUR2x6ZENrcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakUyQ2lBZ0lDQXZMeUJoYTJsMFlVUkJUeUE5SUVkc2IySmhiRk4wWVhSbFBFRndjR3hwWTJGMGFXOXVQaWg3SUd0bGVUb2dSMnh2WW1Gc1UzUmhkR1ZMWlhsQmEybDBZVVJCVHlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXdHBkR0ZmWkdGdklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pNNENpQWdJQ0F2THlCamIyNXpkQ0JiY0d4MVoybHVjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWgwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsTENCQ2VYUmxjeWhCYTJsMFlVUkJUMGRzYjJKaGJGTjBZWFJsUzJWNWMxQnNkV2RwYmtGd2NFeHBjM1FwS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lIQjFjMmhpZVhSbGN5QWljR0ZzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pNNUNpQWdJQ0F2THlCamIyNXpkQ0IxY0dSaGRHVlFiSFZuYVc0Z1BTQmtaV052WkdWQmNtTTBQRkJzZFdkcGJrRndjRXhwYzNRK0tIQnNkV2RwYm5NcExuVndaR0YwWlFvZ0lDQWdjSFZ6YUdsdWRDQXhOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6bzBNQW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0Vkc2IySmhiQzVqWVd4c1pYSkJjSEJzYVdOaGRHbHZia2xrSUQwOVBTQjFjR1JoZEdWUWJIVm5hVzRzSUdWeWNrbHVkbUZzYVdSVmNHZHlZV1JsS1FvZ0lDQWdaMnh2WW1Gc0lFTmhiR3hsY2tGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2RYQmtZWFJsWDJGbWRHVnlYMkZ6YzJWeWRFQTFDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBsY25KSmRYQm5JZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnlja2wxY0djS0NuVndaR0YwWlY5aFpuUmxjbDloYzNObGNuUkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hOQW9nSUNBZ0x5OGdkbVZ5YzJsdmJpQTlJRWRzYjJKaGJGTjBZWFJsUEhOMGNtbHVaejRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVZtVnljMmx2YmlCOUtRb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRtVnljMmx2YmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem8wTVFvZ0lDQWdMeThnZEdocGN5NTJaWEp6YVc5dUxuWmhiSFZsSUQwZ2JtVjNWbVZ5YzJsdmJnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OTFjR2R5WVdSbFlXSnNaUzUwY3pvek5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5ZFZjR1JoZEdWQmNIQnNhV05oZEdsdmJpZGRJSDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMM1Z3WjNKaFpHVmhZbXhsTG5Sek9qcEJhMmwwWVVKaGMyVkRiMjUwY21GamRDNTFjR1JoZEdWQmEybDBZVVJCVDF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVndaR0YwWlVGcmFYUmhSRUZQT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakkxQ2lBZ0lDQXZMeUIxY0dSaGRHVkJhMmwwWVVSQlR5aGhhMmwwWVVSQlR6b2dRWEJ3YkdsallYUnBiMjRwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem95TmdvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVaMlYwUVd0cGRHRkVRVTlYWVd4c1pYUW9LUzVoWkdSeVpYTnpMQ0JsY25KT2IzUkJhMmwwWVVSaGJ5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem94T1FvZ0lDQWdMeThnWTI5dWMzUWdXM2RoYkd4bGRFbEVYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUZWcGJuUTJOQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsTENCQ2VYUmxjeWhCYTJsMFlVUkJUMGRzYjJKaGJGTjBZWFJsUzJWNWMxZGhiR3hsZENrcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDNWd1ozSmhaR1ZoWW14bExuUnpPakUyQ2lBZ0lDQXZMeUJoYTJsMFlVUkJUeUE5SUVkc2IySmhiRk4wWVhSbFBFRndjR3hwWTJGMGFXOXVQaWg3SUd0bGVUb2dSMnh2WW1Gc1UzUmhkR1ZMWlhsQmEybDBZVVJCVHlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXdHBkR0ZmWkdGdklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pFNUNpQWdJQ0F2THlCamIyNXpkQ0JiZDJGc2JHVjBTVVJkSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFZXbHVkRFkwS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVc0lFSjVkR1Z6S0VGcmFYUmhSRUZQUjJ4dlltRnNVM1JoZEdWTFpYbHpWMkZzYkdWMEtTa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKM1lXeHNaWFFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TWpZS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbWRsZEVGcmFYUmhSRUZQVjJGc2JHVjBLQ2t1WVdSa2NtVnpjeXdnWlhKeVRtOTBRV3RwZEdGRVlXOHBDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCQlpHUnlaWE56Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3YkdsallYUnBiMjRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW01NklIVndaR0YwWlVGcmFYUmhSRUZQWDJGbWRHVnlYMkZ6YzJWeWRFQXpDaUFnSUNCaWVYUmxZMTh6SUM4dklDSkZVbEk2WlhKeVRtUmhieUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGxjbkpPWkdGdkNncDFjR1JoZEdWQmEybDBZVVJCVDE5aFpuUmxjbDloYzNObGNuUkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTkxY0dkeVlXUmxZV0pzWlM1MGN6b3hOZ29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5MWNHZHlZV1JsWVdKc1pTNTBjem95TndvZ0lDQWdMeThnZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNBOUlHRnJhWFJoUkVGUENpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwzVndaM0poWkdWaFlteGxMblJ6T2pJMUNpQWdJQ0F2THlCMWNHUmhkR1ZCYTJsMFlVUkJUeWhoYTJsMFlVUkJUem9nUVhCd2JHbGpZWFJwYjI0cE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6bzZRV3RwZEdGVGIyTnBZV3hOYjJSbGNtRjBhVzl1TG5KbFkyOXlaRUZqZEdsdmJpaGxabVpsWTNRNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS2NtVmpiM0prUVdOMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklIQnlhWFpoZEdVZ2NtVmpiM0prUVdOMGFXOXVLR1ZtWm1WamREb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUdOdmJuTjBJRzV2ZHlBOUlFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklHMXZaR1Z5WVhSdmNuTWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nUVd0cGRHRlRiMk5wWVd4Q2IzaFFjbVZtYVhoTmIyUmxjbUYwYjNKeklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk5ERUtJQ0FnSUM4dklIUm9hWE11Ylc5a1pYSmhkRzl5Y3loVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlHNXZkd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUcxdlpHVnlZWFJ2Y25NZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dRV3RwZEdGVGIyTnBZV3hDYjNoUWNtVm1hWGhOYjJSbGNtRjBiM0p6SUgwcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCMGFHbHpMbTF2WkdWeVlYUnZjbk1vVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCdWIzY0tJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QnBaaUFvWldabVpXTjBJRDA5UFNCTmIyUmxjbUYwYVc5dVJXWm1aV04wVG05dVpTa2dld29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWJub2djbVZqYjNKa1FXTjBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklISmxkSFZ5YmdvZ0lDQWdjbVYwYzNWaUNncHlaV052Y21SQlkzUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklHTnZibk4wSUdWd2IyTm9PaUIxYVc1ME5qUWdQU0J1YjNjZ0x5Qk5iMlJsY21GMGIzSkJZM1JwZG1sMGVVVndiMk5vQ2lBZ0lDQnBiblJqSURRZ0x5OGdOakEwT0RBd0NpQWdJQ0F2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdiR1YwSUdGamRHbHZibk02SUhWcGJuUTJOQ0E5SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QnNaWFFnY0hKbGRtbHZkWE5CWTNScGIyNXpPaUIxYVc1ME5qUWdQU0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z1lXTjBhWFpwZEhrZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1RXOWtaWEpoZEc5eVFXTjBhWFpwZEhrK0tIc2dhMlY1VUhKbFptbDRPaUJCYTJsMFlWTnZZMmxoYkVKdmVGQnlaV1pwZUUxdlpHVnlZWFJ2Y2tGamRHbDJhWFI1SUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKcklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUdsbUlDaDBhR2x6TG1GamRHbDJhWFI1S0ZSNGJpNXpaVzVrWlhJcExtVjRhWE4wY3lrZ2V3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNamdLSUNBZ0lDOHZJR0ZqZEdsMmFYUjVJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRTF2WkdWeVlYUnZja0ZqZEdsMmFYUjVQaWg3SUd0bGVWQnlaV1pwZURvZ1FXdHBkR0ZUYjJOcFlXeENiM2hRY21WbWFYaE5iMlJsY21GMGIzSkJZM1JwZG1sMGVTQjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdhV1lnS0hSb2FYTXVZV04wYVhacGRIa29WSGh1TG5ObGJtUmxjaWt1WlhocGMzUnpLU0I3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklISmxZMjl5WkVGamRHbHZibDloWm5SbGNsOXBabDlsYkhObFFEa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCaFkzUnBkbWwwZVNBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCTmIyUmxjbUYwYjNKQlkzUnBkbWwwZVQ0b2V5QnJaWGxRY21WbWFYZzZJRUZyYVhSaFUyOWphV0ZzUW05NFVISmxabWw0VFc5a1pYSmhkRzl5UVdOMGFYWnBkSGtnZlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1zaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnWTI5dWMzUWdiR0Z6ZENBOUlHTnNiMjVsS0hSb2FYTXVZV04wYVhacGRIa29WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnWVdOMGFYWnBkSGtnUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnVFc5a1pYSmhkRzl5UVdOMGFYWnBkSGsrS0hzZ2EyVjVVSEpsWm1sNE9pQkJhMmwwWVZOdlkybGhiRUp2ZUZCeVpXWnBlRTF2WkdWeVlYUnZja0ZqZEdsMmFYUjVJSDBwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUJqYjI1emRDQnNZWE4wSUQwZ1kyeHZibVVvZEdocGN5NWhZM1JwZG1sMGVTaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklHbG1JQ2hzWVhOMExtVndiMk5vSUQwOVBTQmxjRzlqYUNrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E5UFFvZ0lDQWdZbm9nY21WamIzSmtRV04wYVc5dVgyVnNjMlZmWW05a2VVQTFDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCaFkzUnBiMjV6SUQwZ2JHRnpkQzVoWTNScGIyNXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSEJ5WlhacGIzVnpRV04wYVc5dWN5QTlJR3hoYzNRdWNISmxkbWx2ZFhOQlkzUnBiMjV6Q2lBZ0lDQndkWE5vYVc1MElERTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDZ3B5WldOdmNtUkJZM1JwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZOVGdLSUNBZ0lDOHZJR2xtSUNobFptWmxZM1FnUFQwOUlFMXZaR1Z5WVhScGIyNUZabVpsWTNSR2IzSjNZWEprS1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lub2djbVZqYjNKa1FXTjBhVzl1WDJWc2MyVmZZbTlrZVVBeE1Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TlRrS0lDQWdJQzh2SUdGamRHbHZibk1nS3owZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtDbkpsWTI5eVpFRmpkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRREUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJSFJvYVhNdVlXTjBhWFpwZEhrb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQjdJR1Z3YjJOb0xDQmhZM1JwYjI1ekxDQndjbVYyYVc5MWMwRmpkR2x2Ym5NZ2ZRb2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUdGamRHbDJhWFI1SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUUxdlpHVnlZWFJ2Y2tGamRHbDJhWFI1UGloN0lHdGxlVkJ5WldacGVEb2dRV3RwZEdGVGIyTnBZV3hDYjNoUWNtVm1hWGhOYjJSbGNtRjBiM0pCWTNScGRtbDBlU0I5S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYXlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUIwYUdsekxtRmpkR2wyYVhSNUtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdleUJsY0c5amFDd2dZV04wYVc5dWN5d2djSEpsZG1sdmRYTkJZM1JwYjI1eklIMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJoWTNScGRtbDBlU0E5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0JOYjJSbGNtRjBiM0pCWTNScGRtbDBlVDRvZXlCclpYbFFjbVZtYVhnNklFRnJhWFJoVTI5amFXRnNRbTk0VUhKbFptbDRUVzlrWlhKaGRHOXlRV04wYVhacGRIa2dmU2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJSFJvYVhNdVlXTjBhWFpwZEhrb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQjdJR1Z3YjJOb0xDQmhZM1JwYjI1ekxDQndjbVYyYVc5MWMwRmpkR2x2Ym5NZ2ZRb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dweVpXTnZjbVJCWTNScGIyNWZaV3h6WlY5aWIyUjVRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZOakFLSUNBZ0lDOHZJSDBnWld4elpTQnBaaUFvWVdOMGFXOXVjeUErSURBcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JpZWlCeVpXTnZjbVJCWTNScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBeE5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TmpFS0lDQWdJQzh2SUdGamRHbHZibk1nTFQwZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdJZ2NtVmpiM0prUVdOMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU1UUUtDbkpsWTI5eVpFRmpkR2x2Ymw5bGJITmxYMkp2WkhsQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCOUlHVnNjMlVnYVdZZ0tHeGhjM1F1WlhCdlkyZ2dLeUF4SUQwOVBTQmxjRzlqYUNrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lub2djbVZqYjNKa1FXTjBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFPUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklIQnlaWFpwYjNWelFXTjBhVzl1Y3lBOUlHeGhjM1F1WVdOMGFXOXVjd29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0JpSUhKbFkyOXlaRUZqZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURrS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6bzZRV3RwZEdGVGIyTnBZV3hOYjJSbGNtRjBhVzl1TG1Gd2NHeDVUVzlrWlhKaGRHbHZiaWh5WldZNklHSjVkR1Z6TENCMWNHUmhkR1ZHYkdGbloyVmtPaUIxYVc1ME5qUXNJR1pzWVdkblpXUldZV3gxWlRvZ2RXbHVkRFkwTENCbWJHRm5jMVpoYkhWbE9pQjFhVzUwTmpRc0lIVndaR0YwWlVac1lXZHpPaUIxYVc1ME5qUXBJQzArSUhWcGJuUTJORG9LWVhCd2JIbE5iMlJsY21GMGFXOXVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1UTXhMVEV6TndvZ0lDQWdMeThnY0hKcGRtRjBaU0JoY0hCc2VVMXZaR1Z5WVhScGIyNG9DaUFnSUNBdkx5QWdJSEpsWmpvZ1lubDBaWE04TXpJK0xBb2dJQ0FnTHk4Z0lDQjFjR1JoZEdWR2JHRm5aMlZrT2lCaWIyOXNaV0Z1TEFvZ0lDQWdMeThnSUNCbWJHRm5aMlZrVm1Gc2RXVTZJR0p2YjJ4bFlXNHNDaUFnSUNBdkx5QWdJR1pzWVdkelZtRnNkV1U2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnZFhCa1lYUmxSbXhoWjNNNklHSnZiMnhsWVc0c0NpQWdJQ0F2THlBcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnY0hKdmRHOGdOU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hNemdLSUNBZ0lDOHZJR052Ym5OMElIc2djMjlqYVdGc0lIMGdQU0JuWlhSQmEybDBZVk52WTJsaGJFRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdmRYQm5jbUZrWldGaWJHVXVkSE02TVRZS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveE16Z0tJQ0FnSUM4dklHTnZibk4wSUhzZ2MyOWphV0ZzSUgwZ1BTQm5aWFJCYTJsMFlWTnZZMmxoYkVGd2NFeHBjM1FvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlNrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPakl4TVFvZ0lDQWdMeThnWTI5dWMzUWdXMkZ3Y0V4cGMzUkNlWFJsYzEwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3loaGEybDBZVVJCVHl3Z1FubDBaWE1vUVd0cGRHRkVRVTlIYkc5aVlXeFRkR0YwWlV0bGVYTkJhMmwwWVZOdlkybGhiRUZ3Y0V4cGMzUXBLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSnpZV3dpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem94TXpnS0lDQWdJQzh2SUdOdmJuTjBJSHNnYzI5amFXRnNJSDBnUFNCblpYUkJhMmwwWVZOdlkybGhiRUZ3Y0V4cGMzUW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveE16a3RNVFF5Q2lBZ0lDQXZMeUJqYjI1emRDQndiM04wSUQwZ1lXSnBRMkZzYkR4MGVYQmxiMllnUVd0cGRHRlRiMk5wWVd3dWNISnZkRzkwZVhCbExtZGxkRkJ2YzNRK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklITnZZMmxoYkN3S0lDQWdJQzh2SUNBZ1lYSm5jem9nVzNKbFpsMEtJQ0FnSUM4dklIMHBMbkpsZEhWeWJsWmhiSFZsQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGs0WWpneFpqYzRJQzh2SUcxbGRHaHZaQ0FpWjJWMFVHOXpkQ2hpZVhSbFd6TXlYU2tvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExHSnZiMndzZFdsdWREWTBMR0p2YjJ3c2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RMk5DeGllWFJsVzEwcElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBJREFnTkFvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFSjVkR1Z6SUdoaGN5QjJZV3hwWkNCd2NtVm1hWGdLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBM05Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EzTndvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0E1SUc5bUlDaDFhVzUwT0Zzek1sMHNkV2x1ZERZMExIVnBiblEyTkN4aWIyOXNNU3gxYVc1ME5qUXNZbTl2YkRFc2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RMk5Dd29iR1Z1SzNWcGJuUTRXMTBwS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ056a0tJQ0FnSUNzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmRIbHdaWE11ZEhNNk9sQnZjM1JXWVd4MVpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRRMENpQWdJQ0F2THlCamIyNXpkQ0J1WlhoMFJteGhaMmRsWkRvZ1ltOXZiR1ZoYmlBOUlIVndaR0YwWlVac1lXZG5aV1FnUHlCbWJHRm5aMlZrVm1Gc2RXVWdPaUJ3YjNOMExtRm5ZV2x1YzNSRGIyNTBaVzUwVUc5c2FXTjVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdKNklHRndjR3g1VFc5a1pYSmhkR2x2Ymw5MFpYSnVZWEo1WDJaaGJITmxRRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29LWVhCd2JIbE5iMlJsY21GMGFXOXVYM1JsY201aGNubGZiV1Z5WjJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFME5Rb2dJQ0FnTHk4Z1kyOXVjM1FnYm1WNGRFWnNZV2R6T2lCMWFXNTBOalFnUFNCMWNHUmhkR1ZHYkdGbmN5QS9JR1pzWVdkelZtRnNkV1VnT2lCd2IzTjBMbTF2WkdWeVlYUnZja1pzWVdkekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o2SUdGd2NHeDVUVzlrWlhKaGRHbHZibDkwWlhKdVlYSjVYMlpoYkhObFFEWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb0tZWEJ3YkhsTmIyUmxjbUYwYVc5dVgzUmxjbTVoY25sZmJXVnlaMlZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakUwTnkweE5UQUtJQ0FnSUM4dklHRmlhVU5oYkd3OGRIbHdaVzltSUVGcmFYUmhVMjlqYVdGc0xuQnliM1J2ZEhsd1pTNXpaWFJRYjNOMFRXOWtaWEpoZEdsdmJqNG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2djMjlqYVdGc0xBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYmNtVm1MQ0J1WlhoMFJteGhaMmRsWkN3Z2JtVjRkRVpzWVdkelhRb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakUwT1FvZ0lDQWdMeThnWVhKbmN6b2dXM0psWml3Z2JtVjRkRVpzWVdkblpXUXNJRzVsZUhSR2JHRm5jMTBLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem94TkRjdE1UVXdDaUFnSUNBdkx5QmhZbWxEWVd4c1BIUjVjR1Z2WmlCQmEybDBZVk52WTJsaGJDNXdjbTkwYjNSNWNHVXVjMlYwVUc5emRFMXZaR1Z5WVhScGIyNCtLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJSE52WTJsaGJDd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1czSmxaaXdnYm1WNGRFWnNZV2RuWldRc0lHNWxlSFJHYkdGbmMxMEtJQ0FnSUM4dklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzFNVEJsWkdWaU5pQXZMeUJ0WlhSb2IyUWdJbk5sZEZCdmMzUk5iMlJsY21GMGFXOXVLR0o1ZEdWYk16SmRMR0p2YjJ3c2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNVFV5Q2lBZ0lDQXZMeUJwWmlBb2RYQmtZWFJsUm14aFoyZGxaQ0FtSmlCdVpYaDBSbXhoWjJkbFpDQWhQVDBnY0c5emRDNWhaMkZwYm5OMFEyOXVkR1Z1ZEZCdmJHbGplU2tnZXdvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmllaUJoY0hCc2VVMXZaR1Z5WVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Rb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJSEIxYzJocGJuUWdORFUyQ2lBZ0lDQm5aWFJpYVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0FoUFFvZ0lDQWdZbm9nWVhCd2JIbE5iMlJsY21GMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU1URUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRVekNpQWdJQ0F2THlCeVpYUjFjbTRnYm1WNGRFWnNZV2RuWldRZ1B5Qk5iMlJsY21GMGFXOXVSV1ptWldOMFJtOXlkMkZ5WkNBNklFMXZaR1Z5WVhScGIyNUZabVpsWTNSU1pYWmxjbk5oYkFvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncGhjSEJzZVUxdlpHVnlZWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TVRvS0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRVMUNpQWdJQ0F2THlCcFppQW9kWEJrWVhSbFJteGhaM01nSmlZZ0tHNWxlSFJHYkdGbmN5QTlQVDBnTUNrZ0lUMDlJQ2h3YjNOMExtMXZaR1Z5WVhSdmNrWnNZV2R6SUQwOVBTQXdLU2tnZXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllaUJoY0hCc2VVMXZaR1Z5WVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBeE5Bb2dJQ0FnWkhWd0NpQWdJQ0FoQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBM01Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUNFS0lDQWdJQ0U5Q2lBZ0lDQmllaUJoY0hCc2VVMXZaR1Z5WVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBeE5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRVMkNpQWdJQ0F2THlCeVpYUjFjbTRnYm1WNGRFWnNZV2R6SUNFOVBTQXdJRDhnVFc5a1pYSmhkR2x2YmtWbVptVmpkRVp2Y25kaGNtUWdPaUJOYjJSbGNtRjBhVzl1UldabVpXTjBVbVYyWlhKellXd0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWVhCd2JIbE5iMlJsY21GMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU1UUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveE5UZ0tJQ0FnSUM4dklISmxkSFZ5YmlCTmIyUmxjbUYwYVc5dVJXWm1aV04wVG05dVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncGhjSEJzZVUxdlpHVnlZWFJwYjI1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNVFExQ2lBZ0lDQXZMeUJqYjI1emRDQnVaWGgwUm14aFozTTZJSFZwYm5RMk5DQTlJSFZ3WkdGMFpVWnNZV2R6SUQ4Z1pteGhaM05XWVd4MVpTQTZJSEJ2YzNRdWJXOWtaWEpoZEc5eVJteGhaM01LSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURjeENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWWlCaGNIQnNlVTF2WkdWeVlYUnBiMjVmZEdWeWJtRnllVjl0WlhKblpVQTNDZ3BoY0hCc2VVMXZaR1Z5WVhScGIyNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRRMENpQWdJQ0F2THlCamIyNXpkQ0J1WlhoMFJteGhaMmRsWkRvZ1ltOXZiR1ZoYmlBOUlIVndaR0YwWlVac1lXZG5aV1FnUHlCbWJHRm5aMlZrVm1Gc2RXVWdPaUJ3YjNOMExtRm5ZV2x1YzNSRGIyNTBaVzUwVUc5c2FXTjVDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0EwTlRZS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWWlCaGNIQnNlVTF2WkdWeVlYUnBiMjVmZEdWeWJtRnllVjl0WlhKblpVQTBDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRkFBRUlJSUQxSkNZTUFXUUpZV3RwZEdGZlpHRnZCbmRoYkd4bGRBdEZVbEk2WlhKeVRtUmhid0ZyQzBWU1VqcGxjbkpPYlc5a0JCVWZmSFVCYmdFQUIzWmxjbk5wYjI0TFJWSlNPbVZ5Y2tWaFkzUUpBQUFBQUFBQUFBQUFnQVRxa1lEZE5ob0FqZ0VBaWpFWkZFUXhHRUVBYzRJUEJNelp1Tk1FQStPcklnUjZnenRBQktEU01oMEVZZHpTN3dSNVlPcDJCUHYwM1RVRTJtcmMyUVR4U1N2MEJJUW1uSGdFY1M3b0l3UWZQR0dNQk9FNDV1MEVNK2tzbEFTRlRlM2dOaG9Bamc4QVFRQ0RBTGNCS2dGakFZVUJwd0hVQWc4Q1FBSnZBb29Dc2dPUUFBRUFJME9BQk0yYTFuNDJHZ0NPQVFBTkFERVpnUVFTTVJnUVJFSURKallhQVVraVdZRUNDRXNCRlJKRVZ3SUFOaG9DU1JVa0VrUVhKd2xQQW1jcFRHY2pRellhQVVrVkpSSkVNUUFpS1dWRUttVkljZ2hFRWtBQUF5dXdBQ2hMQVZCSnZVVUJRUUFQZ0F0RlVsSTZaWEp5UlcxdlpMQUFKTGxJSndSTVVJRVl1VWdqUXpZYUFVa1ZKUkpFTVFBaUtXVkVLbVZJY2doRUVrQUFBeXV3QUNoTEFWQkp2VVVCUUFBRUp3V3dBTHhJSndSTVVMeElJME0yR2dGSkZTVVNSRFlhQWtrVkpCSkVGeWd4QUZDOVJRRkFBQVFuQmJBQUp3ZExBbEJKVGdPOVJRRkJBQStBQzBWU1VqcGxjbkpGWW1GdXNBQkpNZ2NOUUFBUGdBdEZVbEk2WlhKeVFtNTRjTEFBS0U4Q1VMMUZBVUVBRDRBTFJWSlNPbVZ5Y2tKdGIyU3dBQmEvSTRnQ2lTTkROaG9CU1JVbEVrUW9NUUJRdlVVQlFBQUVKd1d3QUNjSFRGQkp2VVVCUUFBUGdBdEZVbEk2WlhKeVRtSmhickFBdkVpQkFvZ0NVQ05ETmhvQlNSVWxFa1FvTVFCUXZVVUJRQUFFSndXd0FDTkpJa21JQXJ5SUFpNGpRellhQVVrVkpSSkVLREVBVUwxRkFVQUFCQ2NGc0FBaklrY0NpQUthaUFJTUkwTTJHZ0ZKRlNVU1JEWWFBa2tWSkJKRUZ5Z3hBRkM5UlFGQUFBUW5CYkFBVENKSlR3TWppQUp0aUFIZkkwTTJHZ0ZKRlNRU1JCYzJHZ0pKRllFa0VrUXhBQ0lwWlVRcVpVaHlDRVFTUUFBREs3QUFUQmFBQVdGTVVFbTlSUUZCQUFRbkNyQUFUTDhqUXpZYUFVa1ZKQkpFRnpFQUlpbGxSQ3BsU0hJSVJCSkFBQU1yc0FBV2dBRmhURkJKdlVVQlFBQUVKd3F3QUx4SUkwTTJHZ0ZKRlNVU1JDY0hURkJKdlVVQlFRQVlTYjVFRnpJSERVRUFEaU1uQ0NKUEFsUW5Ca3hRc0NORElrTC83ellhQVVrVkpSSkVLRXhRdlVVQkp3Z2lUd0pVSndaTVVMQWpRellhQVVrVkpSSkVLRXhRU2IxRkFVRUFFTDVFRnhhQUFZQk1VQ2NHVEZDd0kwTklKd3RDLy9NaVNZQUFTVFlhQVVjQ0ZTVVNSRElISVFRS1RDaE1VRW05UlFGQUFCZElSUUVpRmt3V0p3dE1VRXNCVUV4UUp3Wk1VTEFqUXlKRkJTSkZCQ2NFVHdOUVNVVUh2VVVCUVFBZ1N3VytURWxPQWtVSFJDSmJTVXNERWtFQUpFaExCRWtrVzBVRmdSQmJSUU8rUkJjV2dBR0FURkJNRmxCTEFoWlFTd0VXVUVML3JpTUlTd0lTUWYvaFN3UWtXMFVEUXYvWU5ob0JTU0paZ1FJSVN3RVZFa1JYQWdBeEFDSXBaVVFxWlVoeUNFUVNRQUFESzdBQUlpbGxSSUFEY0dGc1pVaUJFRnN5RFJKQUFBK0FDMFZTVWpwbGNuSkpkWEJuc0FBbkNVeG5JME0yR2dGSkZTUVNSQmN4QUNJcFpVUXFaVWh5Q0VRU1FBQURLN0FBS1V4bkkwT0tBUUFpZ0FCSk1nZEpLREVBVUV3V3Y0di9RQUFCaVNFRUNpS01BU0tNQWljRU1RQlF2VVVCUVFBakp3UXhBRkMrVEVsT0Fvd0FSQ0piU1VzQ0VrRUFPVWlMQUVra1c0d0JnUkJiakFLTC95TVNRUUFYaXdFakNJd0JGb3NCRmxDTEFoWlFKd1F4QUZCTXY0bUxBVUgvNm9zQkl3bU1BVUwvNFNNSVN3RVNRZi9NaXdBa1c0d0NRdi9EaWdVQklpbGxSSUFEYzJGc1pVZ2lXMG14c2hpQUJKaTRIM2l5R292N3NocUJCcklRSXJJQnM3UStSd0pYQkFCSlR3SlhBQVFuQmhKRVNSVkxBWUZMV1VtQlRSSkVUd0pNU3dKU0lsbUJUd2dTUkl2OFFRQnppLzJMLzBFQVpJditzU2NJSWtzRFZFc0JGb3NBc2hpQUJGRU8zcmF5R292N3NocE1zaHF5R29FR3NoQWlzZ0d6aS94QkFCYUxBb0hJQTFOTEFoTkJBQXBJZ1FJalR3Sk5qQUNKUlFHTC8wRUFGVWtVaXdHQlIxc1VFMEVBQ1lFQ0kwOENUWXdBaVNLTUFJbUxBWUZIVzBML2xvc0NnY2dEVTBML2hnPT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
