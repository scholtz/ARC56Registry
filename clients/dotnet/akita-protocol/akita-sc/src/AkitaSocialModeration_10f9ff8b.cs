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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWtpdGFTb2NpYWxNb2RlcmF0aW9uIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdEFFRDFGQTkzIjpbeyJuYW1lIjoiZXhpc3RzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJsYXN0QWN0aXZlIiwidHlwZSI6InVpbnQ2NCJ9XSwiQWN0aW9uIjpbeyJuYW1lIjoiY29udGVudCIsInR5cGUiOiJieXRlWzM2XSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmVyc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkTW9kZXJhdG9yIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbW92ZU1vZGVyYXRvciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJiYW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyYXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5iYW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZmxhZ1Bvc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5mbGFnUG9zdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRNb2RlcmF0b3JDb250ZW50RmxhZ3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZsYWdzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZEFjdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY3Rpb25BcHBJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVszNl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb250ZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbW92ZUFjdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY3Rpb25BcHBJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc0Jhbm5lZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzTW9kZXJhdG9yIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibW9kZXJhdG9yTWV0YSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCx1aW50NjQpIiwic3RydWN0IjoiT2JqZWN0QUVEMUZBOTMiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdWZXJzaW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiVXBkYXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVBa2l0YURBTyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJha2l0YURBTyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcFVwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNzQ1LDgxOF0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDE0XSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2MSw3MTddLCJlcnJvck1lc3NhZ2UiOiJFUlI6RUFDVCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzMl0sImVycm9yTWVzc2FnZSI6IkVSUjpFQkFOIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE2XSwiZXJyb3JNZXNzYWdlIjoiRVJSOkVNT0QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MTRdLCJlcnJvck1lc3NhZ2UiOiJFUlI6SVVQRyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4OV0sImVycm9yTWVzc2FnZSI6IkVSUjpOQkFOIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkxLDM1MSw2NDAsNjk3LDg4Miw5NDldLCJlcnJvck1lc3NhZ2UiOiJFUlI6TkRBTyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2OCw0MDYsNDYzLDUxNyw1NDksNTkwXSwiZXJyb3JNZXNzYWdlIjoiRVJSOk5NT0QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODQsMzQ0LDYzMyw2OTAsODc1LDk0Ml0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3OCwzMzgsNjI3LDY4NCw4NjksODg2LDkzNiw5NjRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzMsODUyLDEwMzRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDEsODYwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MiwzMzIsMzgzLDQ0OSw1MDMsNTM1LDU2Nyw3MzEsNzc4LDgwNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzY+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUyLDM5MSw1NzUsNjExLDY3Nyw5MjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDM5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9zb2NpYWwvdHlwZXMudHM6OlBvc3RWYWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMjZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA5IG9mICh1aW50OFszMl0sdWludDY0LHVpbnQ2NCxib29sMSx1aW50NjQsYm9vbDEsdWludDgsdWludDY0LHVpbnQ2NCwobGVuK3VpbnQ4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMjFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHR1cGxlIGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURNeUlEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltRnJhWFJoWDJSaGJ5SWdJbVFpSUNKM1lXeHNaWFFpSUNKRlVsSTZUa1JCVHlJZ0lrVlNVanBPVFU5RUlpQXdlREUxTVdZM1l6YzFJQ0p1SWlBd2VEQXdJQ0oyWlhKemFXOXVJaUFpUlZKU09rVkJRMVFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGcmFYUmhVMjlqYVdGc1RXOWtaWEpoZEdsdmJpQmxlSFJsYm1SeklGVndaM0poWkdWaFlteGxRV3RwZEdGQ1lYTmxRMjl1ZEhKaFkzUWdld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRaV0U1TVRnd1pHUWdMeThnYldWMGFHOWtJQ0oxY0dSaGRHVW9jM1J5YVc1bktYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYM1Z3WkdGMFpWOXliM1YwWlVBeUNncHRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FXdHBkR0ZUYjJOcFlXeE5iMlJsY21GMGFXOXVJR1Y0ZEdWdVpITWdWWEJuY21Ga1pXRmliR1ZCYTJsMFlVSmhjMlZEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FESXdDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZMk5rT1dJNFpETWdNSGd3TTJVellXSXlNaUF3ZURkaE9ETXpZalF3SURCNFlUQmtNak15TVdRZ01IZzJNV1JqWkRKbFppQXdlRGM1TmpCbFlUYzJJREI0Wm1KbU5HUmtNelVnTUhoa1lUWmhaR05rT1NBd2VHWXhORGt5WW1ZMElEQjRPRFF5Tmpsak56Z2dNSGczTVRKbFpUZ3lNeUF3ZURGbU0yTTJNVGhqSURCNE16TmxPVEpqT1RRZ01IZzROVFJrWldSbE1DQXZMeUJ0WlhSb2IyUWdJbUZrWkUxdlpHVnlZWFJ2Y2loaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsYlc5MlpVMXZaR1Z5WVhSdmNpaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1KaGJpaGhaR1J5WlhOekxIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0oxYm1KaGJpaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1ac1lXZFFiM04wS0dKNWRHVmJNekpkS1hadmFXUWlMQ0J0WlhSb2IyUWdJblZ1Wm14aFoxQnZjM1FvWW5sMFpWc3pNbDBwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwVFc5a1pYSmhkRzl5UTI5dWRHVnVkRVpzWVdkektHSjVkR1ZiTXpKZExIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0poWkdSQlkzUnBiMjRvZFdsdWREWTBMR0o1ZEdWYk16WmRLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxiVzkyWlVGamRHbHZiaWgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWFYTkNZVzV1WldRb1lXUmtjbVZ6Y3lsaWIyOXNJaXdnYldWMGFHOWtJQ0pwYzAxdlpHVnlZWFJ2Y2loaFpHUnlaWE56S1dKdmIyd2lMQ0J0WlhSb2IyUWdJbTF2WkdWeVlYUnZjazFsZEdFb1lXUmtjbVZ6Y3lrb1ltOXZiQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0oxY0dSaGRHVkJhMmwwWVVSQlR5aDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYjNCVmNDZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHRmtaRTF2WkdWeVlYUnZjaUJ5WlcxdmRtVk5iMlJsY21GMGIzSWdZbUZ1SUhWdVltRnVJR1pzWVdkUWIzTjBJSFZ1Wm14aFoxQnZjM1FnYzJWMFRXOWtaWEpoZEc5eVEyOXVkR1Z1ZEVac1lXZHpJR0ZrWkVGamRHbHZiaUJ5WlcxdmRtVkJZM1JwYjI0Z2FYTkNZVzV1WldRZ2FYTk5iMlJsY21GMGIzSWdiVzlrWlhKaGRHOXlUV1YwWVNCMWNHUmhkR1ZCYTJsMFlVUkJUeUJ0WVdsdVgyOXdWWEJmY205MWRHVkFNVGdLSUNBZ0lHVnljZ29LYldGcGJsOXZjRlZ3WDNKdmRYUmxRREU0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TkRFS0lDQWdJQzh2SUc5d1ZYQW9LVG9nZG05cFpDQjdJSDBLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTWpBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnJhWFJoVTI5amFXRnNUVzlrWlhKaGRHbHZiaUJsZUhSbGJtUnpJRlZ3WjNKaFpHVmhZbXhsUVd0cGRHRkNZWE5sUTI5dWRISmhZM1FnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WTJRNVlXUTJOMlVnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1VvYzNSeWFXNW5MSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsQ2lBZ0lDQmxjbklLQ20xaGFXNWZkWEJrWVhSbFgzSnZkWFJsUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvME5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ1d5ZFZjR1JoZEdWQmNIQnNhV05oZEdsdmJpZGRJSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z1ZYQmtZWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCMWNHUmhkR1VLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pvNlFXdHBkR0ZUYjJOcFlXeE5iMlJsY21GMGFXOXVMbU55WldGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pJMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3lOUW9nSUNBZ0x5OGdkbVZ5YzJsdmJpQTlJRWRzYjJKaGJGTjBZWFJsUEhOMGNtbHVaejRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVZtVnljMmx2YmlCOUtRb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWRtVnljMmx2YmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUIwYUdsekxuWmxjbk5wYjI0dWRtRnNkV1VnUFNCMlpYSnphVzl1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3lOd29nSUNBZ0x5OGdZV3RwZEdGRVFVOGdQU0JIYkc5aVlXeFRkR0YwWlR4QmNIQnNhV05oZEdsdmJqNG9leUJyWlhrNklFZHNiMkpoYkZOMFlYUmxTMlY1UVd0cGRHRkVRVThnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1GcmFYUmhYMlJoYnlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUIwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsSUQwZ1lXdHBkR0ZFUVU4S0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem95TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHOXVRM0psWVhSbE9pQW5jbVZ4ZFdseVpTY2dmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pvNlFXdHBkR0ZUYjJOcFlXeE5iMlJsY21GMGFXOXVMbUZrWkUxdlpHVnlZWFJ2Y2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRmtaRTF2WkdWeVlYUnZjam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z1lXUmtUVzlrWlhKaGRHOXlLR0ZrWkhKbGMzTTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbWRsZEVGcmFYUmhSRUZQVjJGc2JHVjBLQ2t1WVdSa2NtVnpjeXdnUlZKU1gwNVBWRjlCUzBsVVFWOUVRVThwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3pNQW9nSUNBZ0x5OGdZMjl1YzNRZ1czZGhiR3hsZEVsRVhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzFkaGJHeGxkQ2twQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNamNLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvek1Bb2dJQ0FnTHk4Z1kyOXVjM1FnVzNkaGJHeGxkRWxFWFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVGVnBiblEyTkNoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMWRoYkd4bGRDa3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTmZNaUF2THlBaWQyRnNiR1YwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbWRsZEVGcmFYUmhSRUZQVjJGc2JHVjBLQ2t1WVdSa2NtVnpjeXdnUlZKU1gwNVBWRjlCUzBsVVFWOUVRVThwQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJaR1J5WlhOekNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJR0ZrWkUxdlpHVnlZWFJ2Y2w5aFpuUmxjbDloYzNObGNuUkFNd29nSUNBZ1lubDBaV05mTXlBdkx5QWlSVkpTT2s1RVFVOGlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlRrUkJUd29LWVdSa1RXOWtaWEpoZEc5eVgyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJRzF2WkdWeVlYUnZjbk1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ1FXdHBkR0ZUYjJOcFlXeENiM2hRY21WbWFYaE5iMlJsY21GMGIzSnpJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0prSWdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9JWFJvYVhNdWJXOWtaWEpoZEc5eWN5aGhaR1J5WlhOektTNWxlR2x6ZEhNc0lFVlNVbDlCVEZKRlFVUlpYMEZmVFU5RVJWSkJWRTlTS1FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQmhaR1JOYjJSbGNtRjBiM0pmWVdaMFpYSmZZWE56WlhKMFFEVUtJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPa1ZOVDBRaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2UlUxUFJBb0tZV1JrVFc5a1pYSmhkRzl5WDJGbWRHVnlYMkZ6YzJWeWRFQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklIUm9hWE11Ylc5a1pYSmhkRzl5Y3loaFpHUnlaWE56S1M1amNtVmhkR1VvS1FvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCaFpHUk5iMlJsY21GMGIzSW9ZV1JrY21WemN6b2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPanBCYTJsMFlWTnZZMmxoYkUxdlpHVnlZWFJwYjI0dWNtVnRiM1psVFc5a1pYSmhkRzl5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVnRiM1psVFc5a1pYSmhkRzl5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QnlaVzF2ZG1WTmIyUmxjbUYwYjNJb1lXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVoyVjBRV3RwZEdGRVFVOVhZV3hzWlhRb0tTNWhaR1J5WlhOekxDQkZVbEpmVGs5VVgwRkxTVlJCWDBSQlR5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5aVlYTmxMblJ6T2pNd0NpQWdJQ0F2THlCamIyNXpkQ0JiZDJGc2JHVjBTVVJkSUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEVWNFZXbHVkRFkwS0hSb2FYTXVZV3RwZEdGRVFVOHVkbUZzZFdVc0lFSjVkR1Z6S0VGcmFYUmhSRUZQUjJ4dlltRnNVM1JoZEdWTFpYbHpWMkZzYkdWMEtTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pveU53b2dJQ0FnTHk4Z1lXdHBkR0ZFUVU4Z1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkc2IySmhiRk4wWVhSbFMyVjVRV3RwZEdGRVFVOGdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZyYVhSaFgyUmhieUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTlpWVhObExuUnpPak13Q2lBZ0lDQXZMeUJqYjI1emRDQmJkMkZzYkdWMFNVUmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0VldsdWREWTBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VzSUVKNWRHVnpLRUZyYVhSaFJFRlBSMnh2WW1Gc1UzUmhkR1ZMWlhselYyRnNiR1YwS1NrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ozWVd4c1pYUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVoyVjBRV3RwZEdGRVFVOVhZV3hzWlhRb0tTNWhaR1J5WlhOekxDQkZVbEpmVGs5VVgwRkxTVlJCWDBSQlR5a0tJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VGa1pISmxjM01LSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2NtVnRiM1psVFc5a1pYSmhkRzl5WDJGbWRHVnlYMkZ6YzJWeWRFQXpDaUFnSUNCaWVYUmxZMTh6SUM4dklDSkZVbEk2VGtSQlR5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwT1JFRlBDZ3B5WlcxdmRtVk5iMlJsY21GMGIzSmZZV1owWlhKZllYTnpaWEowUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnYlc5a1pYSmhkRzl5Y3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCMWFXNTBOalErS0hzZ2EyVjVVSEpsWm1sNE9pQkJhMmwwWVZOdlkybGhiRUp2ZUZCeVpXWnBlRTF2WkdWeVlYUnZjbk1nZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1RaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk5ESUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2gwYUdsekxtMXZaR1Z5WVhSdmNuTW9ZV1JrY21WemN5a3VaWGhwYzNSekxDQkZVbEpmVGs5VVgwRmZUVTlFUlZKQlZFOVNLUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ2NtVnRiM1psVFc5a1pYSmhkRzl5WDJGbWRHVnlYMkZ6YzJWeWRFQTFDaUFnSUNCaWVYUmxZeUEwSUM4dklDSkZVbEk2VGsxUFJDSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwT1RVOUVDZ3B5WlcxdmRtVk5iMlJsY21GMGIzSmZZV1owWlhKZllYTnpaWEowUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem8wTXdvZ0lDQWdMeThnZEdocGN5NXRiMlJsY21GMGIzSnpLR0ZrWkhKbGMzTXBMbVJsYkdWMFpTZ3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6bzBNQW9nSUNBZ0x5OGdjbVZ0YjNabFRXOWtaWEpoZEc5eUtHRmtaSEpsYzNNNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6bzZRV3RwZEdGVGIyTnBZV3hOYjJSbGNtRjBhVzl1TG1KaGJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUpoYmpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6bzBOZ29nSUNBZ0x5OGdZbUZ1S0dGa1pISmxjM002SUVGalkyOTFiblFzSUdWNGNHbHlZWFJwYjI0NklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnYlc5a1pYSmhkRzl5Y3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCMWFXNTBOalErS0hzZ2EyVjVVSEpsWm1sNE9pQkJhMmwwWVZOdlkybGhiRUp2ZUZCeVpXWnBlRTF2WkdWeVlYUnZjbk1nZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem8wTndvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtIUm9hWE11Ylc5a1pYSmhkRzl5Y3loVWVHNHVjMlZ1WkdWeUtTNWxlR2x6ZEhNc0lFVlNVbDlPVDFSZlFWOU5UMFJGVWtGVVQxSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnYlc5a1pYSmhkRzl5Y3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCMWFXNTBOalErS0hzZ2EyVjVVSEpsWm1sNE9pQkJhMmwwWVZOdlkybGhiRUp2ZUZCeVpXWnBlRTF2WkdWeVlYUnZjbk1nZlNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TkRjS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaDBhR2x6TG0xdlpHVnlZWFJ2Y25Nb1ZIaHVMbk5sYm1SbGNpa3VaWGhwYzNSekxDQkZVbEpmVGs5VVgwRmZUVTlFUlZKQlZFOVNLUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ1ltRnVYMkZtZEdWeVgyRnpjMlZ5ZEVBekNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKRlVsSTZUazFQUkNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBPVFU5RUNncGlZVzVmWVdaMFpYSmZZWE56WlhKMFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveU1Bb2dJQ0FnTHk4Z1ltRnVibVZrSUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUhWcGJuUTJORDRvZXlCclpYbFFjbVZtYVhnNklFRnJhWFJoVTI5amFXRnNRbTk0VUhKbFptbDRRbUZ1Ym1Wa0lIMHBDaUFnSUNCaWVYUmxZeUEySUM4dklDSnVJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb0lYUm9hWE11WW1GdWJtVmtLR0ZrWkhKbGMzTXBMbVY0YVhOMGN5d2dSVkpTWDBGTVVrVkJSRmxmUWtGT1RrVkVLUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCaVlXNWZZV1owWlhKZllYTnpaWEowUURVS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09rVkNRVTRpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZSVUpCVGdvS1ltRnVYMkZtZEdWeVgyRnpjMlZ5ZEVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUhSb2FYTXVZbUZ1Ym1Wa0tHRmtaSEpsYzNNcExuWmhiSFZsSUQwZ1pYaHdhWEpoZEdsdmJnb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklHSmhiaWhoWkdSeVpYTnpPaUJCWTJOdmRXNTBMQ0JsZUhCcGNtRjBhVzl1T2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pvNlFXdHBkR0ZUYjJOcFlXeE5iMlJsY21GMGFXOXVMblZ1WW1GdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkVzVpWVc0NkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJSFZ1WW1GdUtHRmtaSEpsYzNNNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJRzF2WkdWeVlYUnZjbk1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ1FXdHBkR0ZUYjJOcFlXeENiM2hRY21WbWFYaE5iMlJsY21GMGIzSnpJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0prSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoMGFHbHpMbTF2WkdWeVlYUnZjbk1vVkhodUxuTmxibVJsY2lrdVpYaHBjM1J6TENCRlVsSmZUazlVWDBGZlRVOUVSVkpCVkU5U0tRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJRzF2WkdWeVlYUnZjbk1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ1FXdHBkR0ZUYjJOcFlXeENiM2hRY21WbWFYaE5iMlJsY21GMGIzSnpJSDBwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2RHaHBjeTV0YjJSbGNtRjBiM0p6S0ZSNGJpNXpaVzVrWlhJcExtVjRhWE4wY3l3Z1JWSlNYMDVQVkY5QlgwMVBSRVZTUVZSUFVpa0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUhWdVltRnVYMkZtZEdWeVgyRnpjMlZ5ZEVBekNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKRlVsSTZUazFQUkNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBPVFU5RUNncDFibUpoYmw5aFpuUmxjbDloYzNObGNuUkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qSXdDaUFnSUNBdkx5QmlZVzV1WldRZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dRV3RwZEdGVGIyTnBZV3hDYjNoUWNtVm1hWGhDWVc1dVpXUWdmU2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbTRpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaDBhR2x6TG1KaGJtNWxaQ2hoWkdSeVpYTnpLUzVsZUdsemRITXNJRVZTVWw5VlUwVlNYMDVQVkY5Q1FVNU9SVVFwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQjFibUpoYmw5aFpuUmxjbDloYzNObGNuUkFOUW9nSUNBZ2NIVnphR0o1ZEdWeklDSkZVbEk2VGtKQlRpSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwT1FrRk9DZ3AxYm1KaGJsOWhablJsY2w5aGMzTmxjblJBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUIwYUdsekxtSmhibTVsWkNoaFpHUnlaWE56S1M1a1pXeGxkR1VvS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUhWdVltRnVLR0ZrWkhKbGMzTTZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem82UVd0cGRHRlRiMk5wWVd4TmIyUmxjbUYwYVc5dUxtWnNZV2RRYjNOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tabXhoWjFCdmMzUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z1pteGhaMUJ2YzNRb2NtVm1PaUJpZVhSbGN6d3pNajRwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklHMXZaR1Z5WVhSdmNuTWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nUVd0cGRHRlRiMk5wWVd4Q2IzaFFjbVZtYVhoTmIyUmxjbUYwYjNKeklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2gwYUdsekxtMXZaR1Z5WVhSdmNuTW9WSGh1TG5ObGJtUmxjaWt1WlhocGMzUnpMQ0JGVWxKZlRrOVVYMEZmVFU5RVJWSkJWRTlTS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklHMXZaR1Z5WVhSdmNuTWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nUVd0cGRHRlRiMk5wWVd4Q2IzaFFjbVZtYVhoTmIyUmxjbUYwYjNKeklIMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvZEdocGN5NXRiMlJsY21GMGIzSnpLRlI0Ymk1elpXNWtaWElwTG1WNGFYTjBjeXdnUlZKU1gwNVBWRjlCWDAxUFJFVlNRVlJQVWlrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJR1pzWVdkUWIzTjBYMkZtZEdWeVgyRnpjMlZ5ZEVBekNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKRlVsSTZUazFQUkNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBPVFU5RUNncG1iR0ZuVUc5emRGOWhablJsY2w5aGMzTmxjblJBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUIwYUdsekxtRndjR3g1VFc5a1pYSmhkR2x2YmloeVpXWXNJSFJ5ZFdVc0lIUnlkV1VzSURBc0lHWmhiSE5sS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJR0Z3Y0d4NVRXOWtaWEpoZEdsdmJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUdac1lXZFFiM04wS0hKbFpqb2dZbmwwWlhNOE16SStLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02T2tGcmFYUmhVMjlqYVdGc1RXOWtaWEpoZEdsdmJpNTFibVpzWVdkUWIzTjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFc1bWJHRm5VRzl6ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUIxYm1ac1lXZFFiM04wS0hKbFpqb2dZbmwwWlhNOE16SStLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCdGIyUmxjbUYwYjNKeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJRUZyYVhSaFUyOWphV0ZzUW05NFVISmxabWw0VFc5a1pYSmhkRzl5Y3lCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9kR2hwY3k1dGIyUmxjbUYwYjNKektGUjRiaTV6Wlc1a1pYSXBMbVY0YVhOMGN5d2dSVkpTWDA1UFZGOUJYMDFQUkVWU1FWUlBVaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCdGIyUmxjbUYwYjNKeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJRUZyYVhSaFUyOWphV0ZzUW05NFVISmxabWw0VFc5a1pYSmhkRzl5Y3lCOUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLSFJvYVhNdWJXOWtaWEpoZEc5eWN5aFVlRzR1YzJWdVpHVnlLUzVsZUdsemRITXNJRVZTVWw5T1QxUmZRVjlOVDBSRlVrRlVUMUlwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQjFibVpzWVdkUWIzTjBYMkZtZEdWeVgyRnpjMlZ5ZEVBekNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKRlVsSTZUazFQUkNJS0lDQWdJR3h2WndvZ0lDQWdaWEp5SUM4dklFVlNVanBPVFU5RUNncDFibVpzWVdkUWIzTjBYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUhSb2FYTXVZWEJ3YkhsTmIyUmxjbUYwYVc5dUtISmxaaXdnZEhKMVpTd2dabUZzYzJVc0lEQXNJR1poYkhObEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdZMkZzYkhOMVlpQmhjSEJzZVUxdlpHVnlZWFJwYjI0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUIxYm1ac1lXZFFiM04wS0hKbFpqb2dZbmwwWlhNOE16SStLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02T2tGcmFYUmhVMjlqYVdGc1RXOWtaWEpoZEdsdmJpNXpaWFJOYjJSbGNtRjBiM0pEYjI1MFpXNTBSbXhoWjNOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJOYjJSbGNtRjBiM0pEYjI1MFpXNTBSbXhoWjNNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnYzJWMFRXOWtaWEpoZEc5eVEyOXVkR1Z1ZEVac1lXZHpLSEpsWmpvZ1lubDBaWE04TXpJK0xDQm1iR0ZuY3pvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUJ0YjJSbGNtRjBiM0p6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUhWcGJuUTJORDRvZXlCclpYbFFjbVZtYVhnNklFRnJhWFJoVTI5amFXRnNRbTk0VUhKbFptbDRUVzlrWlhKaGRHOXljeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPalk1Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2RHaHBjeTV0YjJSbGNtRjBiM0p6S0ZSNGJpNXpaVzVrWlhJcExtVjRhWE4wY3l3Z1JWSlNYMDVQVkY5QlgwMVBSRVZTUVZSUFVpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUJ0YjJSbGNtRjBiM0p6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUhWcGJuUTJORDRvZXlCclpYbFFjbVZtYVhnNklFRnJhWFJoVTI5amFXRnNRbTk0VUhKbFptbDRUVzlrWlhKaGRHOXljeUI5S1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtIUm9hWE11Ylc5a1pYSmhkRzl5Y3loVWVHNHVjMlZ1WkdWeUtTNWxlR2x6ZEhNc0lFVlNVbDlPVDFSZlFWOU5UMFJGVWtGVVQxSXBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCelpYUk5iMlJsY21GMGIzSkRiMjUwWlc1MFJteGhaM05mWVdaMFpYSmZZWE56WlhKMFFETUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lrVlNVanBPVFU5RUlnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT2s1TlQwUUtDbk5sZEUxdlpHVnlZWFJ2Y2tOdmJuUmxiblJHYkdGbmMxOWhablJsY2w5aGMzTmxjblJBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUIwYUdsekxtRndjR3g1VFc5a1pYSmhkR2x2YmloeVpXWXNJR1poYkhObExDQm1ZV3h6WlN3Z1pteGhaM01zSUhSeWRXVXBDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JqWVd4c2MzVmlJR0Z3Y0d4NVRXOWtaWEpoZEdsdmJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUhObGRFMXZaR1Z5WVhSdmNrTnZiblJsYm5SR2JHRm5jeWh5WldZNklHSjVkR1Z6UERNeVBpd2dabXhoWjNNNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qcEJhMmwwWVZOdlkybGhiRTF2WkdWeVlYUnBiMjR1WVdSa1FXTjBhVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lXUmtRV04wYVc5dU9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakV3TVFvZ0lDQWdMeThnWVdSa1FXTjBhVzl1S0dGamRHbHZia0Z3Y0VsRU9pQjFhVzUwTmpRc0lHTnZiblJsYm5RNklFTkpSQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016WUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETTJQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1UQXlDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1blpYUkJhMmwwWVVSQlQxZGhiR3hsZENncExtRmtaSEpsYzNNc0lFVlNVbDlPVDFSZlFVdEpWRUZmUkVGUEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TXpBS0lDQWdJQzh2SUdOdmJuTjBJRnQzWVd4c1pYUkpSRjBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoVmFXNTBOalFvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlN3Z1FubDBaWE1vUVd0cGRHRkVRVTlIYkc5aVlXeFRkR0YwWlV0bGVYTlhZV3hzWlhRcEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5aVlYTmxMblJ6T2pJM0NpQWdJQ0F2THlCaGEybDBZVVJCVHlBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjJ4dlltRnNVM1JoZEdWTFpYbEJhMmwwWVVSQlR5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV3RwZEdGZlpHRnZJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNekFLSUNBZ0lDOHZJR052Ym5OMElGdDNZV3hzWlhSSlJGMGdQU0J2Y0M1QmNIQkhiRzlpWVd3dVoyVjBSWGhWYVc1ME5qUW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU3dnUW5sMFpYTW9RV3RwZEdGRVFVOUhiRzlpWVd4VGRHRjBaVXRsZVhOWFlXeHNaWFFwS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbmRoYkd4bGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qRXdNZ29nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVoyVjBRV3RwZEdGRVFVOVhZV3hzWlhRb0tTNWhaR1J5WlhOekxDQkZVbEpmVGs5VVgwRkxTVlJCWDBSQlR5a0tJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VGa1pISmxjM01LSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1lXUmtRV04wYVc5dVgyRm1kR1Z5WDJGemMyVnlkRUF6Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pGVWxJNlRrUkJUeUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcE9SRUZQQ2dwaFpHUkJZM1JwYjI1ZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hNRE1LSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENnaGRHaHBjeTVoWTNScGIyNXpLR0ZqZEdsdmJrRndjRWxFS1M1bGVHbHpkSE1zSUVWU1VsOUJURkpGUVVSWlgwRk9YMEZEVkVsUFRpa0tJQ0FnSUdScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveU1nb2dJQ0FnTHk4Z1lXTjBhVzl1Y3lBOUlFSnZlRTFoY0R4MWFXNTBOalFzSUVGamRHbHZiajRvZXlCclpYbFFjbVZtYVhnNklFRnJhWFJoVTI5amFXRnNRbTk0VUhKbFptbDRRV04wYVc5dWN5QjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSmhJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNVEF6Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb0lYUm9hWE11WVdOMGFXOXVjeWhoWTNScGIyNUJjSEJKUkNrdVpYaHBjM1J6TENCRlVsSmZRVXhTUlVGRVdWOUJUbDlCUTFSSlQwNHBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdGa1pFRmpkR2x2Ymw5aFpuUmxjbDloYzNObGNuUkFOUW9nSUNBZ1lubDBaV01nT1NBdkx5QWlSVkpTT2tWQlExUWlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlJVRkRWQW9LWVdSa1FXTjBhVzl1WDJGbWRHVnlYMkZ6YzJWeWRFQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1UQTBDaUFnSUNBdkx5QjBhR2x6TG1GamRHbHZibk1vWVdOMGFXOXVRWEJ3U1VRcExuWmhiSFZsSUQwZ2V5QmpiMjUwWlc1MElIMEtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNVEF4Q2lBZ0lDQXZMeUJoWkdSQlkzUnBiMjRvWVdOMGFXOXVRWEJ3U1VRNklIVnBiblEyTkN3Z1kyOXVkR1Z1ZERvZ1EwbEVLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02T2tGcmFYUmhVMjlqYVdGc1RXOWtaWEpoZEdsdmJpNXlaVzF2ZG1WQlkzUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXMXZkbVZCWTNScGIyNDZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRBM0NpQWdJQ0F2THlCeVpXMXZkbVZCWTNScGIyNG9ZV04wYVc5dVFYQndTVVE2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNVEE0Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NW5aWFJCYTJsMFlVUkJUMWRoYkd4bGRDZ3BMbUZrWkhKbGMzTXNJRVZTVWw5T1QxUmZRVXRKVkVGZlJFRlBLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk16QUtJQ0FnSUM4dklHTnZibk4wSUZ0M1lXeHNaWFJKUkYwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaFZhVzUwTmpRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTd2dRbmwwWlhNb1FXdHBkR0ZFUVU5SGJHOWlZV3hUZEdGMFpVdGxlWE5YWVd4c1pYUXBLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OWlZWE5sTG5Sek9qSTNDaUFnSUNBdkx5QmhhMmwwWVVSQlR5QTlJRWRzYjJKaGJGTjBZWFJsUEVGd2NHeHBZMkYwYVc5dVBpaDdJR3RsZVRvZ1IyeHZZbUZzVTNSaGRHVkxaWGxCYTJsMFlVUkJUeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVd0cGRHRmZaR0Z2SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TXpBS0lDQWdJQzh2SUdOdmJuTjBJRnQzWVd4c1pYUkpSRjBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoVmFXNTBOalFvZEdocGN5NWhhMmwwWVVSQlR5NTJZV3gxWlN3Z1FubDBaWE1vUVd0cGRHRkVRVTlIYkc5aVlXeFRkR0YwWlV0bGVYTlhZV3hzWlhRcEtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5kaGJHeGxkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPakV3T0FvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVaMlYwUVd0cGRHRkVRVTlYWVd4c1pYUW9LUzVoWkdSeVpYTnpMQ0JGVWxKZlRrOVVYMEZMU1ZSQlgwUkJUeWtLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRmtaSEpsYzNNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoY0hCc2FXTmhkR2x2YmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWJub2djbVZ0YjNabFFXTjBhVzl1WDJGbWRHVnlYMkZ6YzJWeWRFQXpDaUFnSUNCaWVYUmxZMTh6SUM4dklDSkZVbEk2VGtSQlR5SUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwT1JFRlBDZ3B5WlcxdmRtVkJZM1JwYjI1ZllXWjBaWEpmWVhOelpYSjBRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hNRGtLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoMGFHbHpMbUZqZEdsdmJuTW9ZV04wYVc5dVFYQndTVVFwTG1WNGFYTjBjeXdnUlZKU1gwRk1Va1ZCUkZsZlFVNWZRVU5VU1U5T0tRb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5amFXRnNMMjF2WkdWeVlYUnBiMjR1WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnWVdOMGFXOXVjeUE5SUVKdmVFMWhjRHgxYVc1ME5qUXNJRUZqZEdsdmJqNG9leUJyWlhsUWNtVm1hWGc2SUVGcmFYUmhVMjlqYVdGc1FtOTRVSEpsWm1sNFFXTjBhVzl1Y3lCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKaElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk1UQTVDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvZEdocGN5NWhZM1JwYjI1ektHRmpkR2x2YmtGd2NFbEVLUzVsZUdsemRITXNJRVZTVWw5QlRGSkZRVVJaWDBGT1gwRkRWRWxQVGlrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJSEpsYlc5MlpVRmpkR2x2Ymw5aFpuUmxjbDloYzNObGNuUkFOUW9nSUNBZ1lubDBaV01nT1NBdkx5QWlSVkpTT2tWQlExUWlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlJVRkRWQW9LY21WdGIzWmxRV04wYVc5dVgyRm1kR1Z5WDJGemMyVnlkRUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNVEV3Q2lBZ0lDQXZMeUIwYUdsekxtRmpkR2x2Ym5Nb1lXTjBhVzl1UVhCd1NVUXBMbVJsYkdWMFpTZ3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hNRGNLSUNBZ0lDOHZJSEpsYlc5MlpVRmpkR2x2YmloaFkzUnBiMjVCY0hCSlJEb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZPa0ZyYVhSaFUyOWphV0ZzVFc5a1pYSmhkR2x2Ymk1cGMwSmhibTVsWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHpRbUZ1Ym1Wa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRFMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TWpBS0lDQWdJQzh2SUdKaGJtNWxaQ0E5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lCQmEybDBZVk52WTJsaGJFSnZlRkJ5WldacGVFSmhibTVsWkNCOUtRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWJpSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveE1UY0tJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbUpoYm01bFpDaGhZMk52ZFc1MEtTNWxlR2x6ZEhNZ0ppWWdkR2hwY3k1aVlXNXVaV1FvWVdOamIzVnVkQ2t1ZG1Gc2RXVWdQaUJIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJR2x6UW1GdWJtVmtYMkp2YjJ4ZlptRnNjMlZBTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdZblJ2YVFvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdQZ29nSUNBZ1lub2dhWE5DWVc1dVpXUmZZbTl2YkY5bVlXeHpaVUEwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LYVhOQ1lXNXVaV1JmWW05dmJGOXRaWEpuWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRFMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHBjMEpoYm01bFpGOWliMjlzWDJaaGJITmxRRFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnBjMEpoYm01bFpGOWliMjlzWDIxbGNtZGxRRFVLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pvNlFXdHBkR0ZUYjJOcFlXeE5iMlJsY21GMGFXOXVMbWx6VFc5a1pYSmhkRzl5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FYTk5iMlJsY21GMGIzSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveE1qQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z2JXOWtaWEpoZEc5eWN5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUJCYTJsMFlWTnZZMmxoYkVKdmVGQnlaV1pwZUUxdlpHVnlZWFJ2Y25NZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltUWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qRXlNZ29nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11Ylc5a1pYSmhkRzl5Y3loaFkyTnZkVzUwS1M1bGVHbHpkSE1LSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02TVRJd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZPa0ZyYVhSaFUyOWphV0ZzVFc5a1pYSmhkR2x2Ymk1dGIyUmxjbUYwYjNKTlpYUmhXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYlc5a1pYSmhkRzl5VFdWMFlUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFeU5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCdGIyUmxjbUYwYjNKeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lIVnBiblEyTkQ0b2V5QnJaWGxRY21WbWFYZzZJRUZyYVhSaFUyOWphV0ZzUW05NFVISmxabWw0VFc5a1pYSmhkRzl5Y3lCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pveE1qY0tJQ0FnSUM4dklHbG1JQ2gwYUdsekxtMXZaR1Z5WVhSdmNuTW9kWE5sY2lrdVpYaHBjM1J6S1NCN0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJRzF2WkdWeVlYUnZjazFsZEdGZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6b3hNekFLSUNBZ0lDOHZJR3hoYzNSQlkzUnBkbVU2SUhSb2FYTXViVzlrWlhKaGRHOXljeWgxYzJWeUtTNTJZV3gxWlFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZNVEk0TFRFek1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhzS0lDQWdJQzh2SUNBZ1pYaHBjM1J6T2lCMGNuVmxMQW9nSUNBZ0x5OGdJQ0JzWVhOMFFXTjBhWFpsT2lCMGFHbHpMbTF2WkdWeVlYUnZjbk1vZFhObGNpa3VkbUZzZFdVS0lDQWdJQzh2SUgwS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtDbTF2WkdWeVlYUnZjazFsZEdGZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6bzZRV3RwZEdGVGIyTnBZV3hOYjJSbGNtRjBhVzl1TG0xdlpHVnlZWFJ2Y2sxbGRHRkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiMk5wWVd3dmJXOWtaWEpoZEdsdmJpNWhiR2R2TG5Sek9qRXlOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdGIyUmxjbUYwYjNKTlpYUmhYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFek13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhzZ1pYaHBjM1J6T2lCbVlXeHpaU3dnYkdGemRFRmpkR2wyWlRvZ01DQjlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pFeU5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCaUlHMXZaR1Z5WVhSdmNrMWxkR0ZmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pvNlFXdHBkR0ZUYjJOcFlXeE5iMlJsY21GMGFXOXVMbTF2WkdWeVlYUnZjazFsZEdGQU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5aVlYTmxMblJ6T2pwVmNHZHlZV1JsWVdKc1pVRnJhWFJoUW1GelpVTnZiblJ5WVdOMExuVndaR0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVndaR0YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5aVlYTmxMblJ6T2pRMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lCYkoxVndaR0YwWlVGd2NHeHBZMkYwYVc5dUoxMGdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TkRnS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbWRsZEVGcmFYUmhSRUZQVjJGc2JHVjBLQ2t1WVdSa2NtVnpjeXdnUlZKU1gwNVBWRjlCUzBsVVFWOUVRVThwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3pNQW9nSUNBZ0x5OGdZMjl1YzNRZ1czZGhiR3hsZEVsRVhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRlZwYm5RMk5DaDBhR2x6TG1GcmFYUmhSRUZQTG5aaGJIVmxMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzFkaGJHeGxkQ2twQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNamNLSUNBZ0lDOHZJR0ZyYVhSaFJFRlBJRDBnUjJ4dlltRnNVM1JoZEdVOFFYQndiR2xqWVhScGIyNCtLSHNnYTJWNU9pQkhiRzlpWVd4VGRHRjBaVXRsZVVGcmFYUmhSRUZQSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaGEybDBZVjlrWVc4aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvek1Bb2dJQ0FnTHk4Z1kyOXVjM1FnVzNkaGJHeGxkRWxFWFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVGVnBiblEyTkNoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMWRoYkd4bGRDa3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTmZNaUF2THlBaWQyRnNiR1YwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk5EZ0tJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1kbGRFRnJhWFJoUkVGUFYyRnNiR1YwS0NrdVlXUmtjbVZ6Y3l3Z1JWSlNYMDVQVkY5QlMwbFVRVjlFUVU4cENpQWdJQ0JoY0hCZmNHRnlZVzF6WDJkbGRDQkJjSEJCWkdSeVpYTnpDaUFnSUNCaGMzTmxjblFnTHk4Z1lYQndiR2xqWVhScGIyNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhWd1pHRjBaVjloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVJWSlNPazVFUVU4aUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2VGtSQlR3b0tkWEJrWVhSbFgyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TkRrS0lDQWdJQzh2SUdOdmJuTjBJSFZ3WkdGMFpWQnNkV2RwYmlBOUlHZGxkRkJzZFdkcGJrRndjRXhwYzNRb2RHaHBjeTVoYTJsMFlVUkJUeTUyWVd4MVpTa3VkWEJrWVhSbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TWpjS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6bzBPUW9nSUNBZ0x5OGdZMjl1YzNRZ2RYQmtZWFJsVUd4MVoybHVJRDBnWjJWMFVHeDFaMmx1UVhCd1RHbHpkQ2gwYUdsekxtRnJhWFJoUkVGUExuWmhiSFZsS1M1MWNHUmhkR1VLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qVTBDaUFnSUNBdkx5QmpiMjV6ZENCYmNHeDFaMmx1UVhCd1RHbHpkRUo1ZEdWelhTQTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUkZlRUo1ZEdWektHRnJhWFJoUkVGUExDQkNlWFJsY3loQmEybDBZVVJCVDBkc2IySmhiRk4wWVhSbFMyVjVjMUJzZFdkcGJrRndjRXhwYzNRcEtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKd1lXd2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem8wT1FvZ0lDQWdMeThnWTI5dWMzUWdkWEJrWVhSbFVHeDFaMmx1SUQwZ1oyVjBVR3gxWjJsdVFYQndUR2x6ZENoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbEtTNTFjR1JoZEdVS0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem8xTUFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtFZHNiMkpoYkM1allXeHNaWEpCY0hCc2FXTmhkR2x2Ymtsa0lEMDlQU0IxY0dSaGRHVlFiSFZuYVc0c0lFVlNVbDlKVGxaQlRFbEVYMVZRUjFKQlJFVXBDaUFnSUNCbmJHOWlZV3dnUTJGc2JHVnlRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUIxY0dSaGRHVmZZV1owWlhKZllYTnpaWEowUURVS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09rbFZVRWNpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZTVlZRUndvS2RYQmtZWFJsWDJGbWRHVnlYMkZ6YzJWeWRFQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJKaGMyVXRZMjl1ZEhKaFkzUnpMMkpoYzJVdWRITTZNalVLSUNBZ0lDOHZJSFpsY25OcGIyNGdQU0JIYkc5aVlXeFRkR0YwWlR4emRISnBibWMrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVWWmxjbk5wYjI0Z2ZTa0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luWmxjbk5wYjI0aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvMU1Rb2dJQ0FnTHk4Z2RHaHBjeTUyWlhKemFXOXVMblpoYkhWbElEMGdibVYzVm1WeWMybHZiZ29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem8wTmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nV3lkVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmlkZElIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk9rRnJhWFJoUW1GelpVTnZiblJ5WVdOMExuVndaR0YwWlVGcmFYUmhSRUZQVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsUVd0cGRHRkVRVTg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem96TmdvZ0lDQWdMeThnZFhCa1lYUmxRV3RwZEdGRVFVOG9ZV3RwZEdGRVFVODZJRUZ3Y0d4cFkyRjBhVzl1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZZbUZ6WlMxamIyNTBjbUZqZEhNdlltRnpaUzUwY3pvek53b2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WjJWMFFXdHBkR0ZFUVU5WFlXeHNaWFFvS1M1aFpHUnlaWE56TENCRlVsSmZUazlVWDBGTFNWUkJYMFJCVHlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5aVlYTmxMV052Ym5SeVlXTjBjeTlpWVhObExuUnpPak13Q2lBZ0lDQXZMeUJqYjI1emRDQmJkMkZzYkdWMFNVUmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0VldsdWREWTBLSFJvYVhNdVlXdHBkR0ZFUVU4dWRtRnNkV1VzSUVKNWRHVnpLRUZyYVhSaFJFRlBSMnh2WW1Gc1UzUmhkR1ZMWlhselYyRnNiR1YwS1NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlltRnpaUzFqYjI1MGNtRmpkSE12WW1GelpTNTBjem95TndvZ0lDQWdMeThnWVd0cGRHRkVRVThnUFNCSGJHOWlZV3hUZEdGMFpUeEJjSEJzYVdOaGRHbHZiajRvZXlCclpYazZJRWRzYjJKaGJGTjBZWFJsUzJWNVFXdHBkR0ZFUVU4Z2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRnJhWFJoWDJSaGJ5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTlpWVhObExXTnZiblJ5WVdOMGN5OWlZWE5sTG5Sek9qTXdDaUFnSUNBdkx5QmpiMjV6ZENCYmQyRnNiR1YwU1VSZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRWV2x1ZERZMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXNJRUo1ZEdWektFRnJhWFJoUkVGUFIyeHZZbUZzVTNSaGRHVkxaWGx6VjJGc2JHVjBLU2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjNZV3hzWlhRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3pOd29nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVoyVjBRV3RwZEdGRVFVOVhZV3hzWlhRb0tTNWhaR1J5WlhOekxDQkZVbEpmVGs5VVgwRkxTVlJCWDBSQlR5a0tJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VGa1pISmxjM01LSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2RYQmtZWFJsUVd0cGRHRkVRVTlmWVdaMFpYSmZZWE56WlhKMFFETUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0lrVlNVanBPUkVGUElnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT2s1RVFVOEtDblZ3WkdGMFpVRnJhWFJoUkVGUFgyRm1kR1Z5WDJGemMyVnlkRUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwySmhjMlV0WTI5dWRISmhZM1J6TDJKaGMyVXVkSE02TWpjS0lDQWdJQzh2SUdGcmFYUmhSRUZQSUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIYkc5aVlXeFRkR0YwWlV0bGVVRnJhWFJoUkVGUElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhhMmwwWVY5a1lXOGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12WW1GelpTMWpiMjUwY21GamRITXZZbUZ6WlM1MGN6b3pPQW9nSUNBZ0x5OGdkR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU0E5SUdGcmFYUmhSRUZQQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OWlZWE5sTFdOdmJuUnlZV04wY3k5aVlYTmxMblJ6T2pNMkNpQWdJQ0F2THlCMWNHUmhkR1ZCYTJsMFlVUkJUeWhoYTJsMFlVUkJUem9nUVhCd2JHbGpZWFJwYjI0cE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6bzZRV3RwZEdGVGIyTnBZV3hOYjJSbGNtRjBhVzl1TG1Gd2NHeDVUVzlrWlhKaGRHbHZiaWh5WldZNklHSjVkR1Z6TENCMWNHUmhkR1ZHYkdGbloyVmtPaUIxYVc1ME5qUXNJR1pzWVdkblpXUldZV3gxWlRvZ2RXbHVkRFkwTENCbWJHRm5jMVpoYkhWbE9pQjFhVzUwTmpRc0lIVndaR0YwWlVac1lXZHpPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbUZ3Y0d4NVRXOWtaWEpoZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2pjNUxUZzFDaUFnSUNBdkx5QndjbWwyWVhSbElHRndjR3g1VFc5a1pYSmhkR2x2YmlnS0lDQWdJQzh2SUNBZ2NtVm1PaUJpZVhSbGN6d3pNajRzQ2lBZ0lDQXZMeUFnSUhWd1pHRjBaVVpzWVdkblpXUTZJR0p2YjJ4bFlXNHNDaUFnSUNBdkx5QWdJR1pzWVdkblpXUldZV3gxWlRvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1pteGhaM05XWVd4MVpUb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQjFjR1JoZEdWR2JHRm5jem9nWW05dmJHVmhiaXdLSUNBZ0lDOHZJQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTlNBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPamcyQ2lBZ0lDQXZMeUJqYjI1emRDQjdJSE52WTJsaGJDQjlJRDBnWjJWMFFXdHBkR0ZUYjJOcFlXeEJjSEJNYVhOMEtIUm9hWE11WVd0cGRHRkVRVTh1ZG1Gc2RXVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMkpoYzJVdFkyOXVkSEpoWTNSekwySmhjMlV1ZEhNNk1qY0tJQ0FnSUM4dklHRnJhWFJoUkVGUElEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGJHOWlZV3hUZEdGMFpVdGxlVUZyYVhSaFJFRlBJSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poYTJsMFlWOWtZVzhpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6bzROZ29nSUNBZ0x5OGdZMjl1YzNRZ2V5QnpiMk5wWVd3Z2ZTQTlJR2RsZEVGcmFYUmhVMjlqYVdGc1FYQndUR2x6ZENoMGFHbHpMbUZyYVhSaFJFRlBMblpoYkhWbEtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkxZEdsc2N5OW1kVzVqZEdsdmJuTXVkSE02TkRrS0lDQWdJQzh2SUdOdmJuTjBJRnRoY0hCTWFYTjBRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb1lXdHBkR0ZFUVU4c0lFSjVkR1Z6S0VGcmFYUmhSRUZQUjJ4dlltRnNVM1JoZEdWTFpYbHpRV3RwZEdGVGIyTnBZV3hCY0hCTWFYTjBLU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWljMkZzSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUdOdmJuTjBJSHNnYzI5amFXRnNJSDBnUFNCblpYUkJhMmwwWVZOdlkybGhiRUZ3Y0V4cGMzUW9kR2hwY3k1aGEybDBZVVJCVHk1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pvNE55MDVNQW9nSUNBZ0x5OGdZMjl1YzNRZ2NHOXpkQ0E5SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRUZyYVhSaFUyOWphV0ZzTG5CeWIzUnZkSGx3WlM1blpYUlFiM04wUGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCemIyTnBZV3dzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnR5WldaZENpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzVPR0k0TVdZM09DQXZMeUJ0WlhSb2IyUWdJbWRsZEZCdmMzUW9ZbmwwWlZzek1sMHBLR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkN4aWIyOXNMSFZwYm5RMk5DeGliMjlzTEhWcGJuUTRMSFZwYm5RMk5DeDFhVzUwTmpRc1lubDBaVnRkS1NJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQnVJRElLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQ2VYUmxjeUJvWVhNZ2RtRnNhV1FnY0hKbFptbDRDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTnpVS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOemNLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dPU0J2WmlBb2RXbHVkRGhiTXpKZExIVnBiblEyTkN4MWFXNTBOalFzWW05dmJERXNkV2x1ZERZMExHSnZiMnd4TEhWcGJuUTRMSFZwYm5RMk5DeDFhVzUwTmpRc0tHeGxiaXQxYVc1ME9GdGRLU2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURjNUNpQWdJQ0FyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDNSNWNHVnpMblJ6T2pwUWIzTjBWbUZzZFdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjJOcFlXd3ZiVzlrWlhKaGRHbHZiaTVoYkdkdkxuUnpPamt5Q2lBZ0lDQXZMeUJqYjI1emRDQnVaWGgwUm14aFoyZGxaRG9nWW05dmJHVmhiaUE5SUhWd1pHRjBaVVpzWVdkblpXUWdQeUJtYkdGbloyVmtWbUZzZFdVZ09pQndiM04wTG1GbllXbHVjM1JEYjI1MFpXNTBVRzlzYVdONUNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR0o2SUdGd2NHeDVUVzlrWlhKaGRHbHZibDkwWlhKdVlYSjVYMlpoYkhObFFETUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NncGhjSEJzZVUxdlpHVnlZWFJwYjI1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052WTJsaGJDOXRiMlJsY21GMGFXOXVMbUZzWjI4dWRITTZPVE1LSUNBZ0lDOHZJR052Ym5OMElHNWxlSFJHYkdGbmN6b2dkV2x1ZERZMElEMGdkWEJrWVhSbFJteGhaM01nUHlCbWJHRm5jMVpoYkhWbElEb2djRzl6ZEM1dGIyUmxjbUYwYjNKR2JHRm5jd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWVpQmhjSEJzZVUxdlpHVnlZWFJwYjI1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLQ21Gd2NHeDVUVzlrWlhKaGRHbHZibDkwWlhKdVlYSjVYMjFsY21kbFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOWphV0ZzTDIxdlpHVnlZWFJwYjI0dVlXeG5ieTUwY3pvNU5TMDVPQW9nSUNBZ0x5OGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1FXdHBkR0ZUYjJOcFlXd3VjSEp2ZEc5MGVYQmxMbk5sZEZCdmMzUk5iMlJsY21GMGFXOXVQaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJ6YjJOcFlXd3NDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdHlaV1lzSUc1bGVIUkdiR0ZuWjJWa0xDQnVaWGgwUm14aFozTmRDaUFnSUNBdkx5QjlLUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdlkybGhiQzl0YjJSbGNtRjBhVzl1TG1Gc1oyOHVkSE02T1RjS0lDQWdJQzh2SUdGeVozTTZJRnR5WldZc0lHNWxlSFJHYkdGbloyVmtMQ0J1WlhoMFJteGhaM05kQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjlqYVdGc0wyMXZaR1Z5WVhScGIyNHVZV3huYnk1MGN6bzVOUzA1T0FvZ0lDQWdMeThnWVdKcFEyRnNiRHgwZVhCbGIyWWdRV3RwZEdGVGIyTnBZV3d1Y0hKdmRHOTBlWEJsTG5ObGRGQnZjM1JOYjJSbGNtRjBhVzl1UGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCemIyTnBZV3dzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnR5WldZc0lHNWxlSFJHYkdGbloyVmtMQ0J1WlhoMFJteGhaM05kQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRFd1pXUmxZallnTHk4Z2JXVjBhRzlrSUNKelpYUlFiM04wVFc5a1pYSmhkR2x2YmloaWVYUmxXek15WFN4aWIyOXNMSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2NIVnphR2x1ZENBMklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUhKbGRITjFZZ29LWVhCd2JIbE5iMlJsY21GMGFXOXVYM1JsY201aGNubGZabUZzYzJWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIyTnBZV3d2Ylc5a1pYSmhkR2x2Ymk1aGJHZHZMblJ6T2prekNpQWdJQ0F2THlCamIyNXpkQ0J1WlhoMFJteGhaM002SUhWcGJuUTJOQ0E5SUhWd1pHRjBaVVpzWVdkeklEOGdabXhoWjNOV1lXeDFaU0E2SUhCdmMzUXViVzlrWlhKaGRHOXlSbXhoWjNNS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElEY3hDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1lpQmhjSEJzZVUxdlpHVnlZWFJwYjI1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEzQ2dwaGNIQnNlVTF2WkdWeVlYUnBiMjVmZEdWeWJtRnllVjltWVd4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZZMmxoYkM5dGIyUmxjbUYwYVc5dUxtRnNaMjh1ZEhNNk9USUtJQ0FnSUM4dklHTnZibk4wSUc1bGVIUkdiR0ZuWjJWa09pQmliMjlzWldGdUlEMGdkWEJrWVhSbFJteGhaMmRsWkNBL0lHWnNZV2RuWldSV1lXeDFaU0E2SUhCdmMzUXVZV2RoYVc1emRFTnZiblJsYm5SUWIyeHBZM2tLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCd2RYTm9hVzUwSURRMU5nb2dJQ0FnWjJWMFltbDBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdJZ1lYQndiSGxOYjJSbGNtRjBhVzl1WDNSbGNtNWhjbmxmYldWeVoyVkFOQW89IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRWdDQ1lLQ1dGcmFYUmhYMlJoYndGa0JuZGhiR3hsZEFoRlVsSTZUa1JCVHdoRlVsSTZUazFQUkFRVkgzeDFBVzRCQUFkMlpYSnphVzl1Q0VWU1VqcEZRVU5VZ0FUcWtZRGROaG9BamdFQWd6RVpGRVF4R0VFQWJJSU9CTXpadU5NRUErT3JJZ1I2Z3p0QUJLRFNNaDBFWWR6Uzd3UjVZT3AyQlB2MDNUVUUybXJjMlFUeFNTdjBCSVFtbkhnRWNTN29Jd1FmUEdHTUJEUHBMSlFFaFUzdDREWWFBSTRPQUVFQWZRQ3dBUElCS1FGSkFXa0JsQUhXQWcwQ1BBSlhBdE1BQVFBalE0QUV6WnJXZmpZYUFJNEJBQTBBTVJtQkJCSXhHQkJFUWdKck5ob0JTU0paZ1FJSVN3RVZFa1JYQWdBMkdnSkpGU1VTUkJjbkNFOENaeWhNWnlORElqWWFBVWtWSkJKRU1RQWlLR1ZFS21WSWNnaEVFa0FBQXl1d0FDbExBVkJKUlFPOVJRRkJBQXlBQ0VWU1VqcEZUVTlFc0FCTEFTVzVTQ05ESWpZYUFVa1ZKQkpFTVFBaUtHVkVLbVZJY2doRUVrQUFBeXV3QUNsTEFWQkpSUU85UlFGQUFBUW5CTEFBU3dHOFNDTkRJallhQVVrVkpCSkVOaG9DU1JVbEVrUVhLVEVBVUwxRkFVQUFCQ2NFc0FBbkJrc0NVRWxGQkwxRkFVRUFESUFJUlZKU09rVkNRVTZ3QUVrV1N3Tk12eU5ESWpZYUFVa1ZKQkpFS1RFQVVMMUZBVUFBQkNjRXNBQW5Ca3NCVUVsRkE3MUZBVUFBRElBSVJWSlNPazVDUVU2d0FFc0J2RWdqUXpZYUFVa1ZKQkpFS1RFQVVMMUZBVUFBQkNjRXNBQkpJMGtpU1lnQnJpTkROaG9CU1JVa0VrUXBNUUJRdlVVQlFBQUVKd1N3QUVraklrY0NpQUdPSTBNMkdnRkpGU1FTUkRZYUFra1ZKUkpFRnlreEFGQzlSUUZBQUFRbkJMQUFTd0VpU1VzREk0Z0JZeU5ESWpZYUFVa1ZKUkpFRnpZYUFra1ZnU1FTUkRFQUlpaGxSQ3BsU0hJSVJCSkFBQU1yc0FCTEFSYUFBV0ZNVUVsRkJMMUZBVUVBQkNjSnNBQkxBa3NCdnlORElqWWFBVWtWSlJKRUZ6RUFJaWhsUkNwbFNISUlSQkpBQUFNcnNBQkpGb0FCWVV4UVNVVUR2VVVCUUFBRUp3bXdBRXNCdkVnalF6WWFBVWtWSkJKRUp3Wk1VRW05UlFGQkFCaEp2a1FYTWdjTlFRQU9JeWNISWs4Q1ZDY0ZURkN3STBNaVF2L3ZOaG9CU1JVa0VrUXBURkM5UlFFbkJ5SlBBbFFuQlV4UXNDTkROaG9CU1JVa0VrUXBURkJKdlVVQlFRQVJTYjVFRnhhQUFZQk1VQ2NGVEZDd0kwT0FDUUFBQUFBQUFBQUFBRUwvNnpZYUFVa2lXWUVDQ0VzQkZSSkVWd0lBTVFBaUtHVkVLbVZJY2doRUVrQUFBeXV3QUNJb1pVU0FBM0JoYkdWSWdSQmJNZzBTUUFBTWdBaEZVbEk2U1ZWUVI3QUFKd2hMQVdjalF6WWFBVWtWSlJKRUZ6RUFJaWhsUkNwbFNISUlSQkpBQUFNcnNBQW9Td0ZuSTBPS0JRQ0FBQ0lvWlVTQUEzTmhiR1ZJSWx0SnNiSVlnQVNZdUI5NHNocUwrN0lhZ1FheUVDS3lBYk8wUGtjQ1Z3UUFTVThDVndBRUp3VVNSRWtWU3dHQlMxbEpnVTBTUkU4Q1RFc0NVaUpaZ1U4SUVrU0wvRUVBT292OWpBQ0wvMEVBS1l2K3NTY0hJb3NBVkV3V2l3R3lHSUFFVVE3ZXRySWFpL3V5R2t5eUdySWFnUWF5RUNLeUFiT0ppd0tCUjF0Qy85R0xBNEhJQTFPTUFFTC92dz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
