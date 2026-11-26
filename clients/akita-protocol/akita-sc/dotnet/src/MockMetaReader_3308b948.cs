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

namespace Arc56.Generated.akita_protocol.akita_sc.MockMetaReader_3308b948
{


    //
    // LocalNet consumer/attacker for testing the registry's cross-application boundary.
    //
    public class MockMetaReaderProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockMetaReaderProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ObjectF7E7Bd95 : AVMObjectType
            {
                public bool PublicReads { get; set; }

                public bool FamilyAccess { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPublicReads = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vPublicReads.From(PublicReads);
                    ret.AddRange(vPublicReads.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFamilyAccess = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vFamilyAccess.From(FamilyAccess);
                    ret.AddRange(vFamilyAccess.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ObjectF7E7Bd95 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ObjectF7E7Bd95();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPublicReads = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vPublicReads.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePublicReads = vPublicReads.ToValue();
                    if (valuePublicReads is bool vPublicReadsValue) { ret.PublicReads = vPublicReadsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFamilyAccess = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vFamilyAccess.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFamilyAccess = vFamilyAccess.ToValue();
                    if (valueFamilyAccess is bool vFamilyAccessValue) { ret.FamilyAccess = vFamilyAccessValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ObjectF7E7Bd95);
                }
                public bool Equals(ObjectF7E7Bd95? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ObjectF7E7Bd95 left, ObjectF7E7Bd95 right)
                {
                    return EqualityComparer<ObjectF7E7Bd95>.Default.Equals(left, right);
                }
                public static bool operator !=(ObjectF7E7Bd95 left, ObjectF7E7Bd95 right)
                {
                    return !(left == right);
                }

            }

            public class MetaRecordInfo : AVMObjectType
            {
                public bool Exists { get; set; }

                public ulong Revision { get; set; }

                public ulong Size { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vExists.From(Exists);
                    ret.AddRange(vExists.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRevision = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRevision.From(Revision);
                    ret.AddRange(vRevision.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSize.From(Size);
                    ret.AddRange(vSize.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static MetaRecordInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new MetaRecordInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vExists.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExists = vExists.ToValue();
                    if (valueExists is bool vExistsValue) { ret.Exists = vExistsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRevision = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRevision.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRevision = vRevision.ToValue();
                    if (valueRevision is ulong vRevisionValue) { ret.Revision = vRevisionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSize.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSize = vSize.ToValue();
                    if (valueSize is ulong vSizeValue) { ret.Size = vSizeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MetaRecordInfo);
                }
                public bool Equals(MetaRecordInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MetaRecordInfo left, MetaRecordInfo right)
                {
                    return EqualityComparer<MetaRecordInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(MetaRecordInfo left, MetaRecordInfo right)
                {
                    return !(left == right);
                }

            }

            public class MetaRecordRead : AVMObjectType
            {
                public bool Exists { get; set; }

                public ulong Revision { get; set; }

                public byte[] Data { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vExists.From(Exists);
                    ret.AddRange(vExists.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRevision = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRevision.From(Revision);
                    ret.AddRange(vRevision.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vData.From(Data);
                    ret.AddRange(vData.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static MetaRecordRead Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new MetaRecordRead();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vExists.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExists = vExists.ToValue();
                    if (valueExists is bool vExistsValue) { ret.Exists = vExistsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRevision = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRevision.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRevision = vRevision.ToValue();
                    if (valueRevision is ulong vRevisionValue) { ret.Revision = vRevisionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vData = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vData.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueData = vData.ToValue();
                    if (valueData is byte[] vDataValue) { ret.Data = vDataValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MetaRecordRead);
                }
                public bool Equals(MetaRecordRead? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MetaRecordRead left, MetaRecordRead right)
                {
                    return EqualityComparer<MetaRecordRead>.Default.Equals(left, right);
                }
                public static bool operator !=(MetaRecordRead left, MetaRecordRead right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registry"> </param>
        /// <param name="account"> </param>
        /// <param name="key"> </param>
        public async Task<Structs.MetaRecordRead> Read(ulong registry, Algorand.Address account, byte[] key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 61, 77, 250 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); keyAbi.From(key);

            var result = await base.SimApp(new List<object> { abiHandle, registryAbi, accountAbi, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MetaRecordRead.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Read_Transactions(ulong registry, Algorand.Address account, byte[] key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 61, 77, 250 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAbi, accountAbi, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registry"> </param>
        /// <param name="account"> </param>
        /// <param name="key"> </param>
        public async Task<Structs.MetaRecordInfo> Info(ulong registry, Algorand.Address account, byte[] key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 101, 115, 206 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); keyAbi.From(key);

            var result = await base.SimApp(new List<object> { abiHandle, registryAbi, accountAbi, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MetaRecordInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Info_Transactions(ulong registry, Algorand.Address account, byte[] key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 101, 115, 206 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAbi, accountAbi, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registry"> </param>
        /// <param name="account"> </param>
        /// <param name="key"> </param>
        /// <param name="offset"> </param>
        /// <param name="length"> </param>
        /// <param name="expectedRevision"> </param>
        public async Task<byte[]> Slice(ulong registry, Algorand.Address account, byte[] key, ulong offset, ulong length, ulong expectedRevision, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 66, 103, 10 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); keyAbi.From(key);
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lengthAbi.From(length);
            var expectedRevisionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expectedRevisionAbi.From(expectedRevision);

            var result = await base.SimApp(new List<object> { abiHandle, registryAbi, accountAbi, keyAbi, offsetAbi, lengthAbi, expectedRevisionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Slice_Transactions(ulong registry, Algorand.Address account, byte[] key, ulong offset, ulong length, ulong expectedRevision, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 66, 103, 10 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); keyAbi.From(key);
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lengthAbi.From(length);
            var expectedRevisionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expectedRevisionAbi.From(expectedRevision);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAbi, accountAbi, keyAbi, offsetAbi, lengthAbi, expectedRevisionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registry"> </param>
        /// <param name="account"> </param>
        /// <param name="key"> </param>
        public async Task<Structs.MetaRecordRead> ReadViaCall(ulong registry, Algorand.Address account, byte[] key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 150, 114, 71 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, registryAbi, accountAbi, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MetaRecordRead.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ReadViaCall_Transactions(ulong registry, Algorand.Address account, byte[] key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 150, 114, 71 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAbi, accountAbi, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registry"> </param>
        /// <param name="key"> </param>
        /// <param name="data"> </param>
        /// <param name="expectedRevision"> </param>
        public async Task<ulong> SetOwned(ulong registry, byte[] key, byte[] data, ulong expectedRevision, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 38, 50, 46 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); keyAbi.From(key);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);
            var expectedRevisionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expectedRevisionAbi.From(expectedRevision);

            var result = await base.CallApp(new List<object> { abiHandle, registryAbi, keyAbi, dataAbi, expectedRevisionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetOwned_Transactions(ulong registry, byte[] key, byte[] data, ulong expectedRevision, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 38, 50, 46 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); keyAbi.From(key);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);
            var expectedRevisionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expectedRevisionAbi.From(expectedRevision);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAbi, keyAbi, dataAbi, expectedRevisionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registry"> </param>
        /// <param name="key"> </param>
        /// <param name="data0"> </param>
        /// <param name="data1"> </param>
        /// <param name="data2"> </param>
        /// <param name="data3"> </param>
        /// <param name="expectedRevision"> </param>
        public async Task<ulong> SetOwnedParts(ulong registry, byte[] key, byte[] data0, byte[] data1, byte[] data2, byte[] data3, ulong expectedRevision, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 191, 127, 94 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); keyAbi.From(key);
            var data0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); data0Abi.From(data0);
            var data1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); data1Abi.From(data1);
            var data2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); data2Abi.From(data2);
            var data3Abi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); data3Abi.From(data3);
            var expectedRevisionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expectedRevisionAbi.From(expectedRevision);

            var result = await base.CallApp(new List<object> { abiHandle, registryAbi, keyAbi, data0Abi, data1Abi, data2Abi, data3Abi, expectedRevisionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetOwnedParts_Transactions(ulong registry, byte[] key, byte[] data0, byte[] data1, byte[] data2, byte[] data3, ulong expectedRevision, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 191, 127, 94 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); keyAbi.From(key);
            var data0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); data0Abi.From(data0);
            var data1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); data1Abi.From(data1);
            var data2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); data2Abi.From(data2);
            var data3Abi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); data3Abi.From(data3);
            var expectedRevisionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expectedRevisionAbi.From(expectedRevision);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAbi, keyAbi, data0Abi, data1Abi, data2Abi, data3Abi, expectedRevisionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registry"> </param>
        /// <param name="key"> </param>
        /// <param name="expectedRevision"> </param>
        public async Task<ulong> RemoveOwned(ulong registry, byte[] key, ulong expectedRevision, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 99, 152, 47 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); keyAbi.From(key);
            var expectedRevisionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expectedRevisionAbi.From(expectedRevision);

            var result = await base.CallApp(new List<object> { abiHandle, registryAbi, keyAbi, expectedRevisionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RemoveOwned_Transactions(ulong registry, byte[] key, ulong expectedRevision, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 99, 152, 47 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); keyAbi.From(key);
            var expectedRevisionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expectedRevisionAbi.From(expectedRevision);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAbi, keyAbi, expectedRevisionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registry"> </param>
        /// <param name="address"> </param>
        /// <param name="name"> </param>
        /// <param name="leaf"> </param>
        /// <param name="proof"> </param>
        /// <param name="type"> </param>
        public async Task<bool> Verify(ulong registry, Algorand.Address address, string name, byte[] leaf, byte[][] proof, ulong type, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 118, 141, 169 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var leafAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); leafAbi.From(leaf);
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); proofAbi.From(proof);
            var typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); typeAbi.From(type);

            var result = await base.CallApp(new List<object> { abiHandle, registryAbi, addressAbi, nameAbi, leafAbi, proofAbi, typeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Verify_Transactions(ulong registry, Algorand.Address address, string name, byte[] leaf, byte[][] proof, ulong type, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 118, 141, 169 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var leafAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); leafAbi.From(leaf);
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); proofAbi.From(proof);
            var typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); typeAbi.From(type);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAbi, addressAbi, nameAbi, leafAbi, proofAbi, typeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registry"> </param>
        /// <param name="address"> </param>
        /// <param name="name"> </param>
        /// <param name="leaf"> </param>
        /// <param name="proof"> </param>
        /// <param name="type"> </param>
        /// <param name="key"> </param>
        public async Task<string> VerifiedRead(ulong registry, Algorand.Address address, string name, byte[] leaf, byte[][] proof, ulong type, string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 219, 214, 12 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var leafAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); leafAbi.From(leaf);
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); proofAbi.From(proof);
            var typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); typeAbi.From(type);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, registryAbi, addressAbi, nameAbi, leafAbi, proofAbi, typeAbi, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> VerifiedRead_Transactions(ulong registry, Algorand.Address address, string name, byte[] leaf, byte[][] proof, ulong type, string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 219, 214, 12 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var leafAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); leafAbi.From(leaf);
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); proofAbi.From(proof);
            var typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); typeAbi.From(type);
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAbi, addressAbi, nameAbi, leafAbi, proofAbi, typeAbi, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="akitaDAO"> </param>
        /// <param name="asset"> </param>
        /// <param name="name"> </param>
        /// <param name="proof"> </param>
        public async Task<ulong> Royalty(ulong akitaDAO, ulong asset, string name, byte[][] proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 231, 197, 13 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); proofAbi.From(proof);

            var result = await base.CallApp(new List<object> { abiHandle, akitaDAOAbi, assetAbi, nameAbi, proofAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Royalty_Transactions(ulong akitaDAO, ulong asset, string name, byte[][] proof, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 231, 197, 13 };
            var akitaDAOAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); akitaDAOAbi.From(akitaDAO);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var proofAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[32]"); proofAbi.From(proof);

            return await base.MakeTransactionList(new List<object> { abiHandle, akitaDAOAbi, assetAbi, nameAbi, proofAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registry"> </param>
        public async Task<Structs.ObjectF7E7Bd95> Permissions(ulong registry, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 182, 175, 15 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);

            var result = await base.SimApp(new List<object> { abiHandle, registryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ObjectF7E7Bd95.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Permissions_Transactions(ulong registry, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 182, 175, 15 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registry"> </param>
        /// <param name="name"> </param>
        /// <param name="data"> </param>
        public async Task Write(ulong registry, byte[] name, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 232, 209, 136 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, registryAbi, nameAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Write_Transactions(ulong registry, byte[] name, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 232, 209, 136 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAbi, nameAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registry"> </param>
        /// <param name="name"> </param>
        public async Task<bool> Remove(ulong registry, byte[] name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 16, 7, 115 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, registryAbi, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Remove_Transactions(ulong registry, byte[] name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 16, 7, 115 };
            var registryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registryAbi.From(registry);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, registryAbi, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja01ldGFSZWFkZXIiLCJkZXNjIjoiTG9jYWxOZXQgY29uc3VtZXIvYXR0YWNrZXIgZm9yIHRlc3RpbmcgdGhlIHJlZ2lzdHJ5J3MgY3Jvc3MtYXBwbGljYXRpb24gYm91bmRhcnkuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdEY3RTdCRDk1IjpbeyJuYW1lIjoicHVibGljUmVhZHMiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZhbWlseUFjY2VzcyIsInR5cGUiOiJib29sIn1dLCJNZXRhUmVjb3JkSW5mbyI6W3sibmFtZSI6ImV4aXN0cyIsInR5cGUiOiJib29sIn0seyJuYW1lIjoicmV2aXNpb24iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic2l6ZSIsInR5cGUiOiJ1aW50NjQifV0sIk1ldGFSZWNvcmRSZWFkIjpbeyJuYW1lIjoiZXhpc3RzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJyZXZpc2lvbiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkYXRhIiwidHlwZSI6ImJ5dGVbXSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJyZWFkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iihib29sLHVpbnQ2NCxieXRlW10pIiwic3RydWN0IjoiTWV0YVJlY29yZFJlYWQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImluZm8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJNZXRhUmVjb3JkSW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2xpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9mZnNldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGVuZ3RoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBlY3RlZFJldmlzaW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWFkVmlhQ2FsbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCx1aW50NjQsYnl0ZVtdKSIsInN0cnVjdCI6Ik1ldGFSZWNvcmRSZWFkIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0T3duZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwZWN0ZWRSZXZpc2lvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldE93bmVkUGFydHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YTAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGExIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YTMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGVjdGVkUmV2aXNpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW1vdmVPd25lZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBlY3RlZFJldmlzaW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsZWFmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvb2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR5cGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZpZWRSZWFkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsZWFmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvb2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InR5cGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJveWFsdHkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWtpdGFEQU8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvb2YiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwZXJtaXNzaW9ucyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCxib29sKSIsInN0cnVjdCI6Ik9iamVjdEY3RTdCRDk1IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3cml0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW1vdmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMzIsNDQ4LDkzMCwxMjY1LDEzOTEsMTUzNCwxNzA1XSwiZXJyb3JNZXNzYWdlIjoiQnl0ZXMgaGFzIHZhbGlkIHByZWZpeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NF0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJNa2V5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzY5XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyck1yZXYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NDddLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyTXJuZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyMF0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJNcm5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTUxXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVyck1yc2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDRdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjI2XSwiZXJyb3JNZXNzYWdlIjoiYXNzZXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDgzLDYyOCw2NzYsODg0LDk1MCw5NzYsOTkyLDExMDMsMTExOSwxMTM1LDExNTEsMTE2NywxMjExLDEzMDAsMTMyMiwxNDI2LDE0NDgsMTQ3MiwxNTM3LDE1NzgsMTU5MywxNzA4LDE3OTMsMTgwOSwxODM4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDkwLDYzNSw2ODMsODkxLDk4Myw5OTksMTExMCwxMTI2LDExNDIsMTE1OCwxMTc0LDEyMTgsMTMwNywxNDMzLDE0NzksMTU4NCwxODAwLDE4MTYsMTg0NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzMyLDE0NTgsMTYwNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8Ynl0ZXNbMzJdPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3Nyw2MjIsNjcwLDg3OCwxMjk0LDEzMTYsMTQyMCwxNDQyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2Myw2MTIsNjU2LDY5Nyw3MDgsNzE5LDg2OCw5NjksMTAxMSwxMDk2LDExODUsMTIwNCwxMjI2LDEyODQsMTM0MCwxNDEwLDE0NjYsMTU1OSwxNTY4LDE3NTEsMTc4NiwxODMxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM5Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTU1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9tZXRhL3R5cGVzLnRzOjpNZXRhUmVjb3JkUmVhZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NDQsMTcxNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzdHJpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzcsNDUzLDEyNzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTQyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMiBvZiAoYm9vbDEsdWludDY0LChsZW4rdWludDhbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTM3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV6Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDaU53Y21GbmJXRWdZWFYwYjNOaGJIUWdabUZzYzJVS0NpOHZJRUJoYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2WVd4bmIzSmhibVF0ZEhsd1pYTmpjbWx3ZEM5aGNtTTBMMmx1WkdWNExtUXVkSE02T2tOdmJuUnlZV04wTG1Gd2NISnZkbUZzVUhKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJRGdnTWlBeElEVXdNREF3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnSW0waUlEQjRPREFnSWlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXRaWFJoTFhKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt0TVRBS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lHRjJiVlpsY25OcGIyNDZJREV6SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUVzlqYTAxbGRHRlNaV0ZrWlhJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNakFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlREJqTTJRMFpHWmhJREI0TnpnMk5UY3pZMlVnTUhnNFlqUXlOamN3WVNBd2VEVTJPVFkzTWpRM0lEQjRNell5TmpNeU1tVWdNSGhpWkdKbU4yWTFaU0F3ZURWbE5qTTVPREptSURCNFpqSTNOamhrWVRrZ01IaGpObVJpWkRZd1l5QXdlR00yWlRkak5UQmtJREI0WXpSaU5tRm1NR1lnTUhoak9HVTRaREU0T0NBd2VHSmhNVEF3TnpjeklDOHZJRzFsZEdodlpDQWljbVZoWkNoMWFXNTBOalFzWVdSa2NtVnpjeXhpZVhSbFcxMHBLR0p2YjJ3c2RXbHVkRFkwTEdKNWRHVmJYU2tpTENCdFpYUm9iMlFnSW1sdVptOG9kV2x1ZERZMExHRmtaSEpsYzNNc1lubDBaVnRkS1NoaWIyOXNMSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSnpiR2xqWlNoMWFXNTBOalFzWVdSa2NtVnpjeXhpZVhSbFcxMHNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwWW5sMFpWdGRJaXdnYldWMGFHOWtJQ0p5WldGa1ZtbGhRMkZzYkNoMWFXNTBOalFzWVdSa2NtVnpjeXhpZVhSbFcxMHBLR0p2YjJ3c2RXbHVkRFkwTEdKNWRHVmJYU2tpTENCdFpYUm9iMlFnSW5ObGRFOTNibVZrS0hWcGJuUTJOQ3hpZVhSbFcxMHNZbmwwWlZ0ZExIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5ObGRFOTNibVZrVUdGeWRITW9kV2x1ZERZMExHSjVkR1ZiWFN4aWVYUmxXMTBzWW5sMFpWdGRMR0o1ZEdWYlhTeGllWFJsVzEwc2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpY21WdGIzWmxUM2R1WldRb2RXbHVkRFkwTEdKNWRHVmJYU3gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSjJaWEpwWm5rb2RXbHVkRFkwTEdGa1pISmxjM01zYzNSeWFXNW5MR0o1ZEdWYk16SmRMR0o1ZEdWYk16SmRXMTBzZFdsdWREWTBLV0p2YjJ3aUxDQnRaWFJvYjJRZ0luWmxjbWxtYVdWa1VtVmhaQ2gxYVc1ME5qUXNZV1JrY21WemN5eHpkSEpwYm1jc1lubDBaVnN6TWwwc1lubDBaVnN6TWwxYlhTeDFhVzUwTmpRc2MzUnlhVzVuS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpY205NVlXeDBlU2gxYVc1ME5qUXNkV2x1ZERZMExITjBjbWx1Wnl4aWVYUmxXek15WFZ0ZEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWNHVnliV2x6YzJsdmJuTW9kV2x1ZERZMEtTaGliMjlzTEdKdmIyd3BJaXdnYldWMGFHOWtJQ0ozY21sMFpTaDFhVzUwTmpRc1lubDBaVnRkTEdKNWRHVmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaVzF2ZG1Vb2RXbHVkRFkwTEdKNWRHVmJYU2xpYjI5c0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2djbVZoWkNCcGJtWnZJSE5zYVdObElISmxZV1JXYVdGRFlXeHNJSE5sZEU5M2JtVmtJSE5sZEU5M2JtVmtVR0Z5ZEhNZ2NtVnRiM1psVDNkdVpXUWdkbVZ5YVdaNUlIWmxjbWxtYVdWa1VtVmhaQ0J5YjNsaGJIUjVJSEJsY20xcGMzTnBiMjV6SUhkeWFYUmxJSEpsYlc5MlpRb2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF5TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXRaWFJoTFhKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt0TVRBS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lHRjJiVlpsY25OcGIyNDZJREV6SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUVzlqYTAxbGRHRlNaV0ZrWlhJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhSaEwyWjFibU4wYVc5dWN5NTBjem82YldWMFlWSmxZMjl5WkV0bGVTaGhZMk52ZFc1ME9pQmllWFJsY3l3Z2EyVjVPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbTFsZEdGU1pXTnZjbVJMWlhrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWMFlTOW1kVzVqZEdsdmJuTXVkSE02TVRBS0lDQWdJQzh2SUdWNGNHOXlkQ0JtZFc1amRHbHZiaUJ0WlhSaFVtVmpiM0prUzJWNUtHRmpZMjkxYm5RNklFRmpZMjkxYm5Rc0lHdGxlVG9nWW5sMFpYTXBPaUJpZVhSbGN5QjdDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhSaEwyWjFibU4wYVc5dWN5NTBjem94TVFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtHdGxlUzVzWlc1bmRHZ2dQaUF3SUNZbUlHdGxlUzVzWlc1bmRHZ2dQRDBnVFdGNFVtVmpiM0prUzJWNVFubDBaWE1zSUdWeWNrbHVkbUZzYVdSTFpYa3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JpZWlCdFpYUmhVbVZqYjNKa1MyVjVYMkp2YjJ4ZlptRnNjMlZBTXdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lIQjFjMmhwYm5RZ016RUtJQ0FnSUR3OUNpQWdJQ0JpZWlCdFpYUmhVbVZqYjNKa1MyVjVYMkp2YjJ4ZlptRnNjMlZBTXdvZ0lDQWdhVzUwWTE4eklDOHZJREVLQ20xbGRHRlNaV052Y21STFpYbGZZbTl2YkY5dFpYSm5aVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsZEdFdlpuVnVZM1JwYjI1ekxuUnpPakV4Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb2EyVjVMbXhsYm1kMGFDQStJREFnSmlZZ2EyVjVMbXhsYm1kMGFDQThQU0JOWVhoU1pXTnZjbVJMWlhsQ2VYUmxjeXdnWlhKeVNXNTJZV3hwWkV0bGVTa0tJQ0FnSUdKdWVpQnRaWFJoVW1WamIzSmtTMlY1WDJGbWRHVnlYMkZ6YzJWeWRFQTJDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBsY25KTmEyVjVJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnljazFyWlhrS0NtMWxkR0ZTWldOdmNtUkxaWGxmWVdaMFpYSmZZWE56WlhKMFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVjBZUzltZFc1amRHbHZibk11ZEhNNk1USUtJQ0FnSUM4dklISmxkSFZ5YmlCaFkyTnZkVzUwTG1KNWRHVnpMbU52Ym1OaGRDaHJaWGtwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NtMWxkR0ZTWldOdmNtUkxaWGxmWW05dmJGOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYldWMFlWSmxZMjl5WkV0bGVWOWliMjlzWDIxbGNtZGxRRFFLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVjBZUzltZFc1amRHbHZibk11ZEhNNk9uSmxZV1JOWlhSaFVtVmpiM0prU1c1bWJ5aHlaV2RwYzNSeWVUb2dkV2x1ZERZMExDQmhZMk52ZFc1ME9pQmllWFJsY3l3Z2EyVjVPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbkpsWVdSTlpYUmhVbVZqYjNKa1NXNW1iem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRaWFJoTDJaMWJtTjBhVzl1Y3k1MGN6b3lOZ29nSUNBZ0x5OGdaWGh3YjNKMElHWjFibU4wYVc5dUlISmxZV1JOWlhSaFVtVmpiM0prU1c1bWJ5aHlaV2RwYzNSeWVUb2dRWEJ3YkdsallYUnBiMjRzSUdGalkyOTFiblE2SUVGalkyOTFiblFzSUd0bGVUb2dZbmwwWlhNcE9pQk5aWFJoVW1WamIzSmtTVzVtYnlCN0NpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRaWFJoTDJaMWJtTjBhVzl1Y3k1MGN6b3lOd29nSUNBZ0x5OGdZMjl1YzNRZ2FXUWdQU0J0WlhSaFVtVmpiM0prUzJWNUtHRmpZMjkxYm5Rc0lHdGxlU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUcxbGRHRlNaV052Y21STFpYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpYUmhMMloxYm1OMGFXOXVjeTUwY3pveU9Bb2dJQ0FnTHk4Z1kyOXVjM1FnYm1GdFpTQTlJRUo1ZEdWektGSmxZMjl5WkZCeVpXWnBlQ2t1WTI5dVkyRjBLR2xrS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYlNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWMFlTOW1kVzVqZEdsdmJuTXVkSE02TWprS0lDQWdJQzh2SUdOdmJuTjBJRnRzWlc1bmRHZ3NJR1Y0YVhOMGMxMGdQU0J2Y0M1QmNIQkNiM2d1YkdWdVozUm9LSEpsWjJsemRISjVMQ0J1WVcxbEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZlltOTRYMnhsYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsZEdFdlpuVnVZM1JwYjI1ekxuUnpPak13Q2lBZ0lDQXZMeUJwWmlBb0lXVjRhWE4wY3lrZ2NtVjBkWEp1SUhzZ1pYaHBjM1J6T2lCbVlXeHpaU3dnY21WMmFYTnBiMjQ2SURBc0lITnBlbVU2SURBZ2ZRb2dJQ0FnWW01NklISmxZV1JOWlhSaFVtVmpiM0prU1c1bWIxOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dweVpXRmtUV1YwWVZKbFkyOXlaRWx1Wm05ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsZEdFdlpuVnVZM1JwYjI1ekxuUnpPak14Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdleUJsZUdsemRITTZJSFJ5ZFdVc0lISmxkbWx6YVc5dU9pQmtaV052WkdWQmNtTTBQSFZwYm5RMk5ENG9iM0F1UVhCd1FtOTRMbVY0ZEhKaFkzUW9jbVZuYVhOMGNua3NJRzVoYldVc0lEQXNJRGdwS1N3Z2MybDZaVG9nYkdWdVozUm9JQzBnVW1WamIzSmtTR1ZoWkdWeVFubDBaWE1nZlFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdZWEJ3WDJKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJREV5Q2lBZ0lDQXRDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRPREFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWMFlTOW1kVzVqZEdsdmJuTXVkSE02T25ObGRFMWxkR0ZTWldOdmNtUlFZWEowY3loeVpXZHBjM1J5ZVRvZ2RXbHVkRFkwTENCclpYazZJR0o1ZEdWekxDQmtZWFJoTURvZ1lubDBaWE1zSUdSaGRHRXhPaUJpZVhSbGN5d2daR0YwWVRJNklHSjVkR1Z6TENCa1lYUmhNem9nWW5sMFpYTXNJR1Y0Y0dWamRHVmtVbVYyYVhOcGIyNDZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3B6WlhSTlpYUmhVbVZqYjNKa1VHRnlkSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1YwWVM5bWRXNWpkR2x2Ym5NdWRITTZOamd0TnpBS0lDQWdJQzh2SUdWNGNHOXlkQ0JtZFc1amRHbHZiaUJ6WlhSTlpYUmhVbVZqYjNKa1VHRnlkSE1vQ2lBZ0lDQXZMeUFnSUhKbFoybHpkSEo1T2lCQmNIQnNhV05oZEdsdmJpd2dhMlY1T2lCaWVYUmxjeXdnWkdGMFlUQTZJR0o1ZEdWekxDQmtZWFJoTVRvZ1lubDBaWE1zSUdSaGRHRXlPaUJpZVhSbGN5d2daR0YwWVRNNklHSjVkR1Z6TENCbGVIQmxZM1JsWkZKbGRtbHphVzl1T2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFwT2lCMWFXNTBOalFnZXdvZ0lDQWdjSEp2ZEc4Z055QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVjBZUzltZFc1amRHbHZibk11ZEhNNk56RUtJQ0FnSUM4dklHTnZibk4wSUhOcGVtVTZJSFZwYm5RMk5DQTlJR1JoZEdFd0xteGxibWQwYUNBcklHUmhkR0V4TG14bGJtZDBhQ0FySUdSaGRHRXlMbXhsYm1kMGFDQXJJR1JoZEdFekxteGxibWQwYUFvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ2JHVnVDaUFnSUNCa2RYQXlDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR3hsYmdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2JHVnVDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxbGRHRXZablZ1WTNScGIyNXpMblJ6T2pjeUxUYzBDaUFnSUNBdkx5QmpiMjV6ZENCamIzTjBJRDBnWVdKcFEyRnNiRHgwZVhCbGIyWWdUV1YwWVM1d2NtOTBiM1I1Y0dVdWNtVmpiM0prUTI5emRENG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2djbVZuYVhOMGNua3NJR0Z5WjNNNklGdEhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3Z2EyVjVMQ0J6YVhwbFhTd2dabVZsT2lBd0xBb2dJQ0FnTHk4Z2ZTa3VjbVYwZFhKdVZtRnNkV1VLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpYUmhMMloxYm1OMGFXOXVjeTUwY3pvM013b2dJQ0FnTHk4Z1lYQndTV1E2SUhKbFoybHpkSEo1TENCaGNtZHpPaUJiUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNJR3RsZVN3Z2MybDZaVjBzSUdabFpUb2dNQ3dLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFlLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWMFlTOW1kVzVqZEdsdmJuTXVkSE02TnpJdE56UUtJQ0FnSUM4dklHTnZibk4wSUdOdmMzUWdQU0JoWW1sRFlXeHNQSFI1Y0dWdlppQk5aWFJoTG5CeWIzUnZkSGx3WlM1eVpXTnZjbVJEYjNOMFBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQnlaV2RwYzNSeWVTd2dZWEpuY3pvZ1cwZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TENCclpYa3NJSE5wZW1WZExDQm1aV1U2SURBc0NpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRaREJpTmpJNE1ESWdMeThnYldWMGFHOWtJQ0p5WldOdmNtUkRiM04wS0dGa1pISmxjM01zWW5sMFpWdGRMSFZwYm5RMk5DbDFhVzUwTmpRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pHbG5JREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2NIVnphR2x1ZENBMklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRaWFJoTDJaMWJtTjBhVzl1Y3k1MGN6bzNNd29nSUNBZ0x5OGdZWEJ3U1dRNklISmxaMmx6ZEhKNUxDQmhjbWR6T2lCYlIyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zSUd0bGVTd2djMmw2WlYwc0lHWmxaVG9nTUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsZEdFdlpuVnVZM1JwYjI1ekxuUnpPamN5TFRjMENpQWdJQ0F2THlCamIyNXpkQ0JqYjNOMElEMGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1RXVjBZUzV3Y205MGIzUjVjR1V1Y21WamIzSmtRMjl6ZEQ0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2NtVm5hWE4wY25rc0lHRnlaM002SUZ0SGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdnYTJWNUxDQnphWHBsWFN3Z1ptVmxPaUF3TEFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUW5sMFpYTWdhR0Z6SUhaaGJHbGtJSEJ5WldacGVBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQjFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhSaEwyWjFibU4wYVc5dWN5NTBjem8zTlMwM09Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRTFsZEdFdWNISnZkRzkwZVhCbExuTmxkRkpsWTI5eVpENG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2djbVZuYVhOMGNua3NDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdHBkSGh1TG5CaGVXMWxiblFvZXlCeVpXTmxhWFpsY2pvZ2NtVm5hWE4wY25rdVlXUmtjbVZ6Y3l3Z1lXMXZkVzUwT2lCamIzTjBMQ0JtWldVNklEQWdmU2tzSUd0bGVTd2daR0YwWVRBc0lHUmhkR0V4TENCa1lYUmhNaXdnWkdGMFlUTXNJR1Y0Y0dWamRHVmtVbVYyYVhOcGIyNWRMQW9nSUNBZ0x5OGdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QjlLUzV5WlhSMWNtNVdZV3gxWlFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxkR0V2Wm5WdVkzUnBiMjV6TG5Sek9qYzNDaUFnSUNBdkx5QmhjbWR6T2lCYmFYUjRiaTV3WVhsdFpXNTBLSHNnY21WalpXbDJaWEk2SUhKbFoybHpkSEo1TG1Ga1pISmxjM01zSUdGdGIzVnVkRG9nWTI5emRDd2dabVZsT2lBd0lIMHBMQ0JyWlhrc0lHUmhkR0V3TENCa1lYUmhNU3dnWkdGMFlUSXNJR1JoZEdFekxDQmxlSEJsWTNSbFpGSmxkbWx6YVc5dVhTd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE53b2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVdSa2NtVnpjd29nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsdWRHTmZNeUF2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRaWFJoTDJaMWJtTjBhVzl1Y3k1MGN6bzNOUzAzT1FvZ0lDQWdMeThnY21WMGRYSnVJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlFMWxkR0V1Y0hKdmRHOTBlWEJsTG5ObGRGSmxZMjl5WkQ0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2NtVm5hWE4wY25rc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0cGRIaHVMbkJoZVcxbGJuUW9leUJ5WldObGFYWmxjam9nY21WbmFYTjBjbmt1WVdSa2NtVnpjeXdnWVcxdmRXNTBPaUJqYjNOMExDQm1aV1U2SURBZ2ZTa3NJR3RsZVN3Z1pHRjBZVEFzSUdSaGRHRXhMQ0JrWVhSaE1pd2daR0YwWVRNc0lHVjRjR1ZqZEdWa1VtVjJhWE5wYjI1ZExBb2dJQ0FnTHk4Z0lDQm1aV1U2SURBc0NpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ2FYUjRibDl1WlhoMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWMFlTOW1kVzVqZEdsdmJuTXVkSE02TnpjS0lDQWdJQzh2SUdGeVozTTZJRnRwZEhodUxuQmhlVzFsYm5Rb2V5QnlaV05sYVhabGNqb2djbVZuYVhOMGNua3VZV1JrY21WemN5d2dZVzF2ZFc1ME9pQmpiM04wTENCbVpXVTZJREFnZlNrc0lHdGxlU3dnWkdGMFlUQXNJR1JoZEdFeExDQmtZWFJoTWl3Z1pHRjBZVE1zSUdWNGNHVmpkR1ZrVW1WMmFYTnBiMjVkTEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDNDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRaWFJoTDJaMWJtTjBhVzl1Y3k1MGN6bzNOUzAzT1FvZ0lDQWdMeThnY21WMGRYSnVJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlFMWxkR0V1Y0hKdmRHOTBlWEJsTG5ObGRGSmxZMjl5WkQ0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2NtVm5hWE4wY25rc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0cGRIaHVMbkJoZVcxbGJuUW9leUJ5WldObGFYWmxjam9nY21WbmFYTjBjbmt1WVdSa2NtVnpjeXdnWVcxdmRXNTBPaUJqYjNOMExDQm1aV1U2SURBZ2ZTa3NJR3RsZVN3Z1pHRjBZVEFzSUdSaGRHRXhMQ0JrWVhSaE1pd2daR0YwWVRNc0lHVjRjR1ZqZEdWa1VtVjJhWE5wYjI1ZExBb2dJQ0FnTHk4Z0lDQm1aV1U2SURBc0NpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZakZsTm1RMFptSWdMeThnYldWMGFHOWtJQ0p6WlhSU1pXTnZjbVFvY0dGNUxHSjVkR1ZiWFN4aWVYUmxXMTBzWW5sMFpWdGRMR0o1ZEdWYlhTeGllWFJsVzEwc2RXbHVkRFkwS1hWcGJuUTJOQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldWMFlTOW1kVzVqZEdsdmJuTXVkSE02TnpnS0lDQWdJQzh2SUdabFpUb2dNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxkR0V2Wm5WdVkzUnBiMjV6TG5Sek9qYzFMVGM1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1RXVjBZUzV3Y205MGIzUjVjR1V1YzJWMFVtVmpiM0prUGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCeVpXZHBjM1J5ZVN3S0lDQWdJQzh2SUNBZ1lYSm5jem9nVzJsMGVHNHVjR0Y1YldWdWRDaDdJSEpsWTJWcGRtVnlPaUJ5WldkcGMzUnllUzVoWkdSeVpYTnpMQ0JoYlc5MWJuUTZJR052YzNRc0lHWmxaVG9nTUNCOUtTd2dhMlY1TENCa1lYUmhNQ3dnWkdGMFlURXNJR1JoZEdFeUxDQmtZWFJoTXl3Z1pYaHdaV04wWldSU1pYWnBjMmx2Ymwwc0NpQWdJQ0F2THlBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKNWRHVnpJR2hoY3lCMllXeHBaQ0J3Y21WbWFYZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZiV1YwWVMxeVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFc5amEwMWxkR0ZTWldGa1pYSXVjbVZoWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxZV1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJXVjBZUzF5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxkR0V2Wm5WdVkzUnBiMjV6TG5Sek9qUTRDaUFnSUNBdkx5QmpiMjV6ZENCcGJtWnZJRDBnY21WaFpFMWxkR0ZTWldOdmNtUkpibVp2S0hKbFoybHpkSEo1TENCaFkyTnZkVzUwTENCclpYa3BDaUFnSUNCallXeHNjM1ZpSUhKbFlXUk5aWFJoVW1WamIzSmtTVzVtYndvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1YwWVM5bWRXNWpkR2x2Ym5NdWRITTZORGtLSUNBZ0lDOHZJR2xtSUNnaGFXNW1ieTVsZUdsemRITXBJSEpsZEhWeWJpQjdJR1Y0YVhOMGN6b2dabUZzYzJVc0lISmxkbWx6YVc5dU9pQXdMQ0JrWVhSaE9pQkNlWFJsY3lnbkp5a2dmUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1ltNTZJSEpsWVdSZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQndiM0J1SURRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01HSXdNREF3Q2dweVpXRmtYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDIxbGRHRXZablZ1WTNScGIyNXpMblJ6T2pweVpXRmtUV1YwWVZKbFkyOXlaRUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyMWxkR0V0Y21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2NtVmhaRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVjBZUzltZFc1amRHbHZibk11ZEhNNk5UQUtJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hwYm1adkxuTnBlbVVnUEQwZ1RXRjRTVzVzYVc1bFVtVmpiM0prUW5sMFpYTXNJR1Z5Y2xKbFkyOXlaRkpsY1hWcGNtVnpVMnhwWTJVcENpQWdJQ0J3ZFhOb2FXNTBJRGtLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElERXdNalFLSUNBZ0lEdzlDaUFnSUNCaWJub2djbVZoWkY5aFpuUmxjbDloYzNObGNuUkFOUW9nSUNBZ2NIVnphR0o1ZEdWeklDSkZVbEk2WlhKeVRYSnpiQ0lLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGxjbkpOY25Oc0NncHlaV0ZrWDJGbWRHVnlYMkZ6YzJWeWRFQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxkR0V2Wm5WdVkzUnBiMjV6TG5Sek9qVXhDaUFnSUNBdkx5QmpiMjV6ZENCYmRtRnNkV1ZkSUQwZ2IzQXVRWEJ3UW05NExtZGxkQ2h5WldkcGMzUnllU3dnUW5sMFpYTW9VbVZqYjNKa1VISmxabWw0S1M1amIyNWpZWFFvYldWMFlWSmxZMjl5WkV0bGVTaGhZMk52ZFc1MExDQnJaWGtwS1NrS0lDQWdJR05oYkd4emRXSWdiV1YwWVZKbFkyOXlaRXRsZVFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYlNJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWVhCd1gySnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsZEdFdlpuVnVZM1JwYjI1ekxuUnpPalV6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdleUJsZUdsemRITTZJSFJ5ZFdVc0lISmxkbWx6YVc5dU9pQnlaV052Y21RdWNtVjJhWE5wYjI0c0lHUmhkR0U2SUhKbFkyOXlaQzVrWVhSaElIMEtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURnS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzRNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd1lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dFpYUmhMWEpsWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QnlaWFIxY200Z2NtVmhaRTFsZEdGU1pXTnZjbVFvY21WbmFYTjBjbmtzSUdGalkyOTFiblFzSUd0bGVTa0tJQ0FnSUdJZ2NtVmhaRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5dFpYUmhMMloxYm1OMGFXOXVjeTUwY3pvNmNtVmhaRTFsZEdGU1pXTnZjbVJBTmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dFpYUmhMWEpsWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcE5iMk5yVFdWMFlWSmxZV1JsY2k1cGJtWnZXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYVc1bWJ6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl0WlhSaExYSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJXVjBZUzF5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdjbVYwZFhKdUlISmxZV1JOWlhSaFVtVmpiM0prU1c1bWJ5aHlaV2RwYzNSeWVTd2dZV05qYjNWdWRDd2dhMlY1S1FvZ0lDQWdZMkZzYkhOMVlpQnlaV0ZrVFdWMFlWSmxZMjl5WkVsdVptOEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl0WlhSaExYSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNeUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZiV1YwWVMxeVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFc5amEwMWxkR0ZTWldGa1pYSXVjMnhwWTJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpiR2xqWlRvS0lDQWdJR0o1ZEdWalh6TWdMeThnSWlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXRaWFJoTFhKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JqYjNabGNpQXpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmpiM1psY2lBMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV1YwWVM5bWRXNWpkR2x2Ym5NdWRITTZNemtLSUNBZ0lDOHZJR052Ym5OMElHbHVabThnUFNCeVpXRmtUV1YwWVZKbFkyOXlaRWx1Wm04b2NtVm5hWE4wY25rc0lHRmpZMjkxYm5Rc0lHdGxlU2tLSUNBZ0lHTmhiR3h6ZFdJZ2NtVmhaRTFsZEdGU1pXTnZjbVJKYm1adkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpYUmhMMloxYm1OMGFXOXVjeTUwY3pvME1Bb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLR2x1Wm04dVpYaHBjM1J6TENCbGNuSlNaV052Y21ST2IzUkdiM1Z1WkNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0p1ZWlCemJHbGpaVjloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnY0hWemFHSjVkR1Z6SUNKRlVsSTZaWEp5VFhKdVppSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSk5jbTVtQ2dwemJHbGpaVjloWm5SbGNsOWhjM05sY25SQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFpYUmhMMloxYm1OMGFXOXVjeTUwY3pvME1Rb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLR2x1Wm04dWNtVjJhWE5wYjI0Z1BUMDlJR1Y0Y0dWamRHVmtVbVYyYVhOcGIyNHNJR1Z5Y2xKbFkyOXlaRkpsZG1semFXOXVUV2x6YldGMFkyZ3BDaUFnSUNCa2FXY2dOZ29nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBOVBRb2dJQ0FnWW01NklITnNhV05sWDJGbWRHVnlYMkZ6YzJWeWRFQTFDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrVlNVanBsY25KTmNtVjJJZ29nSUNBZ2JHOW5DaUFnSUNCbGNuSWdMeThnUlZKU09tVnljazF5WlhZS0NuTnNhV05sWDJGbWRHVnlYMkZ6YzJWeWRFQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWxkR0V2Wm5WdVkzUnBiMjV6TG5Sek9qUXlDaUFnSUNBdkx5QnNiMmRuWldSQmMzTmxjblFvYkdWdVozUm9JRHc5SUUxaGVGSmxZMjl5WkVOb2RXNXJRbmwwWlhNZ0ppWWdiMlptYzJWMElEdzlJR2x1Wm04dWMybDZaU0FtSmlCc1pXNW5kR2dnUEQwZ2FXNW1ieTV6YVhwbElDMGdiMlptYzJWMExDQmxjbkpTWldOdmNtUlNZVzVuWlNrS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJREV3TWpRS0lDQWdJRHc5Q2lBZ0lDQmllaUJ6YkdsalpWOWliMjlzWDJaaGJITmxRRGtLSUNBZ0lHUnBaeUExQ2lBZ0lDQndkWE5vYVc1MElEa0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dPQW9nSUNBZ1pHbG5JREVLSUNBZ0lENDlDaUFnSUNCaWVpQnpiR2xqWlY5aWIyOXNYMlpoYkhObFFEa0tJQ0FnSUdScFp5QTJDaUFnSUNCa2FXY2dNUW9nSUNBZ0xRb2dJQ0FnWkdsbklESUtJQ0FnSUQ0OUNpQWdJQ0JpZWlCemJHbGpaVjlpYjI5c1gyWmhiSE5sUURrS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2dwemJHbGpaVjlpYjI5c1gyMWxjbWRsUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxbGRHRXZablZ1WTNScGIyNXpMblJ6T2pReUNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9iR1Z1WjNSb0lEdzlJRTFoZUZKbFkyOXlaRU5vZFc1clFubDBaWE1nSmlZZ2IyWm1jMlYwSUR3OUlHbHVabTh1YzJsNlpTQW1KaUJzWlc1bmRHZ2dQRDBnYVc1bWJ5NXphWHBsSUMwZ2IyWm1jMlYwTENCbGNuSlNaV052Y21SU1lXNW5aU2tLSUNBZ0lHSnVlaUJ6YkdsalpWOWhablJsY2w5aGMzTmxjblJBTVRJS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09tVnljazF5Ym1jaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVRYSnVad29LYzJ4cFkyVmZZV1owWlhKZllYTnpaWEowUURFeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxbGRHRXZablZ1WTNScGIyNXpMblJ6T2pRekNpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdVFYQndRbTk0TG1WNGRISmhZM1FvY21WbmFYTjBjbmtzSUVKNWRHVnpLRkpsWTI5eVpGQnlaV1pwZUNrdVkyOXVZMkYwS0cxbGRHRlNaV052Y21STFpYa29ZV05qYjNWdWRDd2dhMlY1S1Nrc0lGSmxZMjl5WkVobFlXUmxja0o1ZEdWeklDc2diMlptYzJWMExDQnNaVzVuZEdncENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTJGc2JITjFZaUJ0WlhSaFVtVmpiM0prUzJWNUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKdElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9hVzUwSURFeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmhjSEJmWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXRaWFJoTFhKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwemJHbGpaVjlpYjI5c1gyWmhiSE5sUURrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ6YkdsalpWOWliMjlzWDIxbGNtZGxRREV3Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDIxbGRHRXRjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rMXZZMnROWlhSaFVtVmhaR1Z5TG5KbFlXUldhV0ZEWVd4c1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZoWkZacFlVTmhiR3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJXVjBZUzF5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNd29nSUNBZ0x5OGdjSFZpYkdsaklISmxZV1JXYVdGRFlXeHNLSEpsWjJsemRISjVPaUJCY0hCc2FXTmhkR2x2Yml3Z1lXTmpiM1Z1ZERvZ1FXTmpiM1Z1ZEN3Z2EyVjVPaUJpZVhSbGN5azZJRTFsZEdGU1pXTnZjbVJTWldGa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhSaEwyWjFibU4wYVc5dWN5NTBjem8xT0FvZ0lDQWdMeThnY21WMGRYSnVJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlFMWxkR0V1Y0hKdmRHOTBlWEJsTG5KbFlXUlNaV052Y21RK0tIc2dZWEJ3U1dRNklISmxaMmx6ZEhKNUxDQmhjbWR6T2lCYllXTmpiM1Z1ZEN3Z2EyVjVYU3dnWm1WbE9pQXdJSDBwTG5KbGRIVnlibFpoYkhWbENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROVEF4WkRObFlqSWdMeThnYldWMGFHOWtJQ0p5WldGa1VtVmpiM0prS0dGa1pISmxjM01zWW5sMFpWdGRLU2hpYjI5c0xIVnBiblEyTkN4aWVYUmxXMTBwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBd0lEUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJDZVhSbGN5Qm9ZWE1nZG1Gc2FXUWdjSEpsWm1sNENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdPUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeUlHOW1JQ2hpYjI5c01TeDFhVzUwTmpRc0tHeGxiaXQxYVc1ME9GdGRLU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNVE1LSUNBZ0lDc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhSaEwzUjVjR1Z6TG5Sek9qcE5aWFJoVW1WamIzSmtVbVZoWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyMWxkR0V0Y21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJSEIxWW14cFl5QnlaV0ZrVm1saFEyRnNiQ2h5WldkcGMzUnllVG9nUVhCd2JHbGpZWFJwYjI0c0lHRmpZMjkxYm5RNklFRmpZMjkxYm5Rc0lHdGxlVG9nWW5sMFpYTXBPaUJOWlhSaFVtVmpiM0prVW1WaFpDQjdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjFsZEdFdGNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxdlkydE5aWFJoVW1WaFpHVnlMbk5sZEU5M2JtVmtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFQzZHVaV1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJXVjBZUzF5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdjSFZpYkdsaklITmxkRTkzYm1Wa0tISmxaMmx6ZEhKNU9pQkJjSEJzYVdOaGRHbHZiaXdnYTJWNU9pQmllWFJsY3l3Z1pHRjBZVG9nWW5sMFpYTXNJR1Y0Y0dWamRHVmtVbVYyYVhOcGIyNDZJSFZwYm5RMk5DazZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUjFjQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxbGRHRXZablZ1WTNScGIyNXpMblJ6T2pZekNpQWdJQ0F2THlCamIyNXpkQ0JtYVhKemREb2dkV2x1ZERZMElEMGdaR0YwWVM1c1pXNW5kR2dnUENCTllYaFNaV052Y21SUVlYSjBRbmwwWlhNZ1B5QmtZWFJoTG14bGJtZDBhQ0E2SUUxaGVGSmxZMjl5WkZCaGNuUkNlWFJsY3dvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05EQTVOQW9nSUNBZ1BBb2dJQ0FnWW5vZ2MyVjBUM2R1WldSZmRHVnlibUZ5ZVY5bVlXeHpaVUF6Q2lBZ0lDQmtkWEFLQ25ObGRFOTNibVZrWDNSbGNtNWhjbmxmYldWeVoyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRaWFJoTDJaMWJtTjBhVzl1Y3k1MGN6bzJOQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxkRTFsZEdGU1pXTnZjbVJRWVhKMGN5aHlaV2RwYzNSeWVTd2dhMlY1TENCa1lYUmhMbk5zYVdObEtEQXNJR1pwY25OMEtTd2daR0YwWVM1emJHbGpaU2htYVhKemRDa3NJRUo1ZEdWektDY25LU3dnUW5sMFpYTW9KeWNwTENCbGVIQmxZM1JsWkZKbGRtbHphVzl1S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBK1BRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1JwWnlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXpDaUFnSUNBK1BRb2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaWVYUmxZMTh6SUM4dklDSWlDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMkZzYkhOMVlpQnpaWFJOWlhSaFVtVmpiM0prVUdGeWRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl0WlhSaExYSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCd2RXSnNhV01nYzJWMFQzZHVaV1FvY21WbmFYTjBjbms2SUVGd2NHeHBZMkYwYVc5dUxDQnJaWGs2SUdKNWRHVnpMQ0JrWVhSaE9pQmllWFJsY3l3Z1pYaHdaV04wWldSU1pYWnBjMmx2YmpvZ2RXbHVkRFkwS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuTmxkRTkzYm1Wa1gzUmxjbTVoY25sZlptRnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WlhSaEwyWjFibU4wYVc5dWN5NTBjem8yTXdvZ0lDQWdMeThnWTI5dWMzUWdabWx5YzNRNklIVnBiblEyTkNBOUlHUmhkR0V1YkdWdVozUm9JRHdnVFdGNFVtVmpiM0prVUdGeWRFSjVkR1Z6SUQ4Z1pHRjBZUzVzWlc1bmRHZ2dPaUJOWVhoU1pXTnZjbVJRWVhKMFFubDBaWE1LSUNBZ0lIQjFjMmhwYm5RZ05EQTVOQW9nSUNBZ1lpQnpaWFJQZDI1bFpGOTBaWEp1WVhKNVgyMWxjbWRsUURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJXVjBZUzF5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUVzlqYTAxbGRHRlNaV0ZrWlhJdWMyVjBUM2R1WldSUVlYSjBjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRFOTNibVZrVUdGeWRITTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012YldWMFlTMXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z2NIVmliR2xqSUhObGRFOTNibVZrVUdGeWRITW9jbVZuYVhOMGNuazZJRUZ3Y0d4cFkyRjBhVzl1TENCclpYazZJR0o1ZEdWekxDQmtZWFJoTURvZ1lubDBaWE1zSUdSaGRHRXhPaUJpZVhSbGN5d2daR0YwWVRJNklHSjVkR1Z6TENCa1lYUmhNem9nWW5sMFpYTXNJR1Y0Y0dWamRHVmtVbVYyYVhOcGIyNDZJSFZwYm5RMk5DazZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURjS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl0WlhSaExYSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWMFRXVjBZVkpsWTI5eVpGQmhjblJ6S0hKbFoybHpkSEo1TENCclpYa3NJR1JoZEdFd0xDQmtZWFJoTVN3Z1pHRjBZVElzSUdSaGRHRXpMQ0JsZUhCbFkzUmxaRkpsZG1semFXOXVLUW9nSUNBZ1kyRnNiSE4xWWlCelpYUk5aWFJoVW1WamIzSmtVR0Z5ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXRaWFJoTFhKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMlYwVDNkdVpXUlFZWEowY3loeVpXZHBjM1J5ZVRvZ1FYQndiR2xqWVhScGIyNHNJR3RsZVRvZ1lubDBaWE1zSUdSaGRHRXdPaUJpZVhSbGN5d2daR0YwWVRFNklHSjVkR1Z6TENCa1lYUmhNam9nWW5sMFpYTXNJR1JoZEdFek9pQmllWFJsY3l3Z1pYaHdaV04wWldSU1pYWnBjMmx2YmpvZ2RXbHVkRFkwS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJXVjBZUzF5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUVzlqYTAxbGRHRlNaV0ZrWlhJdWNtVnRiM1psVDNkdVpXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlcxdmRtVlBkMjVsWkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXRaWFJoTFhKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEyQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjbVZ0YjNabFQzZHVaV1FvY21WbmFYTjBjbms2SUVGd2NHeHBZMkYwYVc5dUxDQnJaWGs2SUdKNWRHVnpMQ0JsZUhCbFkzUmxaRkpsZG1semFXOXVPaUIxYVc1ME5qUXBPaUIxYVc1ME5qUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsZEdFdlpuVnVZM1JwYjI1ekxuUnpPamcwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1RXVjBZUzV3Y205MGIzUjVjR1V1Y21WdGIzWmxVbVZqYjNKa1BpaDdJR0Z3Y0Vsa09pQnlaV2RwYzNSeWVTd2dZWEpuY3pvZ1cydGxlU3dnWlhod1pXTjBaV1JTWlhacGMybHZibDBzSUdabFpUb2dNQ0I5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUzWkROa01EVmlJQzh2SUcxbGRHaHZaQ0FpY21WdGIzWmxVbVZqYjNKa0tHSjVkR1ZiWFN4MWFXNTBOalFwZFdsdWREWTBJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNlWFJsY3lCb1lYTWdkbUZzYVdRZ2NISmxabWw0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDIxbGRHRXRjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklIQjFZbXhwWXlCeVpXMXZkbVZQZDI1bFpDaHlaV2RwYzNSeWVUb2dRWEJ3YkdsallYUnBiMjRzSUd0bGVUb2dZbmwwWlhNc0lHVjRjR1ZqZEdWa1VtVjJhWE5wYjI0NklIVnBiblEyTkNrNklIVnBiblEyTkNCN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyMWxkR0V0Y21WaFpHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazF2WTJ0TlpYUmhVbVZoWkdWeUxuWmxjbWxtZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXRaWFJoTFhKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkbVZ5YVdaNUtISmxaMmx6ZEhKNU9pQkJjSEJzYVdOaGRHbHZiaXdnWVdSa2NtVnpjem9nUVdOamIzVnVkQ3dnYm1GdFpUb2djM1J5YVc1bkxDQnNaV0ZtT2lCTVpXRm1MQ0J3Y205dlpqb2dVSEp2YjJZc0lIUjVjR1U2SUhWcGJuUTJOQ2s2SUdKdmIyeGxZVzRnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aWVYUmxjMXN6TWwwK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXVjBZUzltZFc1amRHbHZibk11ZEhNNk9Ea0tJQ0FnSUM4dklISmxkSFZ5YmlCaFltbERZV3hzUEhSNWNHVnZaaUJOWlhSaExuQnliM1J2ZEhsd1pTNTJaWEpwWm5rK0tIc2dZWEJ3U1dRNklISmxaMmx6ZEhKNUxDQmhjbWR6T2lCYllXUmtjbVZ6Y3l3Z2JtRnRaU3dnYkdWaFppd2djSEp2YjJZc0lIUjVjR1ZkTENCbVpXVTZJREFnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5WW1ZelkyTTFZU0F2THlCdFpYUm9iMlFnSW5abGNtbG1lU2hoWkdSeVpYTnpMSE4wY21sdVp5eGllWFJsV3pNeVhTeGllWFJsV3pNeVhWdGRMSFZwYm5RMk5DbGliMjlzSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBd0lEUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJDZVhSbGN5Qm9ZWE1nZG1Gc2FXUWdjSEpsWm1sNENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHSnZiMndLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dFpYUmhMWEpsWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QndkV0pzYVdNZ2RtVnlhV1o1S0hKbFoybHpkSEo1T2lCQmNIQnNhV05oZEdsdmJpd2dZV1JrY21WemN6b2dRV05qYjNWdWRDd2dibUZ0WlRvZ2MzUnlhVzVuTENCc1pXRm1PaUJNWldGbUxDQndjbTl2WmpvZ1VISnZiMllzSUhSNWNHVTZJSFZwYm5RMk5DazZJR0p2YjJ4bFlXNGdld29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl0WlhSaExYSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwTmIyTnJUV1YwWVZKbFlXUmxjaTUyWlhKcFptbGxaRkpsWVdSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJaWEpwWm1sbFpGSmxZV1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJXVjBZUzF5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOQW9nSUNBZ0x5OGdjSFZpYkdsaklIWmxjbWxtYVdWa1VtVmhaQ2h5WldkcGMzUnllVG9nUVhCd2JHbGpZWFJwYjI0c0lHRmtaSEpsYzNNNklFRmpZMjkxYm5Rc0lHNWhiV1U2SUhOMGNtbHVaeXdnYkdWaFpqb2dUR1ZoWml3Z2NISnZiMlk2SUZCeWIyOW1MQ0IwZVhCbE9pQjFhVzUwTmpRc0lHdGxlVG9nYzNSeWFXNW5LVG9nYzNSeWFXNW5JSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WW5sMFpYTmJNekpkUGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ053b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFsZEdFdlpuVnVZM1JwYjI1ekxuUnpPamswQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1RXVjBZUzV3Y205MGIzUjVjR1V1ZG1WeWFXWnBaV1JTWldGa1BpaDdJR0Z3Y0Vsa09pQnlaV2RwYzNSeWVTd2dZWEpuY3pvZ1cyRmtaSEpsYzNNc0lHNWhiV1VzSUd4bFlXWXNJSEJ5YjI5bUxDQjBlWEJsTENCclpYbGRMQ0JtWldVNklEQWdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dZMll4WWpsalppQXZMeUJ0WlhSb2IyUWdJblpsY21sbWFXVmtVbVZoWkNoaFpHUnlaWE56TEhOMGNtbHVaeXhpZVhSbFd6TXlYU3hpZVhSbFd6TXlYVnRkTEhWcGJuUTJOQ3h6ZEhKcGJtY3BjM1J5YVc1bklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2NIVnphR2x1ZENBMklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQ2VYUmxjeUJvWVhNZ2RtRnNhV1FnY0hKbFptbDRDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnYzNSeWFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012YldWMFlTMXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhabGNtbG1hV1ZrVW1WaFpDaHlaV2RwYzNSeWVUb2dRWEJ3YkdsallYUnBiMjRzSUdGa1pISmxjM002SUVGalkyOTFiblFzSUc1aGJXVTZJSE4wY21sdVp5d2diR1ZoWmpvZ1RHVmhaaXdnY0hKdmIyWTZJRkJ5YjI5bUxDQjBlWEJsT2lCMWFXNTBOalFzSUd0bGVUb2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNeUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZiV1YwWVMxeVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFc5amEwMWxkR0ZTWldGa1pYSXVjbTk1WVd4MGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkp2ZVdGc2RIazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjFsZEdFdGNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUhCMVlteHBZeUJ5YjNsaGJIUjVLR0ZyYVhSaFJFRlBPaUJCY0hCc2FXTmhkR2x2Yml3Z1lYTnpaWFE2SUVGemMyVjBMQ0J1WVcxbE9pQnpkSEpwYm1jc0lIQnliMjltT2lCUWNtOXZaaWs2SUhWcGJuUTJOQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0o1ZEdWeld6TXlYVDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZOalUzQ2lBZ0lDQXZMeUJzWlhRZ1kzSmxZWFJ2Y2xKdmVXRnNkSGs2SUhWcGJuUTJOQ0E5SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pZMU9Rb2dJQ0FnTHk4Z2FXWWdLQ0VvY0hKdmIyWXViR1Z1WjNSb0lENGdNQ2twSUhzS0lDQWdJR0p1ZWlCeWIzbGhiSFI1WDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ2NHOXdiaUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalkyTUFvZ0lDQWdMeThnY21WMGRYSnVJRU55WldGMGIzSlNiM2xoYkhSNVJHVm1ZWFZzZEFvZ0lDQWdjSFZ6YUdsdWRDQTFNREF3Q2dweWIzbGhiSFI1WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzZjbTk1WVd4MGFXVnpRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJXVjBZUzF5WldGa1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPQW9nSUNBZ0x5OGdjSFZpYkdsaklISnZlV0ZzZEhrb1lXdHBkR0ZFUVU4NklFRndjR3hwWTJGMGFXOXVMQ0JoYzNObGREb2dRWE56WlhRc0lHNWhiV1U2SUhOMGNtbHVaeXdnY0hKdmIyWTZJRkJ5YjI5bUtUb2dkV2x1ZERZMElIc0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNeUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbkp2ZVdGc2RIbGZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvMk5qVXROamMxQ2lBZ0lDQXZMeUJqYjI1emRDQmpjbVZoZEc5eVVtOTVZV3gwZVZOMGNtbHVaeUE5SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRTFsZEdFdWNISnZkRzkwZVhCbExuWmxjbWxtYVdWa1RYVnpkRkpsWVdRK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklHZGxkRUZyYVhSaFFYQndUR2x6ZENoaGEybDBZVVJCVHlrdWJXVjBZVTFsY210c1pYTXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGc0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRDNWpjbVZoZEc5eUxBb2dJQ0FnTHk4Z0lDQWdJRzVoYldVc0NpQWdJQ0F2THlBZ0lDQWdjMmhoTWpVMktITm9ZVEkxTmlocGRHOWlLR0Z6YzJWMExtbGtLU2twTEFvZ0lDQWdMeThnSUNBZ0lIQnliMjltTEFvZ0lDQWdMeThnSUNBZ0lERXNDaUFnSUNBdkx5QWdJQ0FnSjNKdmVXRnNkSGtuTEFvZ0lDQWdMeThnSUNCZENpQWdJQ0F2THlCOUtTNXlaWFIxY201V1lXeDFaUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNWMGFXeHpMMloxYm1OMGFXOXVjeTUwY3pvMk5qZ0tJQ0FnSUM4dklHRnpjMlYwTG1OeVpXRjBiM0lzQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlYwWDNCaGNtRnRjMTluWlhRZ1FYTnpaWFJEY21WaGRHOXlDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWFFnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qWTNNQW9nSUNBZ0x5OGdjMmhoTWpVMktITm9ZVEkxTmlocGRHOWlLR0Z6YzJWMExtbGtLU2twTEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdjMmhoTWpVMkNpQWdJQ0J6YUdFeU5UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5qY3lDaUFnSUNBdkx5QXhMQW9nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qQTJDaUFnSUNBdkx5QmpiMjV6ZENCYllYQndUR2x6ZEVKNWRHVnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLR0ZyYVhSaFJFRlBMQ0JDZVhSbGN5aEJhMmwwWVVSQlQwZHNiMkpoYkZOMFlYUmxTMlY1YzBGcmFYUmhRWEJ3VEdsemRDa3BDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJSEIxYzJoaWVYUmxjeUFpWVdGc0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzJOallLSUNBZ0lDOHZJR0Z3Y0Vsa09pQm5aWFJCYTJsMFlVRndjRXhwYzNRb1lXdHBkR0ZFUVU4cExtMWxkR0ZOWlhKcmJHVnpMQW9nSUNBZ2NIVnphR2x1ZENBM01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzJOalV0TmpjMUNpQWdJQ0F2THlCamIyNXpkQ0JqY21WaGRHOXlVbTk1WVd4MGVWTjBjbWx1WnlBOUlHRmlhVU5oYkd3OGRIbHdaVzltSUUxbGRHRXVjSEp2ZEc5MGVYQmxMblpsY21sbWFXVmtUWFZ6ZEZKbFlXUStLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJR2RsZEVGcmFYUmhRWEJ3VEdsemRDaGhhMmwwWVVSQlR5a3ViV1YwWVUxbGNtdHNaWE1zQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnNLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkQzVqY21WaGRHOXlMQW9nSUNBZ0x5OGdJQ0FnSUc1aGJXVXNDaUFnSUNBdkx5QWdJQ0FnYzJoaE1qVTJLSE5vWVRJMU5paHBkRzlpS0dGemMyVjBMbWxrS1NrcExBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjI5bUxBb2dJQ0FnTHk4Z0lDQWdJREVzQ2lBZ0lDQXZMeUFnSUNBZ0ozSnZlV0ZzZEhrbkxBb2dJQ0FnTHk4Z0lDQmRDaUFnSUNBdkx5QjlLUzV5WlhSMWNtNVdZV3gxWlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVdabU4yTTNOR01nTHk4Z2JXVjBhRzlrSUNKMlpYSnBabWxsWkUxMWMzUlNaV0ZrS0dGa1pISmxjM01zYzNSeWFXNW5MR0o1ZEdWYk16SmRMR0o1ZEdWYk16SmRXMTBzZFdsdWREWTBMSE4wY21sdVp5bHpkSEpwYm1jaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem8yTnpNS0lDQWdJQzh2SUNkeWIzbGhiSFI1Snl3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EYzNNalptTnprMk1UWmpOelEzT1FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk5qWTFMVFkzTlFvZ0lDQWdMeThnWTI5dWMzUWdZM0psWVhSdmNsSnZlV0ZzZEhsVGRISnBibWNnUFNCaFltbERZV3hzUEhSNWNHVnZaaUJOWlhSaExuQnliM1J2ZEhsd1pTNTJaWEpwWm1sbFpFMTFjM1JTWldGa1BpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQm5aWFJCYTJsMFlVRndjRXhwYzNRb1lXdHBkR0ZFUVU4cExtMWxkR0ZOWlhKcmJHVnpMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUXVZM0psWVhSdmNpd0tJQ0FnSUM4dklDQWdJQ0J1WVcxbExBb2dJQ0FnTHk4Z0lDQWdJSE5vWVRJMU5paHphR0V5TlRZb2FYUnZZaWhoYzNObGRDNXBaQ2twS1N3S0lDQWdJQzh2SUNBZ0lDQndjbTl2Wml3S0lDQWdJQzh2SUNBZ0lDQXhMQW9nSUNBZ0x5OGdJQ0FnSUNkeWIzbGhiSFI1Snl3S0lDQWdJQzh2SUNBZ1hRb2dJQ0FnTHk4Z2ZTa3VjbVYwZFhKdVZtRnNkV1VLSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJREFnTkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFSjVkR1Z6SUdoaGN5QjJZV3hwWkNCd2NtVm1hWGdLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhOMGNtbHVad29nSUNBZ1pYaDBjbUZqZENBMklEQUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qWTNOd29nSUNBZ0x5OGdhV1lnS0VKNWRHVnpLR055WldGMGIzSlNiM2xoYkhSNVUzUnlhVzVuS1M1c1pXNW5kR2dnUGlBd0tTQjdDaUFnSUNCc1pXNEtJQ0FnSUdKNklISnZlV0ZzZEhsZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPalkzT0FvZ0lDQWdMeThnWTNKbFlYUnZjbEp2ZVdGc2RIa2dQU0JpZEc5cEtFSjVkR1Z6S0dOeVpXRjBiM0pTYjNsaGJIUjVVM1J5YVc1bktTa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWRHOXBDaUFnSUNCaWRYSjVJREVLQ25KdmVXRnNkSGxmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzJPREVLSUNBZ0lDOHZJR2xtSUNoamNtVmhkRzl5VW05NVlXeDBlU0ErSUVOeVpXRjBiM0pTYjNsaGJIUjVUV0Y0YVcxMWJWTnBibWRzWlNrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEUWdMeThnTlRBd01EQUtJQ0FnSUQ0S0lDQWdJR0o2SUhKdmVXRnNkSGxmWVdaMFpYSmZhV1pmWld4elpVQTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qWTRNZ29nSUNBZ0x5OGdjbVYwZFhKdUlFTnlaV0YwYjNKU2IzbGhiSFI1VFdGNGFXMTFiVk5wYm1kc1pRb2dJQ0FnYVc1MFl5QTBJQzh2SURVd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012YldWMFlTMXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhKdmVXRnNkR2xsY3loaGEybDBZVVJCVHl3Z1lYTnpaWFFzSUc1aGJXVXNJSEJ5YjI5bUtRb2dJQ0FnWWlCeWIzbGhiSFI1WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzZjbTk1WVd4MGFXVnpRRGdLQ25KdmVXRnNkSGxmWVdaMFpYSmZhV1pmWld4elpVQTNPZ29nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012YldWMFlTMXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhKdmVXRnNkR2xsY3loaGEybDBZVVJCVHl3Z1lYTnpaWFFzSUc1aGJXVXNJSEJ5YjI5bUtRb2dJQ0FnWWlCeWIzbGhiSFI1WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6bzZjbTk1WVd4MGFXVnpRRGdLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012YldWMFlTMXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlRXOWphMDFsZEdGU1pXRmtaWEl1Y0dWeWJXbHpjMmx2Ym5OYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdaWEp0YVhOemFXOXVjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dFpYUmhMWEpsWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXRaWFJoTFhKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkwQ2lBZ0lDQXZMeUJqYjI1emRDQmJjSFZpYkdsalVtVmhaSE5kSUQwZ2IzQXVRWEJ3VUdGeVlXMXpMbUZ3Y0VadmNtVnBaMjVDYjNoU1pXRmtjeWh5WldkcGMzUnllU2tLSUNBZ0lHUjFjQW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1JtOXlaV2xuYmtKdmVGSmxZV1J6Q2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dFpYUmhMWEpsWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QmpiMjV6ZENCYlptRnRhV3g1UVdOalpYTnpYU0E5SUc5d0xrRndjRkJoY21GdGN5NWhjSEJHWVcxcGJIbENiM2hCWTJObGMzTW9jbVZuYVhOMGNua3BDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCR1lXMXBiSGxDYjNoQlkyTmxjM01LSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDIxbGRHRXRjbVZoWkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklISmxkSFZ5YmlCN0lIQjFZbXhwWTFKbFlXUnpMQ0JtWVcxcGJIbEJZMk5sYzNNZ2ZRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012YldWMFlTMXlaV0ZrWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjFsZEdFdGNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxdlkydE5aWFJoVW1WaFpHVnlMbmR5YVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkM0pwZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZiV1YwWVMxeVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnY0hWaWJHbGpJSGR5YVhSbEtISmxaMmx6ZEhKNU9pQkJjSEJzYVdOaGRHbHZiaXdnYm1GdFpUb2dZbmwwWlhNc0lHUmhkR0U2SUdKNWRHVnpLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dFpYUmhMWEpsWVdSbGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QnZjQzVCY0hCQ2IzZ3VjSFYwS0hKbFoybHpkSEo1TENCdVlXMWxMQ0JrWVhSaEtRb2dJQ0FnWVhCd1gySnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXRaWFJoTFhKbFlXUmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalk1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkM0pwZEdVb2NtVm5hWE4wY25rNklFRndjR3hwWTJGMGFXOXVMQ0J1WVcxbE9pQmllWFJsY3l3Z1pHRjBZVG9nWW5sMFpYTXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNeUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZiV1YwWVMxeVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VFc5amEwMWxkR0ZTWldGa1pYSXVjbVZ0YjNabFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZ0YjNabE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjFsZEdFdGNtVmhaR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpNS0lDQWdJQzh2SUhCMVlteHBZeUJ5WlcxdmRtVW9jbVZuYVhOMGNuazZJRUZ3Y0d4cFkyRjBhVzl1TENCdVlXMWxPaUJpZVhSbGN5azZJR0p2YjJ4bFlXNGdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl0WlhSaExYSmxZV1JsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMENpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdVFYQndRbTk0TG1SbGJHVjBaU2h5WldkcGMzUnllU3dnYm1GdFpTa0tJQ0FnSUdGd2NGOWliM2hmWkdWc0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZiV1YwWVMxeVpXRmtaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTXdvZ0lDQWdMeThnY0hWaWJHbGpJSEpsYlc5MlpTaHlaV2RwYzNSeWVUb2dRWEJ3YkdsallYUnBiMjRzSUc1aGJXVTZJR0o1ZEdWektUb2dZbTl2YkdWaGJpQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFekNpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2lOd2NtRm5iV0VnWVhWMGIzTmhiSFFnWm1Gc2MyVUtDaTh2SUVCaGJHZHZjbUZ1WkdadmRXNWtZWFJwYjI0dllXeG5iM0poYm1RdGRIbHdaWE5qY21sd2RDOWlZWE5sTFdOdmJuUnlZV04wTG1RdWRITTZPa0poYzJWRGIyNTBjbUZqZEM1amJHVmhjbE4wWVhSbFVISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkRTQUZBQWdDQWRDR0F5WUVCQlVmZkhVQmJRR0FBREViUWRRQk1Sa1VSREVZUklJTkJBdzlUZm9FZUdWenpnU0xRbWNLQkZhV2NrY0VOaVl5TGdTOXYzOWVCRjVqbUM4RThuYU5xUVRHMjlZTUJNYm54UTBFeExhdkR3VEk2TkdJQkxvUUIzTTJHZ0NPRFFGRUFka0NCQUxaQXo0RHZRUXBCSGtFOXdXTEJrd0did2FjQURFWkZERVlGQkJEaWdJQmkvOFZTVUZBaXdDQkh3NUJNaVZBSG9BTFJWSlNPbVZ5Y2sxclpYbXdBSXYraS85UVRJa2lRakdLQXdHTC9vdi9pR1VwVEZCSmkvMU0xQVZBTElBUkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDTUFJbUwvVThDSWlQVUFoZE1nUXdKVEJZcVRGQk1GbENKaWdjQmkvc1ZpL3dWU2dpTC9SVk1Td0VJaS80VlRFc0JDTEV5Q292NkZSWlhCZ0tMK2xCUEFoYUwrYklZZ0FUUXRpZ0NzaHBQQXJJYVN3R3lHcklhZ1FheUVDS3lBYk8wUGtsWEJBQk1Wd0FFS0JKRVNSVWpFa1FYc1l2NWNnaEVzZ2V5Q0NXeUVDS3lBYlpQQkJaWEJnS0wrMUJQQkJaWEJnS0wvRkJQQkJaWEJnS0wvVkJQQkJaWEJnS0wvbENML3hhTCtiSVlnQVN4NXRUN3NocFBCYklhVHdTeUdrOERzaHBQQXJJYVRMSWFzaHFCQnJJUUlySUJzN1ErU1ZjRUFFeFhBQVFvRWtSSkZTTVNSQmVKTmhvQlNSVWpFa1FYU1RZYUFrbE9Ba2tWZ1NBU1JEWWFBMGtpV1NRSVN3RVZFa1JYQWdCSlRnT0k3d1JKSWxOQUxrWUVnQTBBQUFBQUFBQUFBQUFBQ3dBQUtFeFFzQ1ZEZ1FsYmdZQUlEa0FlZ0F0RlVsSTZaWEp5VFhKemJMQUFpTFVHS1V4UTFBWklTVmNBQ0VzQkkxbExBaFZQQTA0Q1VsY0NBQ3BQQWxCTEFSVVdWd1lDVHdKUVRJQUNBQXRRVEZCQ253RTJHZ0ZKRlNNU1JCYzJHZ0pKRllFZ0VrUTJHZ05KSWxra0NFc0JGUkpFVndJQWlJc0hLRXhRc0NWREt6WWFBVWtWSXhKRUYwazJHZ0pKVGdKSkZZRWdFa1EyR2dOSklsa2tDRXNCRlJKRVZ3SUFTVTRETmhvRVNSVWpFa1FYVGdNMkdnVkpGU01TUkJkT0JEWWFCa2tWSXhKRUYwNERpTE1JU1U0SElsTkFIb0FMUlZKU09tVnljazF5Ym1hd0FFc0dKVnNTUUI2QUMwVlNVanBsY25KTmNtVjJzQUJMQVlHQUNBNUJuZ0ZMQllFSlcwbEZDRXNCRDBHQ0FVc0dTd0VKU3dJUFFXNGxRQjZBQzBWU1VqcGxjbkpOY201bnNBQlBBMDhEaU5jS0tVeFFnUXhQQWdoUEEwNENUd1BVQWtrVkZsY0dBa3hRS0V4UXNDVkRJa0p0TmhvQlNSVWpFa1FYTmhvQ1NSV0JJQkpFTmhvRFNTSlpKQWhMQVJVU1JMRlBBcklZZ0FSUUhUNnlzaHBNc2hxeUdvRUdzaEFpc2dHenRENUpWd1FBVEZjQUJDZ1NSRWtWU3dHQkNWbEpnUXNTUkVzQ1RFc0NVaUpaZ1EwSUVrUW9URkN3SlVNMkdnRkpGU01TUkJjMkdnSkpJbGtrQ0VzQkZSSkVWd0lBTmhvRFNTSlpKQWhMQVJVU1JGY0NBRWsyR2dSSkZTTVNSQmRPQWhWSmdmNGZERUY2U1NKUEFrbE9BZzhpU3dKUEFrMVBBa2xMQXc5TEEweE5Ud05KVGdKUEEwc0NVazRDVHdOU1R3UlBCRThEVHdNclNVOEdpUEVNRmloTVVMQWxRNEgrSDBKOU5ob0JTUlVqRWtRWE5ob0NTU0paSkFoTEFSVVNSRmNDQURZYUEwa2lXU1FJU3dFVkVrUlhBZ0EyR2dSSklsa2tDRXNCRlJKRVZ3SUFOaG9GU1NKWkpBaExBUlVTUkZjQ0FEWWFCa2tpV1NRSVN3RVZFa1JYQWdBMkdnZEpGU01TUkJlSTB3NFdLRXhRc0NWRE5ob0JTUlVqRWtRWE5ob0NTU0paSkFoTEFSVVNSRFlhQTBrVkl4SkVzVThDc2hpQUJCZlQwRnV5R2t5eUdySWFnUWF5RUNLeUFiTzBQa2xYQkFCTVZ3QUVLQkpFU1JVakVrUW9URkN3SlVNMkdnRkpGU01TUkJjMkdnSkpGWUVnRWtRMkdnTkpJbGtrQ0VzQkZSSkVOaG9FU1JXQklCSkVOaG9GU1NKWmdTQUxKQWhMQVJVU1JEWWFCa2tWSXhKRXNVOEZzaGlBQkN2enpGcXlHazhFc2hwUEE3SWFUd0t5R2t5eUdySWFnUWF5RUNLeUFiTzBQa2xYQkFCTVZ3QUVLQkpFU1JVbEVrUW9URkN3SlVNMkdnRkpGU01TUkJjMkdnSkpGWUVnRWtRMkdnTkpJbGtrQ0VzQkZSSkVOaG9FU1JXQklCSkVOaG9GU1NKWmdTQUxKQWhMQVJVU1JEWWFCa2tWSXhKRU5ob0hTU0paSkFoTEFSVVNSTEZQQnJJWWdBUU04Ym5Qc2hwUEJiSWFUd1N5R2s4RHNocFBBcklhVExJYXNocUJCcklRSXJJQnM3UStTVmNFQUV4WEFBUW9Fa1JKSWxra0NFc0JGUkpFS0V4UXNDVkRJallhQVVrVkl4SkVGellhQWtrVkl4SkVGellhQTBsT0Fra2lXU1FJVEJVU1JEWWFCRWxPQWtraVdVbUJJQXNrQ0U4Q0ZSSkVJazRGUUJoR0JJR0lKeFlvVEZDd0pVT3hTWEVMUkV3V0FRRWxGazhGZ0FOaFlXeGxTSUZJVzdJWWdBUWY5OGRNc2hwUEFySWFUd095R2t5eUdreXlHcklhZ0FrQUIzSnZlV0ZzZEhteUdvRUdzaEFpc2dHenRENUpWd1FBU3dGWEFBUW9Fa1JKSWxra0NFd1ZFa1JYQmdCSlJRTVZRUXBMQVJkRkFVa2hCQTFCQ2lFRVF2TUJTVUw3QVRZYUFVa1ZJeEpFRjBseUMwaE1jZ3hJVElBQkFDSlBBbFFsVHdKVUtFeFFzQ1ZETmhvQlNSVWpFa1FYTmhvQ1NTSlpKQWhMQVJVU1JGY0NBRFlhQTBraVdTUUlTd0VWRWtSWEFnRFVCeVZETmhvQlNSVWpFa1FYTmhvQ1NTSlpKQWhMQVJVU1JGY0NBTlFFZ0FFQUlrOENWQ2hNVUxBbFF3PT0iLCJjbGVhciI6IkRZRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
