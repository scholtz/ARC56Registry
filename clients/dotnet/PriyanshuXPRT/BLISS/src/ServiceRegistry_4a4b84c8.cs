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

namespace Arc56.Generated.PriyanshuXPRT.BLISS.ServiceRegistry_4a4b84c8
{


    //
    // 
    //    A2A Service Registry — autonomous agents discover services here.
    //
    //    Implements the discovery half of the A2A Agentic Commerce Framework
    //    (Track: Agentic Commerce → Advanced #7).
    //
    //    Each registered service is stored in its OWN box (Box Storage), so the
    //    registry scales to thousands of services without bumping global schema.
    //
    //    State:
    //        Box "svc:<service_id>"  → ServiceListing (provider, price, cycle, name)
    //        GlobalState.admin       → registry admin (can prune stale entries)
    //        GlobalState.fee_micro   → registration fee (anti-spam)
    //        GlobalState.count       → total registered services
    //
    //    Anyone can register a service by paying `fee_micro` ALGO; only the
    //    provider can update or delete their own entry.
    //    
    //
    public class ServiceRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ServiceRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ServiceListing : AVMObjectType
            {
                public Algorand.Address Provider { get; set; }

                public ulong PriceMicroalgos { get; set; }

                public ulong CycleDays { get; set; }

