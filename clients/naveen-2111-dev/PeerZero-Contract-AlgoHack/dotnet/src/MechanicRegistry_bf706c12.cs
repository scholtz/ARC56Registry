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

namespace Arc56.Generated.naveen_2111_dev.PeerZero_Contract_AlgoHack.MechanicRegistry_bf706c12
{


    public class MechanicRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MechanicRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class MechanicStruct : AVMObjectType
            {
                public string Name { get; set; }

                public string Location { get; set; }

                public string Skills { get; set; }

                public ulong ServiceAssetId { get; set; }

                public Algorand.Address WalletAddress { get; set; }

                public bool Status { get; set; }

                public ulong Rating { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vLocation.From(Location);
                    stringRef[ret.Count] = vLocation.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSkills = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSkills.From(Skills);
                    stringRef[ret.Count] = vSkills.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vServiceAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vServiceAssetId.From(ServiceAssetId);
                    ret.AddRange(vServiceAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWalletAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vWalletAddress.From(WalletAddress);
                    ret.AddRange(vWalletAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRating = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRating.From(Rating);
                    ret.AddRange(vRating.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static MechanicStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new MechanicStruct();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexLocation = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vLocation.Decode(bytes.Skip(indexLocation + prefixOffset).ToArray());
                    var valueLocation = vLocation.ToValue();
                    if (valueLocation is string vLocationValue) { ret.Location = vLocationValue; }
                    var indexSkills = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSkills = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSkills.Decode(bytes.Skip(indexSkills + prefixOffset).ToArray());
                    var valueSkills = vSkills.ToValue();
                    if (valueSkills is string vSkillsValue) { ret.Skills = vSkillsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vServiceAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vServiceAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueServiceAssetId = vServiceAssetId.ToValue();
                    if (valueServiceAssetId is ulong vServiceAssetIdValue) { ret.ServiceAssetId = vServiceAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWalletAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vWalletAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWalletAddress = vWalletAddress.ToValue();
                    if (valueWalletAddress is Algorand.Address vWalletAddressValue) { ret.WalletAddress = vWalletAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is bool vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRating = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRating.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRating = vRating.ToValue();
                    if (valueRating is ulong vRatingValue) { ret.Rating = vRatingValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MechanicStruct);
                }
                public bool Equals(MechanicStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MechanicStruct left, MechanicStruct right)
                {
                    return EqualityComparer<MechanicStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(MechanicStruct left, MechanicStruct right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mechanic"> MechanicStruct</param>
        public async Task<ulong> RegisterMechanic(Structs.MechanicStruct mechanic, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 204, 167, 59 };

            var result = await base.CallApp(new List<object> { abiHandle, mechanic }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegisterMechanic_Transactions(Structs.MechanicStruct mechanic, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 204, 167, 59 };

            return await base.MakeTransactionList(new List<object> { abiHandle, mechanic }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        /// <param name="mechanic"> MechanicStruct</param>
        public async Task<ulong> UpdateMechanic(ulong id, Structs.MechanicStruct mechanic, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 150, 9, 49 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            var result = await base.CallApp(new List<object> { abiHandle, idAbi, mechanic }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> UpdateMechanic_Transactions(ulong id, Structs.MechanicStruct mechanic, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 150, 9, 49 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi, mechanic }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        public async Task<Structs.MechanicStruct> GetMechanic(ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 153, 25, 62 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            var result = await base.CallApp(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MechanicStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetMechanic_Transactions(ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 153, 25, 62 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetMechanicCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 191, 69, 131 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetMechanicCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 191, 69, 131 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        /// <param name="status"> </param>
        public async Task<ulong> ChangeStatus(ulong id, bool status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 202, 213, 216 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); statusAbi.From(status);

            var result = await base.CallApp(new List<object> { abiHandle, idAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ChangeStatus_Transactions(ulong id, bool status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 202, 213, 216 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); statusAbi.From(status);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        /// <param name="newRate"> </param>
        public async Task<ulong> UpdateRating(ulong id, ulong newRate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 144, 91, 48 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);
            var newRateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newRateAbi.From(newRate);

            var result = await base.CallApp(new List<object> { abiHandle, idAbi, newRateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> UpdateRating_Transactions(ulong id, ulong newRate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 23, 144, 91, 48 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);
            var newRateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newRateAbi.From(newRate);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi, newRateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWVjaGFuaWNSZWdpc3RyeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJNZWNoYW5pY1N0cnVjdCI6W3sibmFtZSI6Im5hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoibG9jYXRpb24iLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoic2tpbGxzIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InNlcnZpY2VBc3NldElkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6IndhbGxldEFkZHJlc3MiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InN0YXR1cyIsInR5cGUiOiJib29sIn0seyJuYW1lIjoicmF0aW5nIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJyZWdpc3Rlck1lY2hhbmljIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihzdHJpbmcsc3RyaW5nLHN0cmluZyx1aW50NjQsYWRkcmVzcyxib29sLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJNZWNoYW5pY1N0cnVjdCIsIm5hbWUiOiJtZWNoYW5pYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZU1lY2hhbmljIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIoc3RyaW5nLHN0cmluZyxzdHJpbmcsdWludDY0LGFkZHJlc3MsYm9vbCx1aW50NjQpIiwic3RydWN0IjoiTWVjaGFuaWNTdHJ1Y3QiLCJuYW1lIjoibWVjaGFuaWMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRNZWNoYW5pYyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHN0cmluZyxzdHJpbmcsdWludDY0LGFkZHJlc3MsYm9vbCx1aW50NjQpIiwic3RydWN0IjoiTWVjaGFuaWNTdHJ1Y3QiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRNZWNoYW5pY0NvdW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hhbmdlU3RhdHVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhdHVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlUmF0aW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdSYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNDMsNDc3LDQ4OSw1MTQsNTU0LDU2Nl0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODQsMjg5LDI5NF0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAzLDEyNSwxNDcsMTYzLDE4MiwyMDRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjhdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDYsMTI4LDE1MCwxNjYsMTg1LDIwN10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VWdJbTFsWTJoaGJtbGpRMjkxYm5RaUlDSnRaV05vWVc1cFl5SWdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXMWxZMmd1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWlhod2IzSjBJR1JsWm1GMWJIUWdZMnhoYzNNZ1RXVmphR0Z1YVdOU1pXZHBjM1J5ZVNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE1Rb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEazFZMk5oTnpOaUlEQjRZakU1TmpBNU16RWdNSGc1WmprNU1Ua3paU0F3ZURVMFltWTBOVGd6SURCNFlqSmpZV1ExWkRnZ01IZ3hOemt3TldJek1DQXZMeUJ0WlhSb2IyUWdJbkpsWjJsemRHVnlUV1ZqYUdGdWFXTW9LSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhWcGJuUTJOQ3hoWkdSeVpYTnpMR0p2YjJ3c2RXbHVkRFkwS1NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVTFsWTJoaGJtbGpLSFZwYm5RMk5Dd29jM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzZFdsdWREWTBMR0ZrWkhKbGMzTXNZbTl2YkN4MWFXNTBOalFwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFRXVmphR0Z1YVdNb2RXbHVkRFkwS1NoemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aWIyOXNMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEUxbFkyaGhibWxqUTI5MWJuUW9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlZMmhoYm1kbFUzUmhkSFZ6S0hWcGJuUTJOQ3hpYjI5c0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWRYQmtZWFJsVW1GMGFXNW5LSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDl5WldkcGMzUmxjazFsWTJoaGJtbGpYM0p2ZFhSbFFETWdiV0ZwYmw5MWNHUmhkR1ZOWldOb1lXNXBZMTl5YjNWMFpVQTBJRzFoYVc1ZloyVjBUV1ZqYUdGdWFXTmZjbTkxZEdWQU5TQnRZV2x1WDJkbGRFMWxZMmhoYm1salEyOTFiblJmY205MWRHVkFOaUJ0WVdsdVgyTm9ZVzVuWlZOMFlYUjFjMTl5YjNWMFpVQTNJRzFoYVc1ZmRYQmtZWFJsVW1GMGFXNW5YM0p2ZFhSbFFEZ0tDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0YldWamFDNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QmxlSEJ2Y25RZ1pHVm1ZWFZzZENCamJHRnpjeUJOWldOb1lXNXBZMUpsWjJsemRISjVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTFjR1JoZEdWU1lYUnBibWRmY205MWRHVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2prMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxdFpXTm9MbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJR1Y0Y0c5eWRDQmtaV1poZFd4MElHTnNZWE56SUUxbFkyaGhibWxqVW1WbmFYTjBjbmtnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMVzFsWTJndVlXeG5ieTUwY3pvNU5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUhWd1pHRjBaVkpoZEdsdVp3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amFHRnVaMlZUZEdGMGRYTmZjbTkxZEdWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdGJXVmphQzVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzF0WldOb0xtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklHVjRjRzl5ZENCa1pXWmhkV3gwSUdOc1lYTnpJRTFsWTJoaGJtbGpVbVZuYVhOMGNua2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXMWxZMmd1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJR05vWVc1blpWTjBZWFIxY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSTlpXTm9ZVzVwWTBOdmRXNTBYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXMWxZMmd1WVd4bmJ5NTBjem8zTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaMlYwVFdWamFHRnVhV05EYjNWdWRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUk5aV05vWVc1cFkxOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxdFpXTm9MbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMVzFsWTJndVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z1pYaHdiM0owSUdSbFptRjFiSFFnWTJ4aGMzTWdUV1ZqYUdGdWFXTlNaV2RwYzNSeWVTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdGJXVmphQzVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdaMlYwVFdWamFHRnVhV01LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkWEJrWVhSbFRXVmphR0Z1YVdOZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0YldWamFDNWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMXRaV05vTG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUdWNGNHOXlkQ0JrWldaaGRXeDBJR05zWVhOeklFMWxZMmhoYm1salVtVm5hWE4wY25rZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFcxbFkyZ3VZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlIVndaR0YwWlUxbFkyaGhibWxqQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM0psWjJsemRHVnlUV1ZqYUdGdWFXTmZjbTkxZEdWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdGJXVmphQzVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzF0WldOb0xtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklHVjRjRzl5ZENCa1pXWmhkV3gwSUdOc1lYTnpJRTFsWTJoaGJtbGpVbVZuYVhOMGNua2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXMWxZMmd1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqWVd4c2MzVmlJSEpsWjJsemRHVnlUV1ZqYUdGdWFXTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzF0WldOb0xtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklHVjRjRzl5ZENCa1pXWmhkV3gwSUdOc1lYTnpJRTFsWTJoaGJtbGpVbVZuYVhOMGNua2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFMUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2pwTlpXTm9ZVzVwWTFKbFoybHpkSEo1TG5KbFoybHpkR1Z5VFdWamFHRnVhV01vYldWamFHRnVhV002SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LY21WbmFYTjBaWEpOWldOb1lXNXBZem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2pFNExURTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJSEIxWW14cFl5QnlaV2RwYzNSbGNrMWxZMmhoYm1saktHMWxZMmhoYm1sak9pQk5aV05vWVc1cFkxTjBjblZqZENrNklHRnlZelF1VldsdWRFNDJOQ0I3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdGJXVmphQzVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdiV1ZqYUdGdWFXTkRiM1Z1ZENBOUlFSnZlRHhoY21NMExsVnBiblJPTmpRK0tIc2dhMlY1T2lBaWJXVmphR0Z1YVdORGIzVnVkQ0lnZlNrN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKdFpXTm9ZVzVwWTBOdmRXNTBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMXRaV05vTG1Gc1oyOHVkSE02TWpFS0lDQWdJQzh2SUdsbUlDaDBhR2x6TG0xbFkyaGhibWxqUTI5MWJuUXVaWGhwYzNSektTQjdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUhKbFoybHpkR1Z5VFdWamFHRnVhV05mWld4elpWOWliMlI1UURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0YldWamFDNWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QndkV0pzYVdNZ2JXVmphR0Z1YVdORGIzVnVkQ0E5SUVKdmVEeGhjbU0wTGxWcGJuUk9OalErS0hzZ2EyVjVPaUFpYldWamFHRnVhV05EYjNWdWRDSWdmU2s3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p0WldOb1lXNXBZME52ZFc1MElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxdFpXTm9MbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJR04xY25KbGJuUkRiM1Z1ZENBOUlIUm9hWE11YldWamFHRnVhV05EYjNWdWRDNTJZV3gxWlRzS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENncHlaV2RwYzNSbGNrMWxZMmhoYm1salgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0YldWamFDNWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QnVZVzFsT2lCdFpXTm9ZVzVwWXk1dVlXMWxMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCc2IyTmhkR2x2YmpvZ2JXVmphR0Z1YVdNdWJHOWpZWFJwYjI0c0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlBMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXMWxZMmd1WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnYzJ0cGJHeHpPaUJ0WldOb1lXNXBZeTV6YTJsc2JITXNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzF0WldOb0xtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklISmhkR2x1WnpvZ2JXVmphR0Z1YVdNdWNtRjBhVzVuTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElEUTNJRGdnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXMWxZMmd1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnYzJWeWRtbGpaVUZ6YzJWMFNXUTZJRzFsWTJoaGJtbGpMbk5sY25acFkyVkJjM05sZEVsa0xBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JsZUhSeVlXTjBJRFlnT0NBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCM1lXeHNaWFJCWkdSeVpYTnpPaUJ0WldOb1lXNXBZeTUzWVd4c1pYUkJaR1J5WlhOekxBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JsZUhSeVlXTjBJREUwSURNeUlDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzF0WldOb0xtRnNaMjh1ZEhNNk1qY3RNelVLSUNBZ0lDOHZJR052Ym5OMElHNWxkMDFsWTJoaGJtbGpJRDBnYm1WM0lFMWxZMmhoYm1salUzUnlkV04wS0hzS0lDQWdJQzh2SUNBZ0lDQnVZVzFsT2lCdFpXTm9ZVzVwWXk1dVlXMWxMQW9nSUNBZ0x5OGdJQ0FnSUd4dlkyRjBhVzl1T2lCdFpXTm9ZVzVwWXk1c2IyTmhkR2x2Yml3S0lDQWdJQzh2SUNBZ0lDQnphMmxzYkhNNklHMWxZMmhoYm1sakxuTnJhV3hzY3l3S0lDQWdJQzh2SUNBZ0lDQnlZWFJwYm1jNklHMWxZMmhoYm1sakxuSmhkR2x1Wnl3S0lDQWdJQzh2SUNBZ0lDQnpaWEoyYVdObFFYTnpaWFJKWkRvZ2JXVmphR0Z1YVdNdWMyVnlkbWxqWlVGemMyVjBTV1FzQ2lBZ0lDQXZMeUFnSUNBZ2QyRnNiR1YwUVdSa2NtVnpjem9nYldWamFHRnVhV011ZDJGc2JHVjBRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTZJRzVsZHlCaGNtTTBMa0p2YjJ3b2RISjFaU2tzQ2lBZ0lDQXZMeUI5S1RzS0lDQWdJR1JwWnlBMUNpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOVFVnTHk4Z05UVUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TXpjS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEWUtJQ0FnSUd4bGJnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXMWxZMmd1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnYzNSaGRIVnpPaUJ1WlhjZ1lYSmpOQzVDYjI5c0tIUnlkV1VwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0RBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0YldWamFDNWhiR2R2TG5Sek9qSTNMVE0xQ2lBZ0lDQXZMeUJqYjI1emRDQnVaWGROWldOb1lXNXBZeUE5SUc1bGR5Qk5aV05vWVc1cFkxTjBjblZqZENoN0NpQWdJQ0F2THlBZ0lDQWdibUZ0WlRvZ2JXVmphR0Z1YVdNdWJtRnRaU3dLSUNBZ0lDOHZJQ0FnSUNCc2IyTmhkR2x2YmpvZ2JXVmphR0Z1YVdNdWJHOWpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lDQWdjMnRwYkd4ek9pQnRaV05vWVc1cFl5NXphMmxzYkhNc0NpQWdJQ0F2THlBZ0lDQWdjbUYwYVc1bk9pQnRaV05vWVc1cFl5NXlZWFJwYm1jc0NpQWdJQ0F2THlBZ0lDQWdjMlZ5ZG1salpVRnpjMlYwU1dRNklHMWxZMmhoYm1sakxuTmxjblpwWTJWQmMzTmxkRWxrTEFvZ0lDQWdMeThnSUNBZ0lIZGhiR3hsZEVGa1pISmxjM002SUcxbFkyaGhibWxqTG5kaGJHeGxkRUZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnYzNSaGRIVnpPaUJ1WlhjZ1lYSmpOQzVDYjI5c0tIUnlkV1VwTEFvZ0lDQWdMeThnZlNrN0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdGJXVmphQzVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdUV1ZqYUdGdWFXTnpJRDBnUW05NFRXRndQR0Z5WXpRdVZXbHVkRTQyTkN3Z1RXVmphR0Z1YVdOVGRISjFZM1ErS0hzZ2EyVjVVSEpsWm1sNE9pQWliV1ZqYUdGdWFXTWlJSDBwT3dvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYldWamFHRnVhV01pQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFcxbFkyZ3VZV3huYnk1MGN6b3pOd29nSUNBZ0x5OGdkR2hwY3k1TlpXTm9ZVzVwWTNNb1kzVnljbVZ1ZEVOdmRXNTBLUzUyWVd4MVpTQTlJRzVsZDAxbFkyaGhibWxqTG1OdmNIa29LVHNLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFcxbFkyZ3VZV3huYnk1MGN6b3pPQW9nSUNBZ0x5OGdkR2hwY3k1dFpXTm9ZVzVwWTBOdmRXNTBMblpoYkhWbElEMGdibVYzSUdGeVl6UXVWV2x1ZEU0Mk5DaGpkWEp5Wlc1MFEyOTFiblF1Ym1GMGFYWmxJQ3NnTVNrN0NpQWdJQ0JrZFhBS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXMWxZMmd1WVd4bmJ5NTBjem94TmdvZ0lDQWdMeThnY0hWaWJHbGpJRzFsWTJoaGJtbGpRMjkxYm5RZ1BTQkNiM2c4WVhKak5DNVZhVzUwVGpZMFBpaDdJR3RsZVRvZ0ltMWxZMmhoYm1salEyOTFiblFpSUgwcE93b2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJXVmphR0Z1YVdORGIzVnVkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCMGFHbHpMbTFsWTJoaGJtbGpRMjkxYm5RdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0dOMWNuSmxiblJEYjNWdWRDNXVZWFJwZG1VZ0t5QXhLVHNLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0YldWamFDNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QnlaWFIxY200Z1kzVnljbVZ1ZEVOdmRXNTBPd29nSUNBZ2NtVjBjM1ZpQ2dweVpXZHBjM1JsY2sxbFkyaGhibWxqWDJWc2MyVmZZbTlrZVVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxdFpXTm9MbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJR04xY25KbGJuUkRiM1Z1ZENBOUlHNWxkeUJoY21NMExsVnBiblJPTmpRb01DazdDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlCeVpXZHBjM1JsY2sxbFkyaGhibWxqWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdGJXVmphQzVoYkdkdkxuUnpPanBOWldOb1lXNXBZMUpsWjJsemRISjVMblZ3WkdGMFpVMWxZMmhoYm1saktHbGtPaUJpZVhSbGN5d2diV1ZqYUdGdWFXTTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tkWEJrWVhSbFRXVmphR0Z1YVdNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFcxbFkyZ3VZV3huYnk1MGN6bzBNeTAwTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nZFhCa1lYUmxUV1ZqYUdGdWFXTW9hV1E2SUdGeVl6UXVWV2x1ZEU0Mk5Dd2diV1ZqYUdGdWFXTTZJRTFsWTJoaGJtbGpVM1J5ZFdOMEtUb2dZWEpqTkM1VmFXNTBUalkwSUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMXRaV05vTG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUhCMVlteHBZeUJOWldOb1lXNXBZM01nUFNCQ2IzaE5ZWEE4WVhKak5DNVZhVzUwVGpZMExDQk5aV05vWVc1cFkxTjBjblZqZEQ0b2V5QnJaWGxRY21WbWFYZzZJQ0p0WldOb1lXNXBZeUlnZlNrN0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKdFpXTm9ZVzVwWXlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0YldWamFDNWhiR2R2TG5Sek9qUTFDaUFnSUNBdkx5QmpiMjV6ZENCbGVHbHpkR2x1WjAxbFkyaGhibWxqSUQwZ2RHaHBjeTVOWldOb1lXNXBZM01vYVdRcE93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFcxbFkyZ3VZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdjSFZpYkdsaklFMWxZMmhoYm1samN5QTlJRUp2ZUUxaGNEeGhjbU0wTGxWcGJuUk9OalFzSUUxbFkyaGhibWxqVTNSeWRXTjBQaWg3SUd0bGVWQnlaV1pwZURvZ0ltMWxZMmhoYm1saklpQjlLVHNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzF0WldOb0xtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklHTnZibk4wSUdWNGFYTjBhVzVuVFdWamFHRnVhV01nUFNCMGFHbHpMazFsWTJoaGJtbGpjeWhwWkNrN0NpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0YldWamFDNWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5QnBaaUFvSVdWNGFYTjBhVzVuVFdWamFHRnVhV011WlhocGMzUnpLU0I3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKdWVpQjFjR1JoZEdWTlpXTm9ZVzVwWTE5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lHRnlZelF1VldsdWRFNDJOQ2d3S1RzS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NuVndaR0YwWlUxbFkyaGhibWxqWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCbGVHbHpkR2x1WjAxbFkyaGhibWxqTG5aaGJIVmxJRDBnYldWamFHRnVhV011WTI5d2VTZ3BPd29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCeVpYUjFjbTRnYVdRN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0YldWamFDNWhiR2R2TG5Sek9qcE5aV05vWVc1cFkxSmxaMmx6ZEhKNUxtZGxkRTFsWTJoaGJtbGpLR2xrT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21kbGRFMWxZMmhoYm1sak9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxdFpXTm9MbUZzWjI4dWRITTZOVFV0TlRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRFMWxZMmhoYm1saktHbGtPaUJoY21NMExsVnBiblJPTmpRcE9pQk5aV05vWVc1cFkxTjBjblZqZENCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2pFMUNpQWdJQ0F2THlCd2RXSnNhV01nVFdWamFHRnVhV056SUQwZ1FtOTRUV0Z3UEdGeVl6UXVWV2x1ZEU0Mk5Dd2dUV1ZqYUdGdWFXTlRkSEoxWTNRK0tIc2dhMlY1VUhKbFptbDRPaUFpYldWamFHRnVhV01pSUgwcE93b2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJXVmphR0Z1YVdNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFcxbFkyZ3VZV3huYnk1MGN6bzFOd29nSUNBZ0x5OGdZMjl1YzNRZ2JXVmphR0Z1YVdNZ1BTQjBhR2x6TGsxbFkyaGhibWxqY3locFpDazdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdGJXVmphQzVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdUV1ZqYUdGdWFXTnpJRDBnUW05NFRXRndQR0Z5WXpRdVZXbHVkRTQyTkN3Z1RXVmphR0Z1YVdOVGRISjFZM1ErS0hzZ2EyVjVVSEpsWm1sNE9pQWliV1ZqYUdGdWFXTWlJSDBwT3dvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFcxbFkyZ3VZV3huYnk1MGN6bzFOd29nSUNBZ0x5OGdZMjl1YzNRZ2JXVmphR0Z1YVdNZ1BTQjBhR2x6TGsxbFkyaGhibWxqY3locFpDazdDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdGJXVmphQzVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUJwWmlBb0lXMWxZMmhoYm1sakxtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nWjJWMFRXVmphR0Z1YVdOZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMVzFsWTJndVlXeG5ieTUwY3pvMk1DMDJPQW9nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkeUJOWldOb1lXNXBZMU4wY25WamRDaDdDaUFnSUNBdkx5QWdJQ0FnYm1GdFpUb2dibVYzSUdGeVl6UXVVM1J5S0NJaUtTd0tJQ0FnSUM4dklDQWdJQ0JzYjJOaGRHbHZiam9nYm1WM0lHRnlZelF1VTNSeUtDSWlLU3dLSUNBZ0lDOHZJQ0FnSUNCemEybHNiSE02SUc1bGR5QmhjbU0wTGxOMGNpZ2lJaWtzQ2lBZ0lDQXZMeUFnSUNBZ2MyVnlkbWxqWlVGemMyVjBTV1E2SUc1bGR5QmhjbU0wTGxWcGJuUk9OalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdkMkZzYkdWMFFXUmtjbVZ6Y3pvZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3lnaVFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVU0lwTEFvZ0lDQWdMeThnSUNBZ0lITjBZWFIxY3pvZ2JtVjNJR0Z5WXpRdVFtOXZiQ2htWVd4elpTa3NDaUFnSUNBdkx5QWdJQ0FnY21GMGFXNW5PaUJ1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLREFwTEFvZ0lDQWdMeThnZlNrN0NpQWdJQ0J3ZFhOb1lubDBaWE1nWW1GelpUTXlLRUZCTTFGQlQwbEJTRTFCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJLUW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dwblpYUk5aV05vWVc1cFkxOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFcxbFkyZ3VZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdjbVYwZFhKdUlHMWxZMmhoYm1sakxuWmhiSFZsT3dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMVzFsWTJndVlXeG5ieTUwY3pvNlRXVmphR0Z1YVdOU1pXZHBjM1J5ZVM1blpYUk5aV05vWVc1cFkwTnZkVzUwS0NrZ0xUNGdZbmwwWlhNNkNtZGxkRTFsWTJoaGJtbGpRMjkxYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFcxbFkyZ3VZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdjSFZpYkdsaklHMWxZMmhoYm1salEyOTFiblFnUFNCQ2IzZzhZWEpqTkM1VmFXNTBUalkwUGloN0lHdGxlVG9nSW0xbFkyaGhibWxqUTI5MWJuUWlJSDBwT3dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYldWamFHRnVhV05EYjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1pXVnlYM3BsY204dlkyOXVkSEpoWTNRdGJXVmphQzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJwWmlBb2RHaHBjeTV0WldOb1lXNXBZME52ZFc1MExtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJuWlhSTlpXTm9ZVzVwWTBOdmRXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxdFpXTm9MbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJSEIxWW14cFl5QnRaV05vWVc1cFkwTnZkVzUwSUQwZ1FtOTRQR0Z5WXpRdVZXbHVkRTQyTkQ0b2V5QnJaWGs2SUNKdFpXTm9ZVzVwWTBOdmRXNTBJaUI5S1RzS0lDQWdJR0o1ZEdWalh6RWdMeThnSW0xbFkyaGhibWxqUTI5MWJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXMWxZMmd1WVd4bmJ5NTBjem8zTndvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdWJXVmphR0Z1YVdORGIzVnVkQzUyWVd4MVpUc0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCeVpYUnpkV0lLQ21kbGRFMWxZMmhoYm1salEyOTFiblJmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMXRaV05vTG1Gc1oyOHVkSE02TnprS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1lYSmpOQzVWYVc1MFRqWTBLREFwT3dvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2pwTlpXTm9ZVzVwWTFKbFoybHpkSEo1TG1Ob1lXNW5aVk4wWVhSMWN5aHBaRG9nWW5sMFpYTXNJSE4wWVhSMWN6b2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGphR0Z1WjJWVGRHRjBkWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMVzFsWTJndVlXeG5ieTUwY3pvNE1pMDRNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZMmhoYm1kbFUzUmhkSFZ6S0dsa09pQmhjbU0wTGxWcGJuUk9OalFzSUhOMFlYUjFjem9nWVhKak5DNUNiMjlzS1RvZ1lYSmpOQzVWYVc1MFRqWTBJSHNLSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxdFpXTm9MbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJSEIxWW14cFl5Qk5aV05vWVc1cFkzTWdQU0JDYjNoTllYQThZWEpqTkM1VmFXNTBUalkwTENCTlpXTm9ZVzVwWTFOMGNuVmpkRDRvZXlCclpYbFFjbVZtYVhnNklDSnRaV05vWVc1cFl5SWdmU2s3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p0WldOb1lXNXBZeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2pnMENpQWdJQ0F2THlCamIyNXpkQ0JsZUdsemRHbHVaMDFsWTJoaGJtbGpJRDBnZEdocGN5NU5aV05vWVc1cFkzTW9hV1FwT3dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMVzFsWTJndVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUUxbFkyaGhibWxqY3lBOUlFSnZlRTFoY0R4aGNtTTBMbFZwYm5ST05qUXNJRTFsWTJoaGJtbGpVM1J5ZFdOMFBpaDdJR3RsZVZCeVpXWnBlRG9nSW0xbFkyaGhibWxqSWlCOUtUc0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMXRaV05vTG1Gc1oyOHVkSE02T0RRS0lDQWdJQzh2SUdOdmJuTjBJR1Y0YVhOMGFXNW5UV1ZqYUdGdWFXTWdQU0IwYUdsekxrMWxZMmhoYm1samN5aHBaQ2s3Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2pnMkNpQWdJQ0F2THlCcFppQW9JV1Y0YVhOMGFXNW5UV1ZqYUdGdWFXTXVaWGhwYzNSektTQjdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCamFHRnVaMlZUZEdGMGRYTmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFcxbFkyZ3VZV3huYnk1MGN6bzROd29nSUNBZ0x5OGdjbVYwZFhKdUlHNWxkeUJoY21NMExsVnBiblJPTmpRb01DazdDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ3BqYUdGdVoyVlRkR0YwZFhOZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzF0WldOb0xtRnNaMjh1ZEhNNk9UQUtJQ0FnSUM4dklHVjRhWE4wYVc1blRXVmphR0Z1YVdNdWRtRnNkV1V1YzNSaGRIVnpJRDBnYzNSaGRIVnpPd29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnY0hWemFHbHVkQ0F6TmpnZ0x5OGdNelk0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2preENpQWdJQ0F2THlCeVpYUjFjbTRnYVdRN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0YldWamFDNWhiR2R2TG5Sek9qcE5aV05vWVc1cFkxSmxaMmx6ZEhKNUxuVndaR0YwWlZKaGRHbHVaeWhwWkRvZ1lubDBaWE1zSUc1bGQxSmhkR1U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LZFhCa1lYUmxVbUYwYVc1bk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCbFpYSmZlbVZ5Ynk5amIyNTBjbUZqZEMxdFpXTm9MbUZzWjI4dWRITTZPVFF0T1RVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z2NIVmliR2xqSUhWd1pHRjBaVkpoZEdsdVp5aHBaRG9nWVhKak5DNVZhVzUwVGpZMExDQnVaWGRTWVhSbE9pQmhjbU0wTGxWcGJuUk9OalFwT2lCaGNtTTBMbFZwYm5ST05qUWdld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dWbGNsOTZaWEp2TDJOdmJuUnlZV04wTFcxbFkyZ3VZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdjSFZpYkdsaklFMWxZMmhoYm1samN5QTlJRUp2ZUUxaGNEeGhjbU0wTGxWcGJuUk9OalFzSUUxbFkyaGhibWxqVTNSeWRXTjBQaWg3SUd0bGVWQnlaV1pwZURvZ0ltMWxZMmhoYm1saklpQjlLVHNLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbTFsWTJoaGJtbGpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMXRaV05vTG1Gc1oyOHVkSE02T1RZS0lDQWdJQzh2SUdOdmJuTjBJR1Y0YVhOMGFXNW5UV1ZqYUdGdWFXTWdQU0IwYUdsekxrMWxZMmhoYm1samN5aHBaQ2s3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2pFMUNpQWdJQ0F2THlCd2RXSnNhV01nVFdWamFHRnVhV056SUQwZ1FtOTRUV0Z3UEdGeVl6UXVWV2x1ZEU0Mk5Dd2dUV1ZqYUdGdWFXTlRkSEoxWTNRK0tIc2dhMlY1VUhKbFptbDRPaUFpYldWamFHRnVhV01pSUgwcE93b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHVmxjbDk2WlhKdkwyTnZiblJ5WVdOMExXMWxZMmd1WVd4bmJ5NTBjem81TmdvZ0lDQWdMeThnWTI5dWMzUWdaWGhwYzNScGJtZE5aV05vWVc1cFl5QTlJSFJvYVhNdVRXVmphR0Z1YVdOektHbGtLVHNLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMXRaV05vTG1Gc1oyOHVkSE02T1RnS0lDQWdJQzh2SUdsbUlDZ2haWGhwYzNScGJtZE5aV05vWVc1cFl5NWxlR2x6ZEhNcElIc0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUhWd1pHRjBaVkpoZEdsdVoxOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WldWeVgzcGxjbTh2WTI5dWRISmhZM1F0YldWamFDNWhiR2R2TG5Sek9qazVDaUFnSUNBdkx5QnlaWFIxY200Z2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNnd0tUc0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDblZ3WkdGMFpWSmhkR2x1WjE5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMVzFsWTJndVlXeG5ieTUwY3pveE1ETUtJQ0FnSUM4dklHVjRhWE4wYVc1blRXVmphR0Z1YVdNdWRtRnNkV1V1Y21GMGFXNW5MbTVoZEdsMlpTQXJJRzVsZDFKaGRHVXVibUYwYVhabENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdjSFZ6YUdsdWRDQTBOeUF2THlBME53b2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5SdmFRb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JsWlhKZmVtVnlieTlqYjI1MGNtRmpkQzF0WldOb0xtRnNaMjh1ZEhNNk1UQXlMVEV3TkFvZ0lDQWdMeThnWlhocGMzUnBibWROWldOb1lXNXBZeTUyWVd4MVpTNXlZWFJwYm1jZ1BTQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtBb2dJQ0FnTHk4Z0lDQWdJR1Y0YVhOMGFXNW5UV1ZqYUdGdWFXTXVkbUZzZFdVdWNtRjBhVzVuTG01aGRHbDJaU0FySUc1bGQxSmhkR1V1Ym1GMGFYWmxDaUFnSUNBdkx5QXBPd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmxaWEpmZW1WeWJ5OWpiMjUwY21GamRDMXRaV05vTG1Gc1oyOHVkSE02TVRBeUNpQWdJQ0F2THlCbGVHbHpkR2x1WjAxbFkyaGhibWxqTG5aaGJIVmxMbkpoZEdsdVp5QTlJRzVsZHlCaGNtTTBMbFZwYm5ST05qUW9DaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdaV1Z5WDNwbGNtOHZZMjl1ZEhKaFkzUXRiV1ZqYUM1aGJHZHZMblJ6T2pFd01pMHhNRFFLSUNBZ0lDOHZJR1Y0YVhOMGFXNW5UV1ZqYUdGdWFXTXVkbUZzZFdVdWNtRjBhVzVuSUQwZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNnS0lDQWdJQzh2SUNBZ0lDQmxlR2x6ZEdsdVowMWxZMmhoYm1sakxuWmhiSFZsTG5KaGRHbHVaeTV1WVhScGRtVWdLeUJ1WlhkU1lYUmxMbTVoZEdsMlpRb2dJQ0FnTHk4Z0tUc0tJQ0FnSUhOM1lYQUtJQ0FnSUhKbGNHeGhZMlV5SURRM0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR1ZsY2w5NlpYSnZMMk52Ym5SeVlXTjBMVzFsWTJndVlXeG5ieTUwY3pveE1EVUtJQ0FnSUM4dklISmxkSFZ5YmlCcFpEc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUJBUVZIM3gxRFcxbFkyaGhibWxqUTI5MWJuUUliV1ZqYUdGdWFXTUlBQUFBQUFBQUFBQXhHMEVBcTRJR0JKWE1wenNFc1pZSk1RU2ZtUmsrQkZTL1JZTUVzc3JWMkFRWGtGc3dOaG9BamdZQVp3QlJBRDRBTGdBWUFBSWpRekVaRkVReEdFUTJHZ0UyR2dLSUFhRW9URkN3SWtNeEdSUkVNUmhFTmhvQk5ob0NpQUZqS0V4UXNDSkRNUmtVUkRFWVJJZ0JSaWhNVUxBaVF6RVpGRVF4R0VRMkdnR0lBTjRvVEZDd0lrTXhHUlJFTVJoRU5ob0JOaG9DaUFDcktFeFFzQ0pETVJrVVJERVlSRFlhQVlnQUVTaE1VTEFpUXpFWlFQK0JNUmdVUkNKRGlnRUJLYjFGQVVFQWVTbStSSXYvSTFtTC80RUNXWXYvVHdKTEFsS0wvNEVFV1l2L1R3TkxBbEtML3hXTC8wOERUd0pTaS85WEx3aUwvMWNHQ0l2L1Z3NGdTd1VWZ1RjSVNSWlhCZ0tBQWdBM1RGQkxCaFZQQWdnV1Z3WUNVRThDVUV4UWdBR0FVRXhRVHdOUVR3SlFURkFxU3dKUVNieElUTDlKRnlJSUZpbE12NGtyUXYrR2lnSUJLb3YrVUVtOVJRRkFBQU1yVEltTEFFbThTSXYvdjR2K1RJbUtBUUVxaS85UVNiMUZBVUFBUVlBOUFEY0FPUUE3QUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUV5Sml3QytSRXlKS2IxRkFVRUFCQ20rUklrcmlZb0NBU3FML2xCSnZVVUJRQUFESzB5Sml3Qkp2a1NML3lOVGdmQUNURlJMQWJ4SXY0ditUSW1LQWdFcWkvNVFTYjFGQVVBQUF5dE1pWXNBU2I1RWdTOWJpLzhYQ0JaTEFiNUVURnd2U3dHOFNMK0wva3lKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
