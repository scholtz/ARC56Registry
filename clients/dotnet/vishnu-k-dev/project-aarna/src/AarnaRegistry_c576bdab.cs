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

namespace Arc56.Generated.vishnu_k_dev.project_aarna.AarnaRegistry_c576bdab
{


    public class AarnaRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AarnaRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ListingRecord : AVMObjectType
            {
                public Algorand.Address Seller { get; set; }

                public ulong Amount { get; set; }

                public ulong Price { get; set; }

                public ulong Active { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSeller.From(Seller);
                    ret.AddRange(vSeller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrice.From(Price);
                    ret.AddRange(vPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vActive.From(Active);
                    ret.AddRange(vActive.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ListingRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ListingRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSeller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSeller = vSeller.ToValue();
                    if (valueSeller is Algorand.Address vSellerValue) { ret.Seller = vSellerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrice = vPrice.ToValue();
                    if (valuePrice is ulong vPriceValue) { ret.Price = vPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActive = vActive.ToValue();
                    if (valueActive is ulong vActiveValue) { ret.Active = vActiveValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ListingRecord);
                }
                public bool Equals(ListingRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ListingRecord left, ListingRecord right)
                {
                    return EqualityComparer<ListingRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(ListingRecord left, ListingRecord right)
                {
                    return !(left == right);
                }

            }

            public class ProjectRecord : AVMObjectType
            {
                public Algorand.Address Submitter { get; set; }

                public string Name { get; set; }

                public string Location { get; set; }

                public string Ecosystem { get; set; }

                public string Cid { get; set; }

                public ulong Status { get; set; }

                public ulong Credits { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSubmitter = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSubmitter.From(Submitter);
                    ret.AddRange(vSubmitter.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vLocation.From(Location);
                    stringRef[ret.Count] = vLocation.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEcosystem = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEcosystem.From(Ecosystem);
                    stringRef[ret.Count] = vEcosystem.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCid.From(Cid);
                    stringRef[ret.Count] = vCid.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCredits = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCredits.From(Credits);
                    ret.AddRange(vCredits.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProjectRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProjectRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSubmitter = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSubmitter.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSubmitter = vSubmitter.ToValue();
                    if (valueSubmitter is Algorand.Address vSubmitterValue) { ret.Submitter = vSubmitterValue; }
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
                    var indexEcosystem = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEcosystem = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEcosystem.Decode(bytes.Skip(indexEcosystem + prefixOffset).ToArray());
                    var valueEcosystem = vEcosystem.ToValue();
                    if (valueEcosystem is string vEcosystemValue) { ret.Ecosystem = vEcosystemValue; }
                    var indexCid = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCid.Decode(bytes.Skip(indexCid + prefixOffset).ToArray());
                    var valueCid = vCid.ToValue();
                    if (valueCid is string vCidValue) { ret.Cid = vCidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is ulong vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCredits = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCredits.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCredits = vCredits.ToValue();
                    if (valueCredits is ulong vCreditsValue) { ret.Credits = vCreditsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProjectRecord);
                }
                public bool Equals(ProjectRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProjectRecord left, ProjectRecord right)
                {
                    return EqualityComparer<ProjectRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(ProjectRecord left, ProjectRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Deploy the contract and set the caller as admin.
        ///</summary>
        public async Task Init(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 241, 71, 72 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Init_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 241, 71, 72 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin assigns a validator address for project reviews.
        ///</summary>
        /// <param name="addr"> </param>
        public async Task SetValidator(Algorand.Address addr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 38, 208, 75 };
            var addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addrAbi.From(addr);

            var result = await base.CallApp(new List<object> { abiHandle, addrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetValidator_Transactions(Algorand.Address addr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 38, 208, 75 };
            var addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addrAbi.From(addr);

            return await base.MakeTransactionList(new List<object> { abiHandle, addrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin transfers ownership to a new admin account.
        ///</summary>
        /// <param name="new_admin"> </param>
        public async Task TransferAdmin(Algorand.Address new_admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 72, 251, 179 };
            var new_adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_adminAbi.From(new_admin);

            var result = await base.CallApp(new List<object> { abiHandle, new_adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferAdmin_Transactions(Algorand.Address new_admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 72, 251, 179 };
            var new_adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_adminAbi.From(new_admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create the AARNA ASA if it doesn't exist. Returns the ASA ID.
        ///</summary>
        public async Task<ulong> EnsureToken(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 251, 123, 124 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> EnsureToken_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 251, 123, 124 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Developer submits a new project. Returns the project index.
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="location"> </param>
        /// <param name="ecosystem"> </param>
        /// <param name="cid"> </param>
        public async Task<ulong> SubmitProject(string name, string location, string ecosystem, string cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 26, 128, 119 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var locationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); locationAbi.From(location);
            var ecosystemAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ecosystemAbi.From(ecosystem);
            var cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cidAbi.From(cid);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, locationAbi, ecosystemAbi, cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SubmitProject_Transactions(string name, string location, string ecosystem, string cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 26, 128, 119 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var locationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); locationAbi.From(location);
            var ecosystemAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ecosystemAbi.From(ecosystem);
            var cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cidAbi.From(cid);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, locationAbi, ecosystemAbi, cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Validator approves a project and assigns a credit amount.
        ///</summary>
        /// <param name="project_id"> </param>
        /// <param name="credits"> </param>
        public async Task ApproveProject(ulong project_id, ulong credits, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 69, 242, 249 };
            var project_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); project_idAbi.From(project_id);
            var creditsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); creditsAbi.From(credits);

            var result = await base.CallApp(new List<object> { abiHandle, project_idAbi, creditsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApproveProject_Transactions(ulong project_id, ulong credits, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 69, 242, 249 };
            var project_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); project_idAbi.From(project_id);
            var creditsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); creditsAbi.From(credits);

            return await base.MakeTransactionList(new List<object> { abiHandle, project_idAbi, creditsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Validator rejects a pending project.
        ///</summary>
        /// <param name="project_id"> </param>
        public async Task RejectProject(ulong project_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 151, 153, 67 };
            var project_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); project_idAbi.From(project_id);

            var result = await base.CallApp(new List<object> { abiHandle, project_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RejectProject_Transactions(ulong project_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 151, 153, 67 };
            var project_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); project_idAbi.From(project_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, project_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Validator issues AARNA tokens to submitter.
        ///Status: 2 (verified) → 4 (issued). Prevents double-issuance.
        ///</summary>
        /// <param name="project_id"> </param>
        public async Task<ulong> IssueCredits(ulong project_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 98, 144, 101 };
            var project_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); project_idAbi.From(project_id);

            var result = await base.CallApp(new List<object> { abiHandle, project_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IssueCredits_Transactions(ulong project_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 98, 144, 101 };
            var project_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); project_idAbi.From(project_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, project_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///List AARNA tokens for sale using clawback to escrow.
        ///Returns the listing index.
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="price_per_token"> </param>
        public async Task<ulong> ListForSale(ulong amount, ulong price_per_token, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 111, 162, 55 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var price_per_tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_per_tokenAbi.From(price_per_token);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, price_per_tokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ListForSale_Transactions(ulong amount, ulong price_per_token, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 111, 162, 55 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var price_per_tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_per_tokenAbi.From(price_per_token);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, price_per_tokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Buy tokens from a listing. Transfers tokens to buyer and ALGO to seller.
        ///</summary>
        /// <param name="listing_id"> </param>
        /// <param name="payment"> </param>
        public async Task BuyListing(ulong listing_id, ulong payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 142, 67, 34 };
            var listing_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_idAbi.From(listing_id);
            var paymentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); paymentAbi.From(payment);

            var result = await base.CallApp(new List<object> { abiHandle, listing_idAbi, paymentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BuyListing_Transactions(ulong listing_id, ulong payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 142, 67, 34 };
            var listing_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_idAbi.From(listing_id);
            var paymentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); paymentAbi.From(payment);

            return await base.MakeTransactionList(new List<object> { abiHandle, listing_idAbi, paymentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Seller cancels their listing. Escrowed tokens returned.
        ///</summary>
        /// <param name="listing_id"> </param>
        public async Task CancelListing(ulong listing_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 213, 91, 108 };
            var listing_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_idAbi.From(listing_id);

            var result = await base.CallApp(new List<object> { abiHandle, listing_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CancelListing_Transactions(ulong listing_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 213, 91, 108 };
            var listing_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_idAbi.From(listing_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, listing_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetProjectCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 94, 117, 189 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetProjectCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 94, 117, 189 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetAssetId(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 162, 42, 132 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAssetId_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 162, 42, 132 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> GetAdmin(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 107, 61, 188 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetAdmin_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 107, 61, 188 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> GetValidator(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 142, 105, 65 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetValidator_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 142, 105, 65 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetTotalCreditsIssued(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 28, 210, 220 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalCreditsIssued_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 28, 210, 220 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="project_id"> </param>
        public async Task<Structs.ProjectRecord> GetProject(ulong project_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 28, 101, 110 };
            var project_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); project_idAbi.From(project_id);

            var result = await base.SimApp(new List<object> { abiHandle, project_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProjectRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetProject_Transactions(ulong project_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 28, 101, 110 };
            var project_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); project_idAbi.From(project_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, project_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="listing_id"> </param>
        public async Task<Structs.ListingRecord> GetListing(ulong listing_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 174, 222, 110 };
            var listing_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_idAbi.From(listing_id);

            var result = await base.SimApp(new List<object> { abiHandle, listing_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ListingRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetListing_Transactions(ulong listing_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 174, 222, 110 };
            var listing_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_idAbi.From(listing_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, listing_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetListingCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 29, 235, 164, 233 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetListingCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 29, 235, 164, 233 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWFybmFSZWdpc3RyeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJMaXN0aW5nUmVjb3JkIjpbeyJuYW1lIjoic2VsbGVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicHJpY2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWN0aXZlIiwidHlwZSI6InVpbnQ2NCJ9XSwiUHJvamVjdFJlY29yZCI6W3sibmFtZSI6InN1Ym1pdHRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJsb2NhdGlvbiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJlY29zeXN0ZW0iLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiY2lkIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InN0YXR1cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjcmVkaXRzIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJpbml0IiwiZGVzYyI6IkRlcGxveSB0aGUgY29udHJhY3QgYW5kIHNldCB0aGUgY2FsbGVyIGFzIGFkbWluLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfdmFsaWRhdG9yIiwiZGVzYyI6IkFkbWluIGFzc2lnbnMgYSB2YWxpZGF0b3IgYWRkcmVzcyBmb3IgcHJvamVjdCByZXZpZXdzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2Zlcl9hZG1pbiIsImRlc2MiOiJBZG1pbiB0cmFuc2ZlcnMgb3duZXJzaGlwIHRvIGEgbmV3IGFkbWluIGFjY291bnQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfYWRtaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW5zdXJlX3Rva2VuIiwiZGVzYyI6IkNyZWF0ZSB0aGUgQUFSTkEgQVNBIGlmIGl0IGRvZXNuJ3QgZXhpc3QuIFJldHVybnMgdGhlIEFTQSBJRC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdWJtaXRfcHJvamVjdCIsImRlc2MiOiJEZXZlbG9wZXIgc3VibWl0cyBhIG5ldyBwcm9qZWN0LiBSZXR1cm5zIHRoZSBwcm9qZWN0IGluZGV4LiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb2NhdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZWNvc3lzdGVtIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHByb3ZlX3Byb2plY3QiLCJkZXNjIjoiVmFsaWRhdG9yIGFwcHJvdmVzIGEgcHJvamVjdCBhbmQgYXNzaWducyBhIGNyZWRpdCBhbW91bnQuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb2plY3RfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWRpdHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVqZWN0X3Byb2plY3QiLCJkZXNjIjoiVmFsaWRhdG9yIHJlamVjdHMgYSBwZW5kaW5nIHByb2plY3QuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb2plY3RfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNzdWVfY3JlZGl0cyIsImRlc2MiOiJWYWxpZGF0b3IgaXNzdWVzIEFBUk5BIHRva2VucyB0byBzdWJtaXR0ZXIuXG5TdGF0dXM6IDIgKHZlcmlmaWVkKSDihpIgNCAoaXNzdWVkKS4gUHJldmVudHMgZG91YmxlLWlzc3VhbmNlLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9qZWN0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGlzdF9mb3Jfc2FsZSIsImRlc2MiOiJMaXN0IEFBUk5BIHRva2VucyBmb3Igc2FsZSB1c2luZyBjbGF3YmFjayB0byBlc2Nyb3cuXG5SZXR1cm5zIHRoZSBsaXN0aW5nIGluZGV4LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlX3Blcl90b2tlbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1eV9saXN0aW5nIiwiZGVzYyI6IkJ1eSB0b2tlbnMgZnJvbSBhIGxpc3RpbmcuIFRyYW5zZmVycyB0b2tlbnMgdG8gYnV5ZXIgYW5kIEFMR08gdG8gc2VsbGVyLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsaXN0aW5nX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbmNlbF9saXN0aW5nIiwiZGVzYyI6IlNlbGxlciBjYW5jZWxzIHRoZWlyIGxpc3RpbmcuIEVzY3Jvd2VkIHRva2VucyByZXR1cm5lZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGlzdGluZ19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcHJvamVjdF9jb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2Fzc2V0X2lkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYWRtaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdmFsaWRhdG9yIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RvdGFsX2NyZWRpdHNfaXNzdWVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcHJvamVjdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9qZWN0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHN0cmluZyxzdHJpbmcsc3RyaW5nLHN0cmluZyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlByb2plY3RSZWNvcmQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9saXN0aW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxpc3RpbmdfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiTGlzdGluZ1JlY29yZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2xpc3RpbmdfY291bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo0LCJieXRlcyI6Mn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbODkwXSwiZXJyb3JNZXNzYWdlIjoiYW1vdW50IG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcwLDQ2OCw3NzEsODgzLDk3NSwxMTE2LDExNTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFhcm5hX2Fzc2V0IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNjksMTI2MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTIxLDk4NCwxMDc5LDEyNDZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxpc3RpbmdfY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTk2LDEwOTEsMTIzNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubGlzdGluZ3MgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ0LDY2OSw3MjUsNzc5LDExNDZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnByb2plY3RfY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjg1LDc5MSwxMjE0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wcm9qZWN0cyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NTIsMTE5MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfY3JlZGl0c19pc3N1ZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4MCwxMjcwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi52YWxpZGF0b3IgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjc3XSwiZXJyb3JNZXNzYWdlIjoiY3JlZGl0cyBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMjJdLCJlcnJvck1lc3NhZ2UiOiJpbnN1ZmZpY2llbnQgcGF5bWVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4MSw0OTgsNTE1LDUzMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4OCwxMDgzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBsaXN0aW5nIGlkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDkyLDUwOSw1MjYsNTQwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMSwzNDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjUyLDY2MCw3MTcsNzY0LDg3MSw4NzksOTYzLDk3MSwxMDc0LDEyMDYsMTIyOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY3Myw3MjksNzgzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBwcm9qZWN0IGlkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZDogemVybyBhZGRyZXNzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwNCwxMDk5XSwiZXJyb3JNZXNzYWdlIjoibGlzdGluZyBub3QgYWN0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODg1LDk3N10sImVycm9yTWVzc2FnZSI6Im5vIEFBUk5BIHRva2VuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzczXSwiZXJyb3JNZXNzYWdlIjoibm8gQUFSTkEgdG9rZW4gY3JlYXRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMTFdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IHNlbGxlciBjYW4gY2FuY2VsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODk0XSwiZXJyb3JNZXNzYWdlIjoicHJpY2UgbXVzdCBiZSA+IDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTQsNzQyXSwiZXJyb3JNZXNzYWdlIjoicHJvamVjdCBub3QgcGVuZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwMF0sImVycm9yTWVzc2FnZSI6InByb2plY3Qgbm90IHZlcmlmaWVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI2Ml0sImVycm9yTWVzc2FnZSI6InVuYXV0aG9yaXplZDogYWRtaW4gb25seSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNzJdLCJlcnJvck1lc3NhZ2UiOiJ1bmF1dGhvcml6ZWQ6IHZhbGlkYXRvciBvbmx5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQ0EwTUFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURFMU1XWTNZemMxSUNKaFlYSnVZVjloYzNObGRDSWdJbkJ5YjJwbFkzUmZZMjkxYm5RaUlDSnNhWE4wYVc1blgyTnZkVzUwSWlBaVlXUnRhVzRpSURCNE56QWdNSGd3TURBd01EQXdNREF3TURBd01EQXhJQ0oyWVd4cFpHRjBiM0lpSUNKMGIzUmhiRjlqY21Wa2FYUnpYMmx6YzNWbFpDSWdNSGcyWXlBd2VEQXdNREF3TURBd01EQXdNREF3TURJZ01IZ3dNREF3TURBd01EQXdNREF3TURBMElEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalF6TFRRMENpQWdJQ0F2THlBaklPS1VnT0tVZ0NCU2IyeGxMV0poYzJWa0lHRmpZMlZ6Y3lCamIyNTBjbTlzSU9LVWdPS1VnQW9nSUNBZ0x5OGdjMlZzWmk1aFpHMXBiam9nWVhKak5DNUJaR1J5WlhOeklEMGdZWEpqTkM1QlpHUnlaWE56S0Vkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFlYSnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvME5Rb2dJQ0FnTHk4Z2MyVnNaaTUyWVd4cFpHRjBiM0k2SUdGeVl6UXVRV1JrY21WemN5QTlJR0Z5WXpRdVFXUmtjbVZ6Y3loSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOektRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRtRnNhV1JoZEc5eUlnb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalEzTFRRNENpQWdJQ0F2THlBaklPS1VnT0tVZ0NCQlFWSk9RU0IwYjJ0bGJpQW9RVk5CS1NEaWxJRGlsSUFLSUNBZ0lDOHZJSE5sYkdZdVlXRnlibUZmWVhOelpYUTZJRlZKYm5RMk5DQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZV0Z5Ym1GZllYTnpaWFFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzFNQzAxTVFvZ0lDQWdMeThnSXlEaWxJRGlsSUFnUTI5MWJuUmxjbk1nNHBTQTRwU0FDaUFnSUNBdkx5QnpaV3htTG5CeWIycGxZM1JmWTI5MWJuUTZJRlZKYm5RMk5DQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWljSEp2YW1WamRGOWpiM1Z1ZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalV5Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDJOeVpXUnBkSE5mYVhOemRXVmtPaUJWU1c1ME5qUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblJ2ZEdGc1gyTnlaV1JwZEhOZmFYTnpkV1ZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOVE1LSUNBZ0lDOHZJSE5sYkdZdWJHbHpkR2x1WjE5amIzVnVkRG9nVlVsdWREWTBJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pzYVhOMGFXNW5YMk52ZFc1MElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzBNQzAwTVFvZ0lDQWdMeThnSXlEaWxJRGlsSUFnUTI5dWRISmhZM1FnNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQTRwU0E0cFNBNHBTQUNpQWdJQ0F2THlCamJHRnpjeUJCWVhKdVlWSmxaMmx6ZEhKNUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FESTBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRaakV5Tm1Rd05HSWdNSGhrTXpRNFptSmlNeUF3ZURBNFptSTNZamRqSURCNFlUSXhZVGd3TnpjZ01IZzJOalExWmpKbU9TQXdlREl4T1RjNU9UUXpJREI0TmpJMk1qa3dOalVnTUhneU1qWm1ZVEl6TnlBd2VETXhPR1UwTXpJeUlEQjROak5rTlRWaU5tTWdNSGd6TURWbE56VmlaQ0F3ZURWaVlUSXlZVGcwSURCNE16UTJZak5rWW1NZ01IaG1NemhsTmprME1TQXdlRFZtTVdOa01tUmpJREI0TUdFeFl6WTFObVVnTUhneE5tRmxaR1UyWlNBd2VERmtaV0poTkdVNUlDOHZJRzFsZEdodlpDQWljMlYwWDNaaGJHbGtZWFJ2Y2loaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJblJ5WVc1elptVnlYMkZrYldsdUtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWlc1emRYSmxYM1J2YTJWdUtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luTjFZbTFwZEY5d2NtOXFaV04wS0hOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1WnlsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1Gd2NISnZkbVZmY0hKdmFtVmpkQ2gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbGFtVmpkRjl3Y205cVpXTjBLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKcGMzTjFaVjlqY21Wa2FYUnpLSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0lteHBjM1JmWm05eVgzTmhiR1VvZFdsdWREWTBMSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltSjFlVjlzYVhOMGFXNW5LSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTJGdVkyVnNYMnhwYzNScGJtY29kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOXdjbTlxWldOMFgyTnZkVzUwS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOWhjM05sZEY5cFpDZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmWVdSdGFXNG9LV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbWRsZEY5MllXeHBaR0YwYjNJb0tXRmtaSEpsYzNNaUxDQnRaWFJvYjJRZ0ltZGxkRjkwYjNSaGJGOWpjbVZrYVhSelgybHpjM1ZsWkNncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUmZjSEp2YW1WamRDaDFhVzUwTmpRcEtHRmtaSEpsYzNNc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKblpYUmZiR2x6ZEdsdVp5aDFhVzUwTmpRcEtHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSZmJHbHpkR2x1WjE5amIzVnVkQ2dwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYzJWMFgzWmhiR2xrWVhSdmNpQjBjbUZ1YzJabGNsOWhaRzFwYmlCbGJuTjFjbVZmZEc5clpXNGdjM1ZpYldsMFgzQnliMnBsWTNRZ1lYQndjbTkyWlY5d2NtOXFaV04wSUhKbGFtVmpkRjl3Y205cVpXTjBJR2x6YzNWbFgyTnlaV1JwZEhNZ2JHbHpkRjltYjNKZmMyRnNaU0JpZFhsZmJHbHpkR2x1WnlCallXNWpaV3hmYkdsemRHbHVaeUJuWlhSZmNISnZhbVZqZEY5amIzVnVkQ0JuWlhSZllYTnpaWFJmYVdRZ1oyVjBYMkZrYldsdUlHZGxkRjkyWVd4cFpHRjBiM0lnWjJWMFgzUnZkR0ZzWDJOeVpXUnBkSE5mYVhOemRXVmtJR2RsZEY5d2NtOXFaV04wSUdkbGRGOXNhWE4wYVc1bklHZGxkRjlzYVhOMGFXNW5YMk52ZFc1MENpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1qUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5EQXROREVLSUNBZ0lDOHZJQ01nNHBTQTRwU0FJRU52Ym5SeVlXTjBJT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ09LVWdPS1VnT0tVZ0FvZ0lDQWdMeThnWTJ4aGMzTWdRV0Z5Ym1GU1pXZHBjM1J5ZVNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRPRE5tTVRRM05EZ2dMeThnYldWMGFHOWtJQ0pwYm1sMEtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2FXNXBkQW9nSUNBZ1pYSnlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GaGNtNWhYM0psWjJsemRISjVMbU52Ym5SeVlXTjBMa0ZoY201aFVtVm5hWE4wY25rdWFXNXBkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21sdWFYUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk56WUtJQ0FnSUM4dklITmxiR1l1WVdSdGFXNGdQU0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzNNQzAzTXdvZ0lDQWdMeThnSXlEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaQUtJQ0FnSUM4dklDTWdUR2xtWldONVkyeGxJQzhnUVdSdGFXNEtJQ0FnSUM4dklDTWc0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVdGeWJtRmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVRV0Z5Ym1GU1pXZHBjM1J5ZVM1elpYUmZkbUZzYVdSaGRHOXlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFgzWmhiR2xrWVhSdmNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFlYSnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvM09Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk9ERUtJQ0FnSUM4dklITmxiR1l1WDI5dWJIbGZZV1J0YVc0b0tRb2dJQ0FnWTJGc2JITjFZaUJmYjI1c2VWOWhaRzFwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamd5Q2lBZ0lDQXZMeUJ6Wld4bUxuWmhiR2xrWVhSdmNpQTlJR0ZrWkhJdVkyOXdlU2dwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0oyWVd4cFpHRjBiM0lpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamM0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVdGeWJtRmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVRV0Z5Ym1GU1pXZHBjM1J5ZVM1MGNtRnVjMlpsY2w5aFpHMXBibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SeVlXNXpabVZ5WDJGa2JXbHVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmhjbTVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qZzBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzROd29nSUNBZ0x5OGdjMlZzWmk1ZmIyNXNlVjloWkcxcGJpZ3BDaUFnSUNCallXeHNjM1ZpSUY5dmJteDVYMkZrYldsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RnS0lDQWdJQzh2SUdGemMyVnlkQ0J1WlhkZllXUnRhVzR1Ym1GMGFYWmxJQ0U5SUVkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNc0lDSnBiblpoYkdsa09pQjZaWEp2SUdGa1pISmxjM01pQ2lBZ0lDQmtkWEFLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtPaUI2WlhKdklHRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG80T1FvZ0lDQWdMeThnYzJWc1ppNWhaRzFwYmlBOUlHNWxkMTloWkcxcGJpNWpiM0I1S0NrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1Ga2JXbHVJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzROQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZoY201aFgzSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExrRmhjbTVoVW1WbmFYTjBjbmt1Wlc1emRYSmxYM1J2YTJWdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taVzV6ZFhKbFgzUnZhMlZ1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamszQ2lBZ0lDQXZMeUJ6Wld4bUxsOXZibXg1WDJGa2JXbHVLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gyOXViSGxmWVdSdGFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFlYSnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNU9Bb2dJQ0FnTHk4Z2FXWWdibTkwSUhObGJHWXVZV0Z5Ym1GZllYTnpaWFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZV0Z5Ym1GZllYTnpaWFFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXRnlibUZmWVhOelpYUWdaWGhwYzNSekNpQWdJQ0JpYm5vZ1pXNXpkWEpsWDNSdmEyVnVYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2prNUxURXhNQW9nSUNBZ0x5OGdjbVZ6ZFd4MElEMGdhWFI0Ymk1QmMzTmxkRU52Ym1acFp5Z0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJEMHhNRjh3TURCZk1EQXdMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFRBc0NpQWdJQ0F2THlBZ0lDQWdaR1ZtWVhWc2RGOW1jbTk2Wlc0OVJtRnNjMlVzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBTSkJRVkpPUVNJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmJtRnRaVDBpUVdGeWJtRWdRMkZ5WW05dUlFTnlaV1JwZENJc0NpQWdJQ0F2THlBZ0lDQWdkWEpzUFNKb2RIUndjem92TDJGaGNtNWhMbVZqYnlJc0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JtY21WbGVtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JqYkdGM1ltRmphejFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFd05nb2dJQ0FnTHk4Z2JXRnVZV2RsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TURjdE1UQTVDaUFnSUNBdkx5QnlaWE5sY25abFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlCbWNtVmxlbVU5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJR05zWVhkaVlXTnJQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNCa2RYQnVJRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJEYkdGM1ltRmphd29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRVp5WldWNlpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGSmxjMlZ5ZG1VS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSTllXNWhaMlZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEExQ2lBZ0lDQXZMeUIxY213OUltaDBkSEJ6T2k4dllXRnlibUV1WldOdklpd0tJQ0FnSUhCMWMyaGllWFJsY3lBaWFIUjBjSE02THk5aFlYSnVZUzVsWTI4aUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZWSk1DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UQTBDaUFnSUNBdkx5QmhjM05sZEY5dVlXMWxQU0pCWVhKdVlTQkRZWEppYjI0Z1EzSmxaR2wwSWl3S0lDQWdJSEIxYzJoaWVYUmxjeUFpUVdGeWJtRWdRMkZ5WW05dUlFTnlaV1JwZENJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhST1lXMWxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UQXpDaUFnSUNBdkx5QjFibWwwWDI1aGJXVTlJa0ZCVWs1Qklpd0tJQ0FnSUhCMWMyaGllWFJsY3lBaVFVRlNUa0VpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVlc1cGRFNWhiV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hNRElLSUNBZ0lDOHZJR1JsWm1GMWJIUmZabkp2ZW1WdVBVWmhiSE5sTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJFWldaaGRXeDBSbkp2ZW1WdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRBeENpQWdJQ0F2THlCa1pXTnBiV0ZzY3owd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRVpXTnBiV0ZzY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV3TUFvZ0lDQWdMeThnZEc5MFlXdzlNVEJmTURBd1h6QXdNQ3dLSUNBZ0lIQjFjMmhwYm5RZ01UQXdNREF3TURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVWIzUmhiQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmhjbTVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qazVDaUFnSUNBdkx5QnlaWE4xYkhRZ1BTQnBkSGh1TGtGemMyVjBRMjl1Wm1sbktBb2dJQ0FnY0hWemFHbHVkQ0F6SUM4dklHRmpabWNLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2prNUxURXhNQW9nSUNBZ0x5OGdjbVZ6ZFd4MElEMGdhWFI0Ymk1QmMzTmxkRU52Ym1acFp5Z0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJEMHhNRjh3TURCZk1EQXdMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFRBc0NpQWdJQ0F2THlBZ0lDQWdaR1ZtWVhWc2RGOW1jbTk2Wlc0OVJtRnNjMlVzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBTSkJRVkpPUVNJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmJtRnRaVDBpUVdGeWJtRWdRMkZ5WW05dUlFTnlaV1JwZENJc0NpQWdJQ0F2THlBZ0lDQWdkWEpzUFNKb2RIUndjem92TDJGaGNtNWhMbVZqYnlJc0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JtY21WbGVtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JqYkdGM1ltRmphejFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFlYSnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1URUtJQ0FnSUM4dklITmxiR1l1WVdGeWJtRmZZWE56WlhRZ1BTQnlaWE4xYkhRdVkzSmxZWFJsWkY5aGMzTmxkQzVwWkFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVdGeWJtRmZZWE56WlhRaUNpQWdJQ0JwZEhodUlFTnlaV0YwWldSQmMzTmxkRWxFQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS1pXNXpkWEpsWDNSdmEyVnVYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFlYSnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1USUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG1GaGNtNWhYMkZ6YzJWMEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GaGNtNWhYMkZ6YzJWMElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZoY201aFgyRnpjMlYwSUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmhjbTVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qa3hMVGswQ2lBZ0lDQXZMeUFqSU9LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtBb2dJQ0FnTHk4Z0l5QkJRVkpPUVNCVWIydGxiZ29nSUNBZ0x5OGdJeURpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aFlYSnVZVjl5WldkcGMzUnllUzVqYjI1MGNtRmpkQzVCWVhKdVlWSmxaMmx6ZEhKNUxuTjFZbTFwZEY5d2NtOXFaV04wVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MzVmliV2wwWDNCeWIycGxZM1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEUwTFRFeE53b2dJQ0FnTHk4Z0l5RGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkFLSUNBZ0lDOHZJQ01nVUhKdmFtVmpkQ0JNYVdabFkzbGpiR1VLSUNBZ0lDOHZJQ01nNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEkyQ2lBZ0lDQXZMeUJwWkhnZ1BTQnpaV3htTG5CeWIycGxZM1JmWTI5MWJuUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKd2NtOXFaV04wWDJOdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CeWIycGxZM1JmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRJNENpQWdJQ0F2THlCemRXSnRhWFIwWlhJOVlYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmhjbTVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXlOeTB4TXpVS0lDQWdJQzh2SUhObGJHWXVjSEp2YW1WamRITmJhV1I0WFNBOUlGQnliMnBsWTNSU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ2MzVmliV2wwZEdWeVBXRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ0lDQnVZVzFsUFc1aGJXVXNDaUFnSUNBdkx5QWdJQ0FnYkc5allYUnBiMjQ5Ykc5allYUnBiMjRzQ2lBZ0lDQXZMeUFnSUNBZ1pXTnZjM2x6ZEdWdFBXVmpiM041YzNSbGJTd0tJQ0FnSUM4dklDQWdJQ0JqYVdROVkybGtMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFoY21NMExsVkpiblEyTkNneEtTd0tJQ0FnSUM4dklDQWdJQ0JqY21Wa2FYUnpQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXpPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vYVc1MElEVTJDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEkzQ2lBZ0lDQXZMeUJ6Wld4bUxuQnliMnBsWTNSelcybGtlRjBnUFNCUWNtOXFaV04wVW1WamIzSmtLQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGczTUFvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeU55MHhNelVLSUNBZ0lDOHZJSE5sYkdZdWNISnZhbVZqZEhOYmFXUjRYU0E5SUZCeWIycGxZM1JTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnYzNWaWJXbDBkR1Z5UFdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ0FnSUNCdVlXMWxQVzVoYldVc0NpQWdJQ0F2THlBZ0lDQWdiRzlqWVhScGIyNDliRzlqWVhScGIyNHNDaUFnSUNBdkx5QWdJQ0FnWldOdmMzbHpkR1Z0UFdWamIzTjVjM1JsYlN3S0lDQWdJQzh2SUNBZ0lDQmphV1E5WTJsa0xBb2dJQ0FnTHk4Z0lDQWdJSE4wWVhSMWN6MWhjbU0wTGxWSmJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNBZ0lDQmpjbVZrYVhSelBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV6TmdvZ0lDQWdMeThnYzJWc1ppNXdjbTlxWldOMFgyTnZkVzUwSUQwZ2FXUjRJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNISnZhbVZqZEY5amIzVnVkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEUwTFRFeE53b2dJQ0FnTHk4Z0l5RGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkFLSUNBZ0lDOHZJQ01nVUhKdmFtVmpkQ0JNYVdabFkzbGpiR1VLSUNBZ0lDOHZJQ01nNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUTRwV1E0cFdRNHBXUUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXRnlibUZmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1UVdGeWJtRlNaV2RwYzNSeWVTNWhjSEJ5YjNabFgzQnliMnBsWTNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhjSEJ5YjNabFgzQnliMnBsWTNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRNNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFlYSnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE5ESUtJQ0FnSUM4dklITmxiR1l1WDI5dWJIbGZkbUZzYVdSaGRHOXlLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gyOXViSGxmZG1Gc2FXUmhkRzl5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFF6Q2lBZ0lDQXZMeUJ3YVdRZ1BTQndjbTlxWldOMFgybGtMbTVoZEdsMlpRb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFME5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhCcFpDQThJSE5sYkdZdWNISnZhbVZqZEY5amIzVnVkQ3dnSW1sdWRtRnNhV1FnY0hKdmFtVmpkQ0JwWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p3Y205cVpXTjBYMk52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJ5YjJwbFkzUmZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2NISnZhbVZqZENCcFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFME5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdOeVpXUnBkSE11Ym1GMGFYWmxJRDRnVlVsdWREWTBLREFwTENBaVkzSmxaR2wwY3lCdGRYTjBJR0psSUQ0Z01DSUtJQ0FnSUdScFp5QXhDaUFnSUNCaWRHOXBDaUFnSUNCaGMzTmxjblFnTHk4Z1kzSmxaR2wwY3lCdGRYTjBJR0psSUQ0Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFME5nb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTV3Y205cVpXTjBjMXR3YVdSZExtTnZjSGtvS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURjd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjSEp2YW1WamRITWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFEyTFRFME53b2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTV3Y205cVpXTjBjMXR3YVdSZExtTnZjSGtvS1FvZ0lDQWdMeThnWVhOelpYSjBJSEpsWTI5eVpDNXpkR0YwZFhNZ1BUMGdZWEpqTkM1VlNXNTBOalFvTVNrc0lDSndjbTlxWldOMElHNXZkQ0J3Wlc1a2FXNW5JZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTXlBdkx5QTBNQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRRM0NpQWdJQ0F2THlCaGMzTmxjblFnY21WamIzSmtMbk4wWVhSMWN5QTlQU0JoY21NMExsVkpiblEyTkNneEtTd2dJbkJ5YjJwbFkzUWdibTkwSUhCbGJtUnBibWNpQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNUW9nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2NISnZhbVZqZENCdWIzUWdjR1Z1WkdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFME9Bb2dJQ0FnTHk4Z2NtVmpiM0prTG5OMFlYUjFjeUE5SUdGeVl6UXVWVWx1ZERZMEtESXBDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01ESUtJQ0FnSUhKbGNHeGhZMlV5SURRd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRRNUNpQWdJQ0F2THlCeVpXTnZjbVF1WTNKbFpHbDBjeUE5SUdOeVpXUnBkSE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnY21Wd2JHRmpaVElnTkRnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TlRBS0lDQWdJQzh2SUhObGJHWXVjSEp2YW1WamRITmJjR2xrWFNBOUlISmxZMjl5WkM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFlYSnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE16a0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWhZWEp1WVY5eVpXZHBjM1J5ZVM1amIyNTBjbUZqZEM1QllYSnVZVkpsWjJsemRISjVMbkpsYW1WamRGOXdjbTlxWldOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZxWldOMFgzQnliMnBsWTNRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRVeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TlRVS0lDQWdJQzh2SUhObGJHWXVYMjl1YkhsZmRtRnNhV1JoZEc5eUtDa0tJQ0FnSUdOaGJHeHpkV0lnWDI5dWJIbGZkbUZzYVdSaGRHOXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UVTJDaUFnSUNBdkx5QndhV1FnUFNCd2NtOXFaV04wWDJsa0xtNWhkR2wyWlFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakUxTndvZ0lDQWdMeThnWVhOelpYSjBJSEJwWkNBOElITmxiR1l1Y0hKdmFtVmpkRjlqYjNWdWRDd2dJbWx1ZG1Gc2FXUWdjSEp2YW1WamRDQnBaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSndjbTlxWldOMFgyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQnliMnBsWTNSZlkyOTFiblFnWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnY0hKdmFtVmpkQ0JwWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakUxT0FvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNXdjbTlxWldOMGMxdHdhV1JkTG1OdmNIa29LUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTlNBdkx5QXdlRGN3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TlRndE1UVTVDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG5CeWIycGxZM1J6VzNCcFpGMHVZMjl3ZVNncENpQWdJQ0F2THlCaGMzTmxjblFnY21WamIzSmtMbk4wWVhSMWN5QTlQU0JoY21NMExsVkpiblEyTkNneEtTd2dJbkJ5YjJwbFkzUWdibTkwSUhCbGJtUnBibWNpQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QTBNQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRVNUNpQWdJQ0F2THlCaGMzTmxjblFnY21WamIzSmtMbk4wWVhSMWN5QTlQU0JoY21NMExsVkpiblEyTkNneEtTd2dJbkJ5YjJwbFkzUWdibTkwSUhCbGJtUnBibWNpQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNUW9nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2NISnZhbVZqZENCdWIzUWdjR1Z1WkdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFMk1DMHhOakVLSUNBZ0lDOHZJSEpsWTI5eVpDNXpkR0YwZFhNZ1BTQmhjbU0wTGxWSmJuUTJOQ2d6S1FvZ0lDQWdMeThnYzJWc1ppNXdjbTlxWldOMGMxdHdhV1JkSUQwZ2NtVmpiM0prTG1OdmNIa29LUW9nSUNBZ2FXNTBZMTh6SUM4dklEUXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UWXdDaUFnSUNBdkx5QnlaV052Y21RdWMzUmhkSFZ6SUQwZ1lYSmpOQzVWU1c1ME5qUW9NeWtLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01ETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFlYSnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE5qQXRNVFl4Q2lBZ0lDQXZMeUJ5WldOdmNtUXVjM1JoZEhWeklEMGdZWEpqTkM1VlNXNTBOalFvTXlrS0lDQWdJQzh2SUhObGJHWXVjSEp2YW1WamRITmJjR2xrWFNBOUlISmxZMjl5WkM1amIzQjVLQ2tLSUNBZ0lHSnZlRjl5WlhCc1lXTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UVXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV0Z5Ym1GZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVFXRnlibUZTWldkcGMzUnllUzVwYzNOMVpWOWpjbVZrYVhSelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thWE56ZFdWZlkzSmxaR2wwY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TmpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakUyT1FvZ0lDQWdMeThnYzJWc1ppNWZiMjVzZVY5MllXeHBaR0YwYjNJb0tRb2dJQ0FnWTJGc2JITjFZaUJmYjI1c2VWOTJZV3hwWkdGMGIzSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFlYSnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE56QUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUZoY201aFgyRnpjMlYwTENBaWJtOGdRVUZTVGtFZ2RHOXJaVzRnWTNKbFlYUmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhZWEp1WVY5aGMzTmxkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFlYSnVZVjloYzNObGRDQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRzV2SUVGQlVrNUJJSFJ2YTJWdUlHTnlaV0YwWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TnpFS0lDQWdJQzh2SUhCcFpDQTlJSEJ5YjJwbFkzUmZhV1F1Ym1GMGFYWmxDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UY3lDaUFnSUNBdkx5QmhjM05sY25RZ2NHbGtJRHdnYzJWc1ppNXdjbTlxWldOMFgyTnZkVzUwTENBaWFXNTJZV3hwWkNCd2NtOXFaV04wSUdsa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5CeWIycGxZM1JmWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0hKdmFtVmpkRjlqYjNWdWRDQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQndjbTlxWldOMElHbGtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UY3pDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG5CeWIycGxZM1J6VzNCcFpGMHVZMjl3ZVNncENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE56QUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3Y205cVpXTjBjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TnpNdE1UYzBDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG5CeWIycGxZM1J6VzNCcFpGMHVZMjl3ZVNncENpQWdJQ0F2THlCaGMzTmxjblFnY21WamIzSmtMbk4wWVhSMWN5QTlQU0JoY21NMExsVkpiblEyTkNneUtTd2dJbkJ5YjJwbFkzUWdibTkwSUhabGNtbG1hV1ZrSWdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk15QXZMeUEwTUFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UYzBDaUFnSUNBdkx5QmhjM05sY25RZ2NtVmpiM0prTG5OMFlYUjFjeUE5UFNCaGNtTTBMbFZKYm5RMk5DZ3lLU3dnSW5CeWIycGxZM1FnYm05MElIWmxjbWxtYVdWa0lnb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBeUNpQWdJQ0JpUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ3Y205cVpXTjBJRzV2ZENCMlpYSnBabWxsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakUzTmkweE9EQUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFVGemMyVjBLSE5sYkdZdVlXRnlibUZmWVhOelpYUXBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQWEpsWTI5eVpDNXpkV0p0YVhSMFpYSXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxeVpXTnZjbVF1WTNKbFpHbDBjeTV1WVhScGRtVXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRjNENpQWdJQ0F2THlCaGMzTmxkRjl5WldObGFYWmxjajF5WldOdmNtUXVjM1ZpYldsMGRHVnlMbTVoZEdsMlpTd0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hOemtLSUNBZ0lDOHZJR0Z6YzJWMFgyRnRiM1Z1ZEQxeVpXTnZjbVF1WTNKbFpHbDBjeTV1WVhScGRtVXNDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBME9Bb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFlYSnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE56WUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QmhlR1psY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UYzJMVEU0TUFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlRWE56WlhRb2MyVnNaaTVoWVhKdVlWOWhjM05sZENrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOWNtVmpiM0prTG5OMVltMXBkSFJsY2k1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQWEpsWTI5eVpDNWpjbVZrYVhSekxtNWhkR2wyWlN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVGd5Q2lBZ0lDQXZMeUJ5WldOdmNtUXVjM1JoZEhWeklEMGdZWEpqTkM1VlNXNTBOalFvTkNrS0lDQWdJR0o1ZEdWaklERXhJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TkFvZ0lDQWdjbVZ3YkdGalpUSWdOREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hPREl0TVRnekNpQWdJQ0F2THlCeVpXTnZjbVF1YzNSaGRIVnpJRDBnWVhKak5DNVZTVzUwTmpRb05Da0tJQ0FnSUM4dklITmxiR1l1Y0hKdmFtVmpkSE5iY0dsa1hTQTlJSEpsWTI5eVpDNWpiM0I1S0NrS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk15QXZMeUEwTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakU0TWdvZ0lDQWdMeThnY21WamIzSmtMbk4wWVhSMWN5QTlJR0Z5WXpRdVZVbHVkRFkwS0RRcENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94T0RJdE1UZ3pDaUFnSUNBdkx5QnlaV052Y21RdWMzUmhkSFZ6SUQwZ1lYSmpOQzVWU1c1ME5qUW9OQ2tLSUNBZ0lDOHZJSE5sYkdZdWNISnZhbVZqZEhOYmNHbGtYU0E5SUhKbFkyOXlaQzVqYjNCNUtDa0tJQ0FnSUdKdmVGOXlaWEJzWVdObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRnMENpQWdJQ0F2THlCamNtVmtjeUE5SUhKbFkyOXlaQzVqY21Wa2FYUnpMbTVoZEdsMlpRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFE0SURnS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdORGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVGcxQ2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDJOeVpXUnBkSE5mYVhOemRXVmtJRDBnYzJWc1ppNTBiM1JoYkY5amNtVmthWFJ6WDJsemMzVmxaQ0FySUdOeVpXUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWRHOTBZV3hmWTNKbFpHbDBjMTlwYzNOMVpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZZM0psWkdsMGMxOXBjM04xWldRZ1pYaHBjM1J6Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZeUE0SUM4dklDSjBiM1JoYkY5amNtVmthWFJ6WDJsemMzVmxaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFl6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVdGeWJtRmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVRV0Z5Ym1GU1pXZHBjM1J5ZVM1c2FYTjBYMlp2Y2w5ellXeGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYkdsemRGOW1iM0pmYzJGc1pUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFlYSnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE9EZ3RNVGt4Q2lBZ0lDQXZMeUFqSU9LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtBb2dJQ0FnTHk4Z0l5Qk5ZWEpyWlhSd2JHRmpaUW9nSUNBZ0x5OGdJeURpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pJd01Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZV0Z5Ym1GZllYTnpaWFFzSUNKdWJ5QkJRVkpPUVNCMGIydGxiaUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhZWEp1WVY5aGMzTmxkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFlYSnVZVjloYzNObGRDQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRzV2SUVGQlVrNUJJSFJ2YTJWdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpBeUNpQWdJQ0F2THlCaGMzTmxjblFnWVcxdmRXNTBMbTVoZEdsMlpTQStJRlZKYm5RMk5DZ3dLU3dnSW1GdGIzVnVkQ0J0ZFhOMElHSmxJRDRnTUNJS0lDQWdJR1JwWnlBeUNpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYlc5MWJuUWdiWFZ6ZENCaVpTQStJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lNRE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQndjbWxqWlY5d1pYSmZkRzlyWlc0dWJtRjBhWFpsSUQ0Z1ZVbHVkRFkwS0RBcExDQWljSEpwWTJVZ2JYVnpkQ0JpWlNBK0lEQWlDaUFnSUNCa2FXY2dNZ29nSUNBZ1luUnZhUW9nSUNBZ1lYTnpaWEowSUM4dklIQnlhV05sSUcxMWMzUWdZbVVnUGlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpBMUxUSXhNQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVFYTnpaWFFvYzJWc1ppNWhZWEp1WVY5aGMzTmxkQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYzJWdVpHVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlZVzF2ZFc1MExtNWhkR2wyWlN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lNRGNLSUNBZ0lDOHZJR0Z6YzJWMFgzTmxibVJsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakl3T0FvZ0lDQWdMeThnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRk5sYm1SbGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG95TURVS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpBMUxUSXhNQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVFYTnpaWFFvYzJWc1ppNWhZWEp1WVY5aGMzTmxkQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYzJWdVpHVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlZVzF2ZFc1MExtNWhkR2wyWlN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNakV5Q2lBZ0lDQXZMeUJwWkhnZ1BTQnpaV3htTG14cGMzUnBibWRmWTI5MWJuUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKc2FYTjBhVzVuWDJOdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14cGMzUnBibWRmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpFMENpQWdJQ0F2THlCelpXeHNaWEk5WVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pJeE15MHlNVGdLSUNBZ0lDOHZJSE5sYkdZdWJHbHpkR2x1WjNOYmFXUjRYU0E5SUV4cGMzUnBibWRTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnYzJWc2JHVnlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJSEJ5YVdObFBYQnlhV05sWDNCbGNsOTBiMnRsYml3S0lDQWdJQzh2SUNBZ0lDQmhZM1JwZG1VOVlYSmpOQzVWU1c1ME5qUW9NU2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFlYSnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveU1UY0tJQ0FnSUM4dklHRmpkR2wyWlQxaGNtTTBMbFZKYm5RMk5DZ3hLU3dLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1qRXpMVEl4T0FvZ0lDQWdMeThnYzJWc1ppNXNhWE4wYVc1bmMxdHBaSGhkSUQwZ1RHbHpkR2x1WjFKbFkyOXlaQ2dLSUNBZ0lDOHZJQ0FnSUNCelpXeHNaWEk5WVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnY0hKcFkyVTljSEpwWTJWZmNHVnlYM1J2YTJWdUxBb2dJQ0FnTHk4Z0lDQWdJR0ZqZEdsMlpUMWhjbU0wTGxWSmJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pJeE13b2dJQ0FnTHk4Z2MyVnNaaTVzYVhOMGFXNW5jMXRwWkhoZElEMGdUR2x6ZEdsdVoxSmxZMjl5WkNnS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE5tTUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lNVE10TWpFNENpQWdJQ0F2THlCelpXeG1MbXhwYzNScGJtZHpXMmxrZUYwZ1BTQk1hWE4wYVc1blVtVmpiM0prS0FvZ0lDQWdMeThnSUNBZ0lITmxiR3hsY2oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCd2NtbGpaVDF3Y21salpWOXdaWEpmZEc5clpXNHNDaUFnSUNBdkx5QWdJQ0FnWVdOMGFYWmxQV0Z5WXpRdVZVbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpFNUNpQWdJQ0F2THlCelpXeG1MbXhwYzNScGJtZGZZMjkxYm5RZ1BTQnBaSGdnS3lCVlNXNTBOalFvTVNrS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnNhWE4wYVc1blgyTnZkVzUwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94T0RndE1Ua3hDaUFnSUNBdkx5QWpJT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa0FvZ0lDQWdMeThnSXlCTllYSnJaWFJ3YkdGalpRb2dJQ0FnTHk4Z0l5RGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoWVhKdVlWOXlaV2RwYzNSeWVTNWpiMjUwY21GamRDNUJZWEp1WVZKbFoybHpkSEo1TG1KMWVWOXNhWE4wYVc1blczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZblY1WDJ4cGMzUnBibWM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNakl5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG95TWpjS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtRmhjbTVoWDJGemMyVjBMQ0FpYm04Z1FVRlNUa0VnZEc5clpXNGlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXRnlibUZmWVhOelpYUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdGeWJtRmZZWE56WlhRZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QnVieUJCUVZKT1FTQjBiMnRsYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakl5T0FvZ0lDQWdMeThnYkdsa0lEMGdiR2x6ZEdsdVoxOXBaQzV1WVhScGRtVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakl5T1FvZ0lDQWdMeThnWVhOelpYSjBJR3hwWkNBOElITmxiR1l1YkdsemRHbHVaMTlqYjNWdWRDd2dJbWx1ZG1Gc2FXUWdiR2x6ZEdsdVp5QnBaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnNhWE4wYVc1blgyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxteHBjM1JwYm1kZlkyOTFiblFnWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYkdsemRHbHVaeUJwWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakl6TUFvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNXNhWE4wYVc1bmMxdHNhV1JkTG1OdmNIa29LUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nT1NBdkx5QXdlRFpqQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJHbHpkR2x1WjNNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1qTXhDaUFnSUNBdkx5QmhjM05sY25RZ2NtVmpiM0prTG1GamRHbDJaU0E5UFNCaGNtTTBMbFZKYm5RMk5DZ3hLU3dnSW14cGMzUnBibWNnYm05MElHRmpkR2wyWlNJS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBPQ0E0Q2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNUW9nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2JHbHpkR2x1WnlCdWIzUWdZV04wYVhabENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpNekNpQWdJQ0F2THlCMGIzUmhiRjlqYjNOMElEMGdjbVZqYjNKa0xtRnRiM1Z1ZEM1dVlYUnBkbVVnS2lCeVpXTnZjbVF1Y0hKcFkyVXVibUYwYVhabENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eklDOHZJRFF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURFS0lDQWdJQ29LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lNelFLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExtNWhkR2wyWlNBK1BTQjBiM1JoYkY5amIzTjBMQ0FpYVc1emRXWm1hV05wWlc1MElIQmhlVzFsYm5RaUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHSjBiMmtLSUNBZ0lHUnBaeUF4Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVjM1ZtWm1samFXVnVkQ0J3WVhsdFpXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1qTTJMVEkwTUFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlRWE56WlhRb2MyVnNaaTVoWVhKdVlWOWhjM05sZENrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROWNtVmpiM0prTG1GdGIzVnVkQzV1WVhScGRtVXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpNNENpQWdJQ0F2THlCaGMzTmxkRjl5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lNellLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUJoZUdabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNak0yTFRJME1Bb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5UVhOelpYUW9jMlZzWmk1aFlYSnVZVjloYzNObGRDa3NDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTljbVZqYjNKa0xtRnRiM1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmhjbTVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qSTBNaTB5TkRVS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF5WldOdmNtUXVjMlZzYkdWeUxtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWRHOTBZV3hmWTI5emRDd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG95TkRNS0lDQWdJQzh2SUhKbFkyVnBkbVZ5UFhKbFkyOXlaQzV6Wld4c1pYSXVibUYwYVhabExBb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pJME1nb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpReUxUSTBOUW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBYSmxZMjl5WkM1elpXeHNaWEl1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDEwYjNSaGJGOWpiM04wTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lORGN0TWpRNENpQWdJQ0F2THlCeVpXTnZjbVF1WVdOMGFYWmxJRDBnWVhKak5DNVZTVzUwTmpRb01Da0tJQ0FnSUM4dklITmxiR1l1YkdsemRHbHVaM05iYkdsa1hTQTlJSEpsWTI5eVpDNWpiM0I1S0NrS0lDQWdJSEIxYzJocGJuUWdORGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lORGNLSUNBZ0lDOHZJSEpsWTI5eVpDNWhZM1JwZG1VZ1BTQmhjbU0wTGxWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ01USWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNalEzTFRJME9Bb2dJQ0FnTHk4Z2NtVmpiM0prTG1GamRHbDJaU0E5SUdGeVl6UXVWVWx1ZERZMEtEQXBDaUFnSUNBdkx5QnpaV3htTG14cGMzUnBibWR6VzJ4cFpGMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JpYjNoZmNtVndiR0ZqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakl5TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GaGNtNWhYM0psWjJsemRISjVMbU52Ym5SeVlXTjBMa0ZoY201aFVtVm5hWE4wY25rdVkyRnVZMlZzWDJ4cGMzUnBibWRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwallXNWpaV3hmYkdsemRHbHVaem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lOVEFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmhjbTVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qSTFNd29nSUNBZ0x5OGdiR2xrSUQwZ2JHbHpkR2x1WjE5cFpDNXVZWFJwZG1VS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG95TlRRS0lDQWdJQzh2SUdGemMyVnlkQ0JzYVdRZ1BDQnpaV3htTG14cGMzUnBibWRmWTI5MWJuUXNJQ0pwYm5aaGJHbGtJR3hwYzNScGJtY2dhV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWliR2x6ZEdsdVoxOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXNhWE4wYVc1blgyTnZkVzUwSUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lENEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUd4cGMzUnBibWNnYVdRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG95TlRVS0lDQWdJQzh2SUhKbFkyOXlaQ0E5SUhObGJHWXViR2x6ZEdsdVozTmJiR2xrWFM1amIzQjVLQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGcyWXdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxteHBjM1JwYm1keklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmhjbTVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qSTFOZ29nSUNBZ0x5OGdZWE56WlhKMElISmxZMjl5WkM1aFkzUnBkbVVnUFQwZ1lYSmpOQzVWU1c1ME5qUW9NU2tzSUNKc2FYTjBhVzVuSUc1dmRDQmhZM1JwZG1VaUNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdORGdnT0FvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREVLSUNBZ0lHSTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHeHBjM1JwYm1jZ2JtOTBJR0ZqZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pJMU53b2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjbVZqYjNKa0xuTmxiR3hsY2k1dVlYUnBkbVVzSUNKdmJteDVJSE5sYkd4bGNpQmpZVzRnWTJGdVkyVnNJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYjI1c2VTQnpaV3hzWlhJZ1kyRnVJR05oYm1ObGJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pJMU9TMHlOak1LSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0hObGJHWXVZV0Z5Ym1GZllYTnpaWFFwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFhKbFkyOXlaQzV6Wld4c1pYSXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxeVpXTnZjbVF1WVcxdmRXNTBMbTVoZEdsMlpTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWVhKdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG95TmpBS0lDQWdJQzh2SUhobVpYSmZZWE56WlhROVFYTnpaWFFvYzJWc1ppNWhZWEp1WVY5aGMzTmxkQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZV0Z5Ym1GZllYTnpaWFFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXRnlibUZmWVhOelpYUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpZeUNpQWdJQ0F2THlCaGMzTmxkRjloYlc5MWJuUTljbVZqYjNKa0xtRnRiM1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpVNUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pJMU9TMHlOak1LSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0hObGJHWXVZV0Z5Ym1GZllYTnpaWFFwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFhKbFkyOXlaQzV6Wld4c1pYSXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxeVpXTnZjbVF1WVcxdmRXNTBMbTVoZEdsMlpTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpZMUxUSTJOZ29nSUNBZ0x5OGdjbVZqYjNKa0xtRmpkR2wyWlNBOUlHRnlZelF1VlVsdWREWTBLREFwQ2lBZ0lDQXZMeUJ6Wld4bUxteHBjM1JwYm1kelcyeHBaRjBnUFNCeVpXTnZjbVF1WTI5d2VTZ3BDaUFnSUNCd2RYTm9hVzUwSURRNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpZMUNpQWdJQ0F2THlCeVpXTnZjbVF1WVdOMGFYWmxJRDBnWVhKak5DNVZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJREV5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pJMk5TMHlOallLSUNBZ0lDOHZJSEpsWTI5eVpDNWhZM1JwZG1VZ1BTQmhjbU0wTGxWSmJuUTJOQ2d3S1FvZ0lDQWdMeThnYzJWc1ppNXNhWE4wYVc1bmMxdHNhV1JkSUQwZ2NtVmpiM0prTG1OdmNIa29LUW9nSUNBZ1ltOTRYM0psY0d4aFkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFlYSnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveU5UQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWhZWEp1WVY5eVpXZHBjM1J5ZVM1amIyNTBjbUZqZEM1QllYSnVZVkpsWjJsemRISjVMbWRsZEY5d2NtOXFaV04wWDJOdmRXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzQnliMnBsWTNSZlkyOTFiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNamN6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNXdjbTlxWldOMFgyTnZkVzUwS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkJ5YjJwbFkzUmZZMjkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjSEp2YW1WamRGOWpiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lOamd0TWpjeENpQWdJQ0F2THlBaklPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrT0tWa09LVmtPS1ZrQW9nSUNBZ0x5OGdJeUJTWldGa0xVOXViSGtnUjJWMGRHVnljeURpZ0pRZ1ptbGxiR1FnWVdOalpYTnpJR1p5YjIwZ1lYSmpOQzVUZEhKMVkzUWdZMjl3ZVFvZ0lDQWdMeThnSXlEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaRGlsWkRpbFpEaWxaQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aFlYSnVZVjl5WldkcGMzUnllUzVqYjI1MGNtRmpkQzVCWVhKdVlWSmxaMmx6ZEhKNUxtZGxkRjloYzNObGRGOXBaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOWhjM05sZEY5cFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFlYSnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveU56Y0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG1GaGNtNWhYMkZ6YzJWMEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GaGNtNWhYMkZ6YzJWMElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZoY201aFgyRnpjMlYwSUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmhjbTVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qSTNOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRmhjbTVoWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGtGaGNtNWhVbVZuYVhOMGNua3VaMlYwWDJGa2JXbHVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyRmtiV2x1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakk0TVFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVlXUnRhVzR1WTI5d2VTZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1qYzVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXRnlibUZmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1UVdGeWJtRlNaV2RwYzNSeWVTNW5aWFJmZG1Gc2FXUmhkRzl5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYM1poYkdsa1lYUnZjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZWEp1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lPRFVLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG5aaGJHbGtZWFJ2Y2k1amIzQjVLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklDSjJZV3hwWkdGMGIzSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZG1Gc2FXUmhkRzl5SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmhjbTVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qSTRNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRmhjbTVoWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGtGaGNtNWhVbVZuYVhOMGNua3VaMlYwWDNSdmRHRnNYMk55WldScGRITmZhWE56ZFdWa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNSdmRHRnNYMk55WldScGRITmZhWE56ZFdWa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pJNE9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEc5MFlXeGZZM0psWkdsMGMxOXBjM04xWldRcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09DQXZMeUFpZEc5MFlXeGZZM0psWkdsMGMxOXBjM04xWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZlkzSmxaR2wwYzE5cGMzTjFaV1FnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1qZzNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXRnlibUZmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1UVdGeWJtRlNaV2RwYzNSeWVTNW5aWFJmY0hKdmFtVmpkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOXdjbTlxWldOME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pJNU1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNamt6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1d2NtOXFaV04wYzF0d2NtOXFaV04wWDJsa0xtNWhkR2wyWlYwdVkyOXdlU2dwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TnpBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjSEp2YW1WamRITWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0Z5Ym1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNamt4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV0Z5Ym1GZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVFXRnlibUZTWldkcGMzUnllUzVuWlhSZmJHbHpkR2x1WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjlzYVhOMGFXNW5PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmhjbTVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qSTVOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWprM0NpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXNhWE4wYVc1bmMxdHNhWE4wYVc1blgybGtMbTVoZEdsMlpWMHVZMjl3ZVNncENpQWdJQ0JpZEc5cENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE5tTUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YkdsemRHbHVaM01nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWprMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVdGeWJtRmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVRV0Z5Ym1GU1pXZHBjM1J5ZVM1blpYUmZiR2x6ZEdsdVoxOWpiM1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjlzYVhOMGFXNW5YMk52ZFc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaGNtNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pNd01Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1YkdsemRHbHVaMTlqYjNWdWRDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKc2FYTjBhVzVuWDJOdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14cGMzUnBibWRmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdGeWJtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWprNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVdGeWJtRmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVRV0Z5Ym1GU1pXZHBjM1J5ZVM1ZmIyNXNlVjloWkcxcGJpZ3BJQzArSUhadmFXUTZDbDl2Ym14NVgyRmtiV2x1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZoY201aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalkwQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbUZrYldsdUxtNWhkR2wyWlN3Z0luVnVZWFYwYUc5eWFYcGxaRG9nWVdSdGFXNGdiMjVzZVNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RXNWhkWFJvYjNKcGVtVmtPaUJoWkcxcGJpQnZibXg1Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV0Z5Ym1GZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVFXRnlibUZTWldkcGMzUnllUzVmYjI1c2VWOTJZV3hwWkdGMGIzSW9LU0F0UGlCMmIybGtPZ3BmYjI1c2VWOTJZV3hwWkdGMGIzSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXRnlibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdWRtRnNhV1JoZEc5eUxtNWhkR2wyWlN3Z0luVnVZWFYwYUc5eWFYcGxaRG9nZG1Gc2FXUmhkRzl5SUc5dWJIa2lDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ055QXZMeUFpZG1Gc2FXUmhkRzl5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuWmhiR2xrWVhSdmNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkVzVoZFhSb2IzSnBlbVZrT2lCMllXeHBaR0YwYjNJZ2IyNXNlUW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVJS0NZTkJCVWZmSFVMWVdGeWJtRmZZWE56WlhRTmNISnZhbVZqZEY5amIzVnVkQTFzYVhOMGFXNW5YMk52ZFc1MEJXRmtiV2x1QVhBSUFBQUFBQUFBQUFFSmRtRnNhV1JoZEc5eUZIUnZkR0ZzWDJOeVpXUnBkSE5mYVhOemRXVmtBV3dJQUFBQUFBQUFBQUlJQUFBQUFBQUFBQVFJQUFBQUFBQUFBQUF4R0VBQUZ5Y0VNZ05uSndjeUEyY3BJbWNxSW1jbkNDSm5LeUpuTVJrVVJERVlRUUNHZ2hJRThTYlFTd1RUU1B1ekJBajdlM3dFb2hxQWR3Um1SZkw1QkNHWG1VTUVZbUtRWlFRaWI2STNCREdPUXlJRVk5VmJiQVF3WG5XOUJGdWlLb1FFTkdzOXZBVHpqbWxCQkY4YzB0d0VDaHhsYmdRV3J0NXVCQjNycE9rMkdnQ09FZ0FXQUNnQVB3Q3ZBVmdCbVFISUFqTUNqd0wrQTBvRFZRTmdBMnNEZGdPQ0E1Z0RyZ0NBQklQeFIwZzJHZ0NPQVFBQkFDY0VNUUJuSTBNMkdnRkpGWUVnRWtTSUE1Y25CMHhuSTBNMkdnRkpGWUVnRWtTSUE0VkpNZ01UUkNjRVRHY2pRNGdEZHlJcFpVUkFBRnV4TWdwSEE3SXNzaXV5S3JJcGdCRm9kSFJ3Y3pvdkwyRmhjbTVoTG1WamI3SW5nQk5CWVhKdVlTQkRZWEppYjI0Z1EzSmxaR2wwc2lhQUJVRkJVazVCc2lVaXNpUWlzaU9CZ0szaUJMSWlnUU95RUNLeUFiTXB0RHhuSWlsbFJCWW9URkN3STBNMkdnRkpJbG1CQWdoTEFSVkpUd0lTUkRZYUFra2lXWUVDQ0VzQkZVbFBBaEpFTmhvRFNTSlpnUUlJU3dFVlNVOENFa1EyR2dSSklsbUJBZ2hMQVJVU1JDSXFaVVF4QUlBQ0FEaFFnVGhQQ0FoSkZsY0dBazhDVEZCTVR3WUlTUlpYQmdKUEFreFFURThFQ0JaWEJnSlFnQkFBQUFBQUFBQUFBUUFBQUFBQUFBQUFVRThGVUU4RVVFOERVRThDVUVzQkZpY0ZTd0ZRU2J4SVR3Sy9UQ01JS2t4bktFeFFzQ05ETmhvQlNSVWtFa1EyR2dKSkZTUVNSSWdDV0V3WElpcGxSRXNCRFVSTEFSZEVGaWNGVEZCSnZrUkxBU1VrdWljR3FFUW5DbHdvVHdKY01Fc0J2RWkvSTBNMkdnRkpGU1FTUklnQ0h4Y2lLbVZFU3dFTlJCWW5CVXhRU1NVa3VpY0dxRVFsZ0FnQUFBQUFBQUFBQTdzalF6WWFBVWtWSkJKRWlBSHdJaWxsUkVsRVRCY2lLbVZFU3dFTlJCWW5CVXhRU2I1RVN3RWxKTG9uQ3FoRXNVc0JJb0VndWtzQ2dUQWt1aGV5RXJJVVR3S3lFWUVFc2hBaXNnR3pKd3RjS0V3bEp3dTdTVmN3Q0V5Qk1Gc2lKd2hsUkFnbkNFeG5LRXhRc0NORE5ob0JTUlVrRWtRMkdnSkpGU1FTUkNJcFpVUkpSRXNDRjBsRVN3SVhSTEV4QURJS1R3S3lFcklVc2hPeUVZRUVzaEFpc2dHeklpdGxSREVBVHdOUVR3SlFKd1pRU3dFV0p3bExBVkJQQXI5TUl3Z3JUR2NvVEZDd0kwTTJHZ0ZKRlNRU1JEWWFBa2tWSkJKRUlpbGxSRWxFVHdJWElpdGxSRXNCRFVRV0p3bE1VRW0rUkVsWE1BZ25CcWhFU1lFZ1cwc0JKVnRMQVF0UEJSZExBUTlFc1RFQVR3S3lFcklVVHdPeUVZRUVzaEFpc2dHenNVeFhBQ0N5QjdJSUk3SVFJcklCczRFd0p3eTdJME0yR2dGSkZTUVNSQmNpSzJWRVN3RU5SQlluQ1V4UVNiNUVTVmN3Q0NjR3FFUXhBRXNCVndBZ1RFc0JFa1N4SWlsbFJFOENnU0Jic2hLeUViSVVnUVN5RUNLeUFiT0JNQ2NNdXlORElpcGxSQllvVEZDd0kwTWlLV1ZFRmloTVVMQWpReUluQkdWRUtFeFFzQ05ESWljSFpVUW9URkN3STBNaUp3aGxSQllvVEZDd0kwTTJHZ0ZKRlNRU1JCY1dKd1ZNVUw1RUtFeFFzQ05ETmhvQlNSVWtFa1FYRmljSlRGQytSQ2hNVUxBalF5SXJaVVFXS0V4UXNDTkRNUUFpSndSbFJCSkVpVEVBSWljSFpVUVNSSWs9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