                public string Name { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProvider = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vProvider.From(Provider);
                    ret.AddRange(vProvider.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPriceMicroalgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPriceMicroalgos.From(PriceMicroalgos);
                    ret.AddRange(vPriceMicroalgos.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCycleDays = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCycleDays.From(CycleDays);
                    ret.AddRange(vCycleDays.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
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

                public static ServiceListing Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ServiceListing();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProvider = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vProvider.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProvider = vProvider.ToValue();
                    if (valueProvider is Algorand.Address vProviderValue) { ret.Provider = vProviderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPriceMicroalgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPriceMicroalgos.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePriceMicroalgos = vPriceMicroalgos.ToValue();
                    if (valuePriceMicroalgos is ulong vPriceMicroalgosValue) { ret.PriceMicroalgos = vPriceMicroalgosValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCycleDays = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCycleDays.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCycleDays = vCycleDays.ToValue();
                    if (valueCycleDays is ulong vCycleDaysValue) { ret.CycleDays = vCycleDaysValue; }
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ServiceListing);
                }
                public bool Equals(ServiceListing? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ServiceListing left, ServiceListing right)
                {
                    return EqualityComparer<ServiceListing>.Default.Equals(left, right);
                }
                public static bool operator !=(ServiceListing left, ServiceListing right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the registry. Sender becomes admin.
        ///</summary>
        /// <param name="fee_micro"> </param>
        public async Task Create(ulong fee_micro, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var fee_microAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_microAbi.From(fee_micro);

            var result = await base.CallApp(new List<object> { abiHandle, fee_microAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong fee_micro, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var fee_microAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_microAbi.From(fee_micro);

            return await base.MakeTransactionList(new List<object> { abiHandle, fee_microAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register or update a service. Caller must have paid `fee_micro`
        ///in a grouped Payment txn (verified by min-balance accounting). Only the original provider can re-register the same service_id.
        ///</summary>
        /// <param name="service_id"> </param>
        /// <param name="price_microalgos"> </param>
        /// <param name="cycle_days"> </param>
        /// <param name="name"> </param>
        public async Task Register(string service_id, ulong price_microalgos, ulong cycle_days, string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 88, 5, 75 };
            var service_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); service_idAbi.From(service_id);
            var price_microalgosAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_microalgosAbi.From(price_microalgos);
            var cycle_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cycle_daysAbi.From(cycle_days);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, service_idAbi, price_microalgosAbi, cycle_daysAbi, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Register_Transactions(string service_id, ulong price_microalgos, ulong cycle_days, string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 88, 5, 75 };
            var service_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); service_idAbi.From(service_id);
            var price_microalgosAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_microalgosAbi.From(price_microalgos);
            var cycle_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cycle_daysAbi.From(cycle_days);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, service_idAbi, price_microalgosAbi, cycle_daysAbi, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Provider removes their own listing.
        ///</summary>
        /// <param name="service_id"> </param>
        public async Task Deregister(string service_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 77, 184, 184 };
            var service_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); service_idAbi.From(service_id);

            var result = await base.CallApp(new List<object> { abiHandle, service_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deregister_Transactions(string service_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 77, 184, 184 };
            var service_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); service_idAbi.From(service_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, service_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read-only lookup used by agents during discovery.
        ///</summary>
        /// <param name="service_id"> </param>
        public async Task<Structs.ServiceListing> GetListing(string service_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 124, 157, 96 };
            var service_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); service_idAbi.From(service_id);

            var result = await base.SimApp(new List<object> { abiHandle, service_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ServiceListing.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetListing_Transactions(string service_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 124, 157, 96 };
            var service_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); service_idAbi.From(service_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, service_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Number of registered services.
        ///</summary>
        public async Task<ulong> GetCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 95, 149, 137 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 95, 149, 137 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2VydmljZVJlZ2lzdHJ5IiwiZGVzYyI6IlxuICAgIEEyQSBTZXJ2aWNlIFJlZ2lzdHJ5IOKAlCBhdXRvbm9tb3VzIGFnZW50cyBkaXNjb3ZlciBzZXJ2aWNlcyBoZXJlLlxuXG4gICAgSW1wbGVtZW50cyB0aGUgZGlzY292ZXJ5IGhhbGYgb2YgdGhlIEEyQSBBZ2VudGljIENvbW1lcmNlIEZyYW1ld29ya1xuICAgIChUcmFjazogQWdlbnRpYyBDb21tZXJjZSDihpIgQWR2YW5jZWQgIzcpLlxuXG4gICAgRWFjaCByZWdpc3RlcmVkIHNlcnZpY2UgaXMgc3RvcmVkIGluIGl0cyBPV04gYm94IChCb3ggU3RvcmFnZSksIHNvIHRoZVxuICAgIHJlZ2lzdHJ5IHNjYWxlcyB0byB0aG91c2FuZHMgb2Ygc2VydmljZXMgd2l0aG91dCBidW1waW5nIGdsb2JhbCBzY2hlbWEuXG5cbiAgICBTdGF0ZTpcbiAgICAgICAgQm94IFwic3ZjOjxzZXJ2aWNlX2lkPlwiICDihpIgU2VydmljZUxpc3RpbmcgKHByb3ZpZGVyLCBwcmljZSwgY3ljbGUsIG5hbWUpXG4gICAgICAgIEdsb2JhbFN0YXRlLmFkbWluICAgICAgIOKGkiByZWdpc3RyeSBhZG1pbiAoY2FuIHBydW5lIHN0YWxlIGVudHJpZXMpXG4gICAgICAgIEdsb2JhbFN0YXRlLmZlZV9taWNybyAgIOKGkiByZWdpc3RyYXRpb24gZmVlIChhbnRpLXNwYW0pXG4gICAgICAgIEdsb2JhbFN0YXRlLmNvdW50ICAgICAgIOKGkiB0b3RhbCByZWdpc3RlcmVkIHNlcnZpY2VzXG5cbiAgICBBbnlvbmUgY2FuIHJlZ2lzdGVyIGEgc2VydmljZSBieSBwYXlpbmcgYGZlZV9taWNyb2AgQUxHTzsgb25seSB0aGVcbiAgICBwcm92aWRlciBjYW4gdXBkYXRlIG9yIGRlbGV0ZSB0aGVpciBvd24gZW50cnkuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlNlcnZpY2VMaXN0aW5nIjpbeyJuYW1lIjoicHJvdmlkZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InByaWNlX21pY3JvYWxnb3MiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY3ljbGVfZGF5cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjoiSW5pdGlhbGl6ZSB0aGUgcmVnaXN0cnkuIFNlbmRlciBiZWNvbWVzIGFkbWluLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVfbWljcm8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXIiLCJkZXNjIjoiUmVnaXN0ZXIgb3IgdXBkYXRlIGEgc2VydmljZS4gQ2FsbGVyIG11c3QgaGF2ZSBwYWlkIGBmZWVfbWljcm9gXG5pbiBhIGdyb3VwZWQgUGF5bWVudCB0eG4gKHZlcmlmaWVkIGJ5IG1pbi1iYWxhbmNlIGFjY291bnRpbmcpLiBPbmx5IHRoZSBvcmlnaW5hbCBwcm92aWRlciBjYW4gcmUtcmVnaXN0ZXIgdGhlIHNhbWUgc2VydmljZV9pZC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VydmljZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VfbWljcm9hbGdvcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3ljbGVfZGF5cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXJlZ2lzdGVyIiwiZGVzYyI6IlByb3ZpZGVyIHJlbW92ZXMgdGhlaXIgb3duIGxpc3RpbmcuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlcnZpY2VfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2xpc3RpbmciLCJkZXNjIjoiUmVhZC1vbmx5IGxvb2t1cCB1c2VkIGJ5IGFnZW50cyBkdXJpbmcgZGlzY292ZXJ5LiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZXJ2aWNlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCx1aW50NjQsc3RyaW5nKSIsInN0cnVjdCI6IlNlcnZpY2VMaXN0aW5nIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY291bnQiLCJkZXNjIjoiTnVtYmVyIG9mIHJlZ2lzdGVyZWQgc2VydmljZXMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE4OF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgb3JpZ2luYWwgcHJvdmlkZXIgY2FuIHVwZGF0ZSB0aGlzIHNlcnZpY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzBdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHByb3ZpZGVyIG9yIGFkbWluIGNhbiBkZXJlZ2lzdGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ3LDMwOV0sImVycm9yTWVzc2FnZSI6IlNlcnZpY2Ugbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZG1pbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTcsMjc3LDMyMV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg2LDI1NF0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjYsMTYyLDIzMSwyOTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzMsMTY4LDIzOCwzMDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTcsMTQzLDE1M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTWlBNENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKamIzVnVkQ0lnSW5OMll6b2lJQ0poWkcxcGJpSWdNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TWpNS0lDQWdJQzh2SUdOc1lYTnpJRk5sY25acFkyVlNaV2RwYzNSeWVTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR0kyTlRnd05UUmlJREI0T0dVMFpHSTRZamdnTUhoallUZGpPV1EyTUNBd2VEYzFOV1k1TlRnNUlDOHZJRzFsZEdodlpDQWljbVZuYVhOMFpYSW9jM1J5YVc1bkxIVnBiblEyTkN4MWFXNTBOalFzYzNSeWFXNW5LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltUmxjbVZuYVhOMFpYSW9jM1J5YVc1bktYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOXNhWE4wYVc1bktITjBjbWx1Wnlrb1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMSE4wY21sdVp5a2lMQ0J0WlhSb2IyUWdJbWRsZEY5amIzVnVkQ2dwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnY21WbmFYTjBaWElnWkdWeVpXZHBjM1JsY2lCblpYUmZiR2x6ZEdsdVp5Qm5aWFJmWTI5MWJuUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJekNpQWdJQ0F2THlCamJHRnpjeUJUWlhKMmFXTmxVbVZuYVhOMGNua29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURJME1HUXlaalkzSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0hWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZM0psWVhSbENpQWdJQ0JsY25JS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMlZ5ZG1salpWOXlaV2RwYzNSeWVTNWpiMjUwY21GamRDNVRaWEoyYVdObFVtVm5hWE4wY25rdVkzSmxZWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsT2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRMQ0JqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5USUtJQ0FnSUM4dklITmxiR1l1WVdSdGFXNHVkbUZzZFdVZ1BTQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1Ga2JXbHVJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPalV6Q2lBZ0lDQXZMeUJ6Wld4bUxtWmxaVjl0YVdOeWJ5NTJZV3gxWlNBOUlHWmxaVjl0YVdOeWJ5NXVZWFJwZG1VS0lDQWdJR0owYjJrS0lDQWdJSEIxYzJoaWVYUmxjeUFpWm1WbFgyMXBZM0p2SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qVTBDaUFnSUNBdkx5QnpaV3htTG1OdmRXNTBMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpiM1Z1ZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRMQ0JqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1elpYSjJhV05sWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGxObGNuWnBZMlZTWldkcGMzUnllUzV5WldkcGMzUmxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFoybHpkR1Z5T2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5UWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5qa0tJQ0FnSUM4dklHbG1JSE5sY25acFkyVmZhV1FnYVc0Z2MyVnNaaTVzYVhOMGFXNW5jem9LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbk4yWXpvaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJ5WldkcGMzUmxjbDlsYkhObFgySnZaSGxBTXdvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk56SUtJQ0FnSUM4dklHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1NBOVBTQmxlR2x6ZEdsdVp5NXdjbTkyYVdSbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdQVDBLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pjeExUY3pDaUFnSUNBdkx5QmhjM05sY25RZ0tBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTQTlQU0JsZUdsemRHbHVaeTV3Y205MmFXUmxjZ29nSUNBZ0x5OGdLU3dnSWs5dWJIa2diM0pwWjJsdVlXd2djSEp2ZG1sa1pYSWdZMkZ1SUhWd1pHRjBaU0IwYUdseklITmxjblpwWTJVaUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQnZjbWxuYVc1aGJDQndjbTkyYVdSbGNpQmpZVzRnZFhCa1lYUmxJSFJvYVhNZ2MyVnlkbWxqWlFvS2NtVm5hWE4wWlhKZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk56Z0tJQ0FnSUM4dklIQnliM1pwWkdWeVBXRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pjM0xUZ3lDaUFnSUNBdkx5QnpaV3htTG14cGMzUnBibWR6VzNObGNuWnBZMlZmYVdSZElEMGdVMlZ5ZG1salpVeHBjM1JwYm1jb0NpQWdJQ0F2THlBZ0lDQWdjSEp2ZG1sa1pYSTlZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJSEJ5YVdObFgyMXBZM0p2WVd4bmIzTTljSEpwWTJWZmJXbGpjbTloYkdkdmN5d0tJQ0FnSUM4dklDQWdJQ0JqZVdOc1pWOWtZWGx6UFdONVkyeGxYMlJoZVhNc0NpQWdJQ0F2THlBZ0lDQWdibUZ0WlQxdVlXMWxMQW9nSUNBZ0x5OGdLUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXpNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pVMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2NtVm5hWE4wWlhKZlpXeHpaVjlpYjJSNVFETTZDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8zTlFvZ0lDQWdMeThnYzJWc1ppNWpiM1Z1ZEM1MllXeDFaU0E5SUhObGJHWXVZMjkxYm5RdWRtRnNkV1VnS3lCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqYjNWdWRDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpiM1Z1ZENJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpSUhKbFoybHpkR1Z5WDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1elpYSjJhV05sWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGxObGNuWnBZMlZTWldkcGMzUnllUzVrWlhKbFoybHpkR1Z5VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVnlaV2RwYzNSbGNqb0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPamcwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZPRGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaWEoyYVdObFgybGtJR2x1SUhObGJHWXViR2x6ZEdsdVozTXNJQ0pUWlhKMmFXTmxJRzV2ZENCbWIzVnVaQ0lLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbk4yWXpvaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVTJWeWRtbGpaU0J1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2prd0NpQWdJQ0F2THlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtnUFQwZ1pYaHBjM1JwYm1jdWNISnZkbWxrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1BUMEtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPamt3TFRreENpQWdJQ0F2THlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtnUFQwZ1pYaHBjM1JwYm1jdWNISnZkbWxrWlhJS0lDQWdJQzh2SUc5eUlHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1NBOVBTQnpaV3htTG1Ga2JXbHVMblpoYkhWbENpQWdJQ0JpYm5vZ1pHVnlaV2RwYzNSbGNsOWliMjlzWDNSeWRXVkFNd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2T1RFS0lDQWdJQzh2SUc5eUlHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1NBOVBTQnpaV3htTG1Ga2JXbHVMblpoYkhWbENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2T1RBdE9URUtJQ0FnSUM4dklHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1NBOVBTQmxlR2x6ZEdsdVp5NXdjbTkyYVdSbGNnb2dJQ0FnTHk4Z2IzSWdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcElEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVUtJQ0FnSUdKNklHUmxjbVZuYVhOMFpYSmZZbTl2YkY5bVlXeHpaVUEwQ2dwa1pYSmxaMmx6ZEdWeVgySnZiMnhmZEhKMVpVQXpPZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtDbVJsY21WbmFYTjBaWEpmWW05dmJGOXRaWEpuWlVBMU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZPRGt0T1RJS0lDQWdJQzh2SUdGemMyVnlkQ0FvQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwSUQwOUlHVjRhWE4wYVc1bkxuQnliM1pwWkdWeUNpQWdJQ0F2THlBZ0lDQWdiM0lnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBJRDA5SUhObGJHWXVZV1J0YVc0dWRtRnNkV1VLSUNBZ0lDOHZJQ2tzSUNKUGJteDVJSEJ5YjNacFpHVnlJRzl5SUdGa2JXbHVJR05oYmlCa1pYSmxaMmx6ZEdWeUlnb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2djSEp2ZG1sa1pYSWdiM0lnWVdSdGFXNGdZMkZ1SUdSbGNtVm5hWE4wWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qa3pDaUFnSUNBdkx5QmtaV3dnYzJWc1ppNXNhWE4wYVc1bmMxdHpaWEoyYVdObFgybGtYUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2prMENpQWdJQ0F2THlCelpXeG1MbU52ZFc1MExuWmhiSFZsSUQwZ2MyVnNaaTVqYjNWdWRDNTJZV3gxWlNBdElGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1OdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbU52ZFc1MElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPamcwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWkdWeVpXZHBjM1JsY2w5aWIyOXNYMlpoYkhObFFEUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCa1pYSmxaMmx6ZEdWeVgySnZiMnhmYldWeVoyVkFOUW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1elpYSjJhV05sWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGxObGNuWnBZMlZTWldkcGMzUnllUzVuWlhSZmJHbHpkR2x1WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjlzYVhOMGFXNW5PZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2T1RZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk9Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpYSjJhV05sWDJsa0lHbHVJSE5sYkdZdWJHbHpkR2x1WjNNc0lDSlRaWEoyYVdObElHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luTjJZem9pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1UyVnlkbWxqWlNCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRXdNQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1YkdsemRHbHVaM05iYzJWeWRtbGpaVjlwWkYwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qazJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMyVnlkbWxqWlY5eVpXZHBjM1J5ZVM1amIyNTBjbUZqZEM1VFpYSjJhV05sVW1WbmFYTjBjbmt1WjJWMFgyTnZkVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMk52ZFc1ME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVEExQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWpiM1Z1ZEM1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFd01nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNDQ1lFQldOdmRXNTBCSE4yWXpvRllXUnRhVzRFRlI5OGRURVpGRVF4R0VFQUpJSUVCTFpZQlVzRWprMjR1QVRLZkoxZ0JIVmZsWWsyR2dDT0JBQXVBSmNBMWdEekFJQUVKQTB2WnpZYUFJNEJBQUVBTmhvQlNSVWxFa1FxTVFCbkY0QUpabVZsWDIxcFkzSnZUR2NvSW1jalF6WWFBVWtpV1NRSVN3RVZFa1EyR2dKSlRnSVZKUkpFTmhvRFNVNENGU1VTUkRZYUJFbE9Ba2tpV1NRSVRCVVNSQ2xNVUVtOVJRRkJBQ014QUVzQklvRWd1aEpFTVFCTEJGQkxBMUNBQWdBeVVFc0NVRXNCU2J4SVRMOGpReUlvWlVRakNDaE1aMEwvMnpZYUFVa2lXU1FJU3dFVkVrUXBURkJIQXIxRkFVUXhBRXdpZ1NDNkVrQUFDakVBSWlwbFJCSkJBQkFqUkVtOFNDSW9aVVFqQ1NoTVp5TkRJa0wvN1RZYUFVa2lXU1FJU3dFVkVrUXBURkJKdlVVQlJMNUlLMHhRc0NORElpaGxSQllyVEZDd0kwTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
