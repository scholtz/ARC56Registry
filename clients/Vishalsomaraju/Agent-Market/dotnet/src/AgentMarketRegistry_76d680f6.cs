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

namespace Arc56.Generated.Vishalsomaraju.Agent_Market.AgentMarketRegistry_76d680f6
{


    public class AgentMarketRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgentMarketRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ServiceRecord : AVMObjectType
            {
                public ulong ServiceId { get; set; }

                public string Name { get; set; }

                public string Category { get; set; }

                public ulong PriceMicroAlgos { get; set; }

                public bool RequiresInput { get; set; }

                public ulong BaseRateMicroAlgos { get; set; }

                public ulong IncrementPerBlockMicroAlgos { get; set; }

                public ulong BlockSize { get; set; }

                public Algorand.Address ProviderAddress { get; set; }

                public ulong CompletedJobs { get; set; }

                public bool Active { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vServiceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vServiceId.From(ServiceId);
                    ret.AddRange(vServiceId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCategory = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCategory.From(Category);
                    stringRef[ret.Count] = vCategory.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPriceMicroAlgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPriceMicroAlgos.From(PriceMicroAlgos);
                    ret.AddRange(vPriceMicroAlgos.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequiresInput = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vRequiresInput.From(RequiresInput);
                    ret.AddRange(vRequiresInput.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaseRateMicroAlgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBaseRateMicroAlgos.From(BaseRateMicroAlgos);
                    ret.AddRange(vBaseRateMicroAlgos.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIncrementPerBlockMicroAlgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vIncrementPerBlockMicroAlgos.From(IncrementPerBlockMicroAlgos);
                    ret.AddRange(vIncrementPerBlockMicroAlgos.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBlockSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBlockSize.From(BlockSize);
                    ret.AddRange(vBlockSize.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProviderAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vProviderAddress.From(ProviderAddress);
                    ret.AddRange(vProviderAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCompletedJobs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCompletedJobs.From(CompletedJobs);
                    ret.AddRange(vCompletedJobs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static ServiceRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ServiceRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vServiceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vServiceId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueServiceId = vServiceId.ToValue();
                    if (valueServiceId is ulong vServiceIdValue) { ret.ServiceId = vServiceIdValue; }
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexCategory = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCategory = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCategory.Decode(bytes.Skip(indexCategory + prefixOffset).ToArray());
                    var valueCategory = vCategory.ToValue();
                    if (valueCategory is string vCategoryValue) { ret.Category = vCategoryValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPriceMicroAlgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPriceMicroAlgos.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePriceMicroAlgos = vPriceMicroAlgos.ToValue();
                    if (valuePriceMicroAlgos is ulong vPriceMicroAlgosValue) { ret.PriceMicroAlgos = vPriceMicroAlgosValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequiresInput = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vRequiresInput.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRequiresInput = vRequiresInput.ToValue();
                    if (valueRequiresInput is bool vRequiresInputValue) { ret.RequiresInput = vRequiresInputValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaseRateMicroAlgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBaseRateMicroAlgos.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBaseRateMicroAlgos = vBaseRateMicroAlgos.ToValue();
                    if (valueBaseRateMicroAlgos is ulong vBaseRateMicroAlgosValue) { ret.BaseRateMicroAlgos = vBaseRateMicroAlgosValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIncrementPerBlockMicroAlgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vIncrementPerBlockMicroAlgos.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIncrementPerBlockMicroAlgos = vIncrementPerBlockMicroAlgos.ToValue();
                    if (valueIncrementPerBlockMicroAlgos is ulong vIncrementPerBlockMicroAlgosValue) { ret.IncrementPerBlockMicroAlgos = vIncrementPerBlockMicroAlgosValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBlockSize = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBlockSize.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBlockSize = vBlockSize.ToValue();
                    if (valueBlockSize is ulong vBlockSizeValue) { ret.BlockSize = vBlockSizeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProviderAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vProviderAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProviderAddress = vProviderAddress.ToValue();
                    if (valueProviderAddress is Algorand.Address vProviderAddressValue) { ret.ProviderAddress = vProviderAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCompletedJobs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCompletedJobs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCompletedJobs = vCompletedJobs.ToValue();
                    if (valueCompletedJobs is ulong vCompletedJobsValue) { ret.CompletedJobs = vCompletedJobsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActive = vActive.ToValue();
                    if (valueActive is bool vActiveValue) { ret.Active = vActiveValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ServiceRecord);
                }
                public bool Equals(ServiceRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ServiceRecord left, ServiceRecord right)
                {
                    return EqualityComparer<ServiceRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(ServiceRecord left, ServiceRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="category"> </param>
        /// <param name="priceMicroAlgos"> </param>
        /// <param name="requiresInput"> </param>
        /// <param name="baseRateMicroAlgos"> </param>
        /// <param name="incrementPerBlockMicroAlgos"> </param>
        /// <param name="blockSize"> </param>
        public async Task<ulong> RegisterService(string name, string category, ulong priceMicroAlgos, bool requiresInput, ulong baseRateMicroAlgos, ulong incrementPerBlockMicroAlgos, ulong blockSize, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 99, 13, 76 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var categoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); categoryAbi.From(category);
            var priceMicroAlgosAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMicroAlgosAbi.From(priceMicroAlgos);
            var requiresInputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); requiresInputAbi.From(requiresInput);
            var baseRateMicroAlgosAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); baseRateMicroAlgosAbi.From(baseRateMicroAlgos);
            var incrementPerBlockMicroAlgosAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); incrementPerBlockMicroAlgosAbi.From(incrementPerBlockMicroAlgos);
            var blockSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blockSizeAbi.From(blockSize);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, categoryAbi, priceMicroAlgosAbi, requiresInputAbi, baseRateMicroAlgosAbi, incrementPerBlockMicroAlgosAbi, blockSizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegisterService_Transactions(string name, string category, ulong priceMicroAlgos, bool requiresInput, ulong baseRateMicroAlgos, ulong incrementPerBlockMicroAlgos, ulong blockSize, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 99, 13, 76 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var categoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); categoryAbi.From(category);
            var priceMicroAlgosAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMicroAlgosAbi.From(priceMicroAlgos);
            var requiresInputAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); requiresInputAbi.From(requiresInput);
            var baseRateMicroAlgosAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); baseRateMicroAlgosAbi.From(baseRateMicroAlgos);
            var incrementPerBlockMicroAlgosAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); incrementPerBlockMicroAlgosAbi.From(incrementPerBlockMicroAlgos);
            var blockSizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); blockSizeAbi.From(blockSize);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, categoryAbi, priceMicroAlgosAbi, requiresInputAbi, baseRateMicroAlgosAbi, incrementPerBlockMicroAlgosAbi, blockSizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="serviceId"> </param>
        /// <param name="newPriceMicroAlgos"> </param>
        public async Task UpdateServicePrice(ulong serviceId, ulong newPriceMicroAlgos, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 10, 162, 3 };
            var serviceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); serviceIdAbi.From(serviceId);
            var newPriceMicroAlgosAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newPriceMicroAlgosAbi.From(newPriceMicroAlgos);

            var result = await base.CallApp(new List<object> { abiHandle, serviceIdAbi, newPriceMicroAlgosAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateServicePrice_Transactions(ulong serviceId, ulong newPriceMicroAlgos, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 10, 162, 3 };
            var serviceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); serviceIdAbi.From(serviceId);
            var newPriceMicroAlgosAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newPriceMicroAlgosAbi.From(newPriceMicroAlgos);

            return await base.MakeTransactionList(new List<object> { abiHandle, serviceIdAbi, newPriceMicroAlgosAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="serviceId"> </param>
        public async Task DeactivateService(ulong serviceId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 45, 158, 148 };
            var serviceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); serviceIdAbi.From(serviceId);

            var result = await base.CallApp(new List<object> { abiHandle, serviceIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeactivateService_Transactions(ulong serviceId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 45, 158, 148 };
            var serviceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); serviceIdAbi.From(serviceId);

            return await base.MakeTransactionList(new List<object> { abiHandle, serviceIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="serviceId"> </param>
        public async Task RecordCompletion(ulong serviceId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 44, 82, 173 };
            var serviceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); serviceIdAbi.From(serviceId);

            var result = await base.CallApp(new List<object> { abiHandle, serviceIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordCompletion_Transactions(ulong serviceId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 44, 82, 173 };
            var serviceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); serviceIdAbi.From(serviceId);

            return await base.MakeTransactionList(new List<object> { abiHandle, serviceIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdlbnRNYXJrZXRSZWdpc3RyeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTZXJ2aWNlUmVjb3JkIjpbeyJuYW1lIjoic2VydmljZUlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im5hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiY2F0ZWdvcnkiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoicHJpY2VNaWNyb0FsZ29zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlcXVpcmVzSW5wdXQiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImJhc2VSYXRlTWljcm9BbGdvcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpbmNyZW1lbnRQZXJCbG9ja01pY3JvQWxnb3MiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYmxvY2tTaXplIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByb3ZpZGVyQWRkcmVzcyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiY29tcGxldGVkSm9icyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhY3RpdmUiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJyZWdpc3RlclNlcnZpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2F0ZWdvcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlTWljcm9BbGdvcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVpcmVzSW5wdXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJhc2VSYXRlTWljcm9BbGdvcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5jcmVtZW50UGVyQmxvY2tNaWNyb0FsZ29zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJibG9ja1NpemUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVTZXJ2aWNlUHJpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VydmljZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdQcmljZU1pY3JvQWxnb3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVhY3RpdmF0ZVNlcnZpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VydmljZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZENvbXBsZXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VydmljZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzkxXSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gcmVjb3JkIGNvbXBsZXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHByb3ZpZGVyIGNhbiBkZWFjdGl2YXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBwcm92aWRlciBjYW4gdXBkYXRlIHByaWNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE1LDM1MSw0MDBdLCJlcnJvck1lc3NhZ2UiOiJTZXJ2aWNlIGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI0LDMzMSwzNjAsMzc0LDQwNSw0MTNdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxLDExN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDgsMTI0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNSwxNTQsMTYzLDE3MiwyOTYsMzA1LDM0MSwzODRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQTRJREFnTWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpYzJWeWRtbGpaWE1pSUNKdVpYaDBVMlZ5ZG1salpVbGtJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYMjFoY210bGRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdibVY0ZEZObGNuWnBZMlZKWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklERWdmU2s3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p1WlhoMFUyVnlkbWxqWlVsa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5dFlYSnJaWFJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJaMlZ1ZEUxaGNtdGxkRkpsWjJsemRISjVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFekNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaVpqWXpNR1EwWXlBd2VETXlNR0ZoTWpBeklEQjRPV1l5WkRsbE9UUWdNSGcyTXpKak5USmhaQ0F2THlCdFpYUm9iMlFnSW5KbFoybHpkR1Z5VTJWeWRtbGpaU2h6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkN4aWIyOXNMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxVMlZ5ZG1salpWQnlhV05sS0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVpHVmhZM1JwZG1GMFpWTmxjblpwWTJVb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsWTI5eVpFTnZiWEJzWlhScGIyNG9kV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCeVpXZHBjM1JsY2xObGNuWnBZMlVnZFhCa1lYUmxVMlZ5ZG1salpWQnlhV05sSUdSbFlXTjBhWFpoZEdWVFpYSjJhV05sSUhKbFkyOXlaRU52YlhCc1pYUnBiMjRLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmYldGeWEyVjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FXZGxiblJOWVhKclpYUlNaV2RwYzNSeWVTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYMjFoY210bGRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRV2RsYm5STllYSnJaWFJTWldkcGMzUnllUzV5WldkcGMzUmxjbE5sY25acFkyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldkcGMzUmxjbE5sY25acFkyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmYldGeWEyVjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4TFRJNUNpQWdJQ0F2THlCd2RXSnNhV01nY21WbmFYTjBaWEpUWlhKMmFXTmxLQW9nSUNBZ0x5OGdJQ0J1WVcxbE9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lHTmhkR1ZuYjNKNU9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lIQnlhV05sVFdsamNtOUJiR2R2Y3pvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCeVpYRjFhWEpsYzBsdWNIVjBPaUJpYjI5c1pXRnVMQW9nSUNBZ0x5OGdJQ0JpWVhObFVtRjBaVTFwWTNKdlFXeG5iM002SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnYVc1amNtVnRaVzUwVUdWeVFteHZZMnROYVdOeWIwRnNaMjl6T2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUdKc2IyTnJVMmw2WlRvZ2RXbHVkRFkwQ2lBZ0lDQXZMeUFwT2lCMWFXNTBOalFnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTndvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYMjFoY210bGRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdZMjl1YzNRZ2FXUWdQU0IwYUdsekxtNWxlSFJUWlhKMmFXTmxTV1F1ZG1Gc2RXVTdDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYMjFoY210bGRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdibVY0ZEZObGNuWnBZMlZKWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklERWdmU2s3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p1WlhoMFUyVnlkbWxqWlVsa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYMjFoY210bGRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdZMjl1YzNRZ2FXUWdQU0IwYUdsekxtNWxlSFJUWlhKMmFXTmxTV1F1ZG1Gc2RXVTdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYMjFoY210bGRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdkR2hwY3k1dVpYaDBVMlZ5ZG1salpVbGtMblpoYkhWbElEMGdhV1FnS3lBeE93b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDIxaGNtdGxkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnYm1WNGRGTmxjblpwWTJWSlpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJREVnZlNrN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKdVpYaDBVMlZ5ZG1salpVbGtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDIxaGNtdGxkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnZEdocGN5NXVaWGgwVTJWeWRtbGpaVWxrTG5aaGJIVmxJRDBnYVdRZ0t5QXhPd29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5dFlYSnJaWFJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRJS0lDQWdJQzh2SUhCeWIzWnBaR1Z5UVdSa2NtVnpjem9nVkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5dFlYSnJaWFJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpNdE5EVUtJQ0FnSUM4dklHTnZibk4wSUhKbFkyOXlaRG9nVTJWeWRtbGpaVkpsWTI5eVpDQTlJSHNLSUNBZ0lDOHZJQ0FnYzJWeWRtbGpaVWxrT2lCcFpDd0tJQ0FnSUM4dklDQWdibUZ0WlRvZ2JtRnRaU3dLSUNBZ0lDOHZJQ0FnWTJGMFpXZHZjbms2SUdOaGRHVm5iM0o1TEFvZ0lDQWdMeThnSUNCd2NtbGpaVTFwWTNKdlFXeG5iM002SUhCeWFXTmxUV2xqY205QmJHZHZjeXdLSUNBZ0lDOHZJQ0FnY21WeGRXbHlaWE5KYm5CMWREb2djbVZ4ZFdseVpYTkpibkIxZEN3S0lDQWdJQzh2SUNBZ1ltRnpaVkpoZEdWTmFXTnliMEZzWjI5ek9pQmlZWE5sVW1GMFpVMXBZM0p2UVd4bmIzTXNDaUFnSUNBdkx5QWdJR2x1WTNKbGJXVnVkRkJsY2tKc2IyTnJUV2xqY205QmJHZHZjem9nYVc1amNtVnRaVzUwVUdWeVFteHZZMnROYVdOeWIwRnNaMjl6TEFvZ0lDQWdMeThnSUNCaWJHOWphMU5wZW1VNklHSnNiMk5yVTJsNlpTd0tJQ0FnSUM4dklDQWdjSEp2ZG1sa1pYSkJaR1J5WlhOek9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0JqYjIxd2JHVjBaV1JLYjJKek9pQXdMQW9nSUNBZ0x5OGdJQ0JoWTNScGRtVTZJSFJ5ZFdVS0lDQWdJQzh2SUgwN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ09Bb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURVMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0RZS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01UQUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgyMWhjbXRsZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME13b2dJQ0FnTHk4Z1kyOXRjR3hsZEdWa1NtOWljem9nTUN3S0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmJXRnlhMlYwWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNekxUUTFDaUFnSUNBdkx5QmpiMjV6ZENCeVpXTnZjbVE2SUZObGNuWnBZMlZTWldOdmNtUWdQU0I3Q2lBZ0lDQXZMeUFnSUhObGNuWnBZMlZKWkRvZ2FXUXNDaUFnSUNBdkx5QWdJRzVoYldVNklHNWhiV1VzQ2lBZ0lDQXZMeUFnSUdOaGRHVm5iM0o1T2lCallYUmxaMjl5ZVN3S0lDQWdJQzh2SUNBZ2NISnBZMlZOYVdOeWIwRnNaMjl6T2lCd2NtbGpaVTFwWTNKdlFXeG5iM01zQ2lBZ0lDQXZMeUFnSUhKbGNYVnBjbVZ6U1c1d2RYUTZJSEpsY1hWcGNtVnpTVzV3ZFhRc0NpQWdJQ0F2THlBZ0lHSmhjMlZTWVhSbFRXbGpjbTlCYkdkdmN6b2dZbUZ6WlZKaGRHVk5hV055YjBGc1oyOXpMQW9nSUNBZ0x5OGdJQ0JwYm1OeVpXMWxiblJRWlhKQ2JHOWphMDFwWTNKdlFXeG5iM002SUdsdVkzSmxiV1Z1ZEZCbGNrSnNiMk5yVFdsamNtOUJiR2R2Y3l3S0lDQWdJQzh2SUNBZ1lteHZZMnRUYVhwbE9pQmliRzlqYTFOcGVtVXNDaUFnSUNBdkx5QWdJSEJ5YjNacFpHVnlRV1JrY21WemN6b2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnWTI5dGNHeGxkR1ZrU205aWN6b2dNQ3dLSUNBZ0lDOHZJQ0FnWVdOMGFYWmxPaUIwY25WbENpQWdJQ0F2THlCOU93b2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzRNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmJXRnlhMlYwWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCelpYSjJhV05sY3lBOUlFSnZlRTFoY0R4MWFXNTBOalFzSUZObGNuWnBZMlZTWldOdmNtUStLSHNnYTJWNVVISmxabWw0T2lBbmMyVnlkbWxqWlhNbklIMHBPd29nSUNBZ1lubDBaV05mTUNBdkx5QWljMlZ5ZG1salpYTWlDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmJXRnlhMlYwWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRM0NpQWdJQ0F2THlCMGFHbHpMbk5sY25acFkyVnpLR2xrS1M1MllXeDFaU0E5SUdOc2IyNWxLSEpsWTI5eVpDazdDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgyMWhjbXRsZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1TMHlPUW9nSUNBZ0x5OGdjSFZpYkdsaklISmxaMmx6ZEdWeVUyVnlkbWxqWlNnS0lDQWdJQzh2SUNBZ2JtRnRaVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0JqWVhSbFoyOXllVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0J3Y21salpVMXBZM0p2UVd4bmIzTTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdjbVZ4ZFdseVpYTkpibkIxZERvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ1ltRnpaVkpoZEdWTmFXTnliMEZzWjI5ek9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHbHVZM0psYldWdWRGQmxja0pzYjJOclRXbGpjbTlCYkdkdmN6b2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQmliRzlqYTFOcGVtVTZJSFZwYm5RMk5Bb2dJQ0FnTHk4Z0tUb2dkV2x1ZERZMElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXRZWEpyWlhSZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rRm5aVzUwVFdGeWEyVjBVbVZuYVhOMGNua3VkWEJrWVhSbFUyVnlkbWxqWlZCeWFXTmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxVMlZ5ZG1salpWQnlhV05sT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgyMWhjbXRsZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhWd1pHRjBaVk5sY25acFkyVlFjbWxqWlNoelpYSjJhV05sU1dRNklIVnBiblEyTkN3Z2JtVjNVSEpwWTJWTmFXTnliMEZzWjI5ek9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5dFlYSnJaWFJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuTmxjblpwWTJWektITmxjblpwWTJWSlpDa3VaWGhwYzNSekxDQW5VMlZ5ZG1salpTQmtiMlZ6SUc1dmRDQmxlR2x6ZENjcE93b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYMjFoY210bGRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPUW9nSUNBZ0x5OGdjMlZ5ZG1salpYTWdQU0JDYjNoTllYQThkV2x1ZERZMExDQlRaWEoyYVdObFVtVmpiM0prUGloN0lHdGxlVkJ5WldacGVEb2dKM05sY25acFkyVnpKeUI5S1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5ObGNuWnBZMlZ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZiV0Z5YTJWMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTV6WlhKMmFXTmxjeWh6WlhKMmFXTmxTV1FwTG1WNGFYTjBjeXdnSjFObGNuWnBZMlVnWkc5bGN5QnViM1FnWlhocGMzUW5LVHNLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVTJWeWRtbGpaU0JrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYMjFoY210bGRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOQW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUhKbFkyOXlaQzV3Y205MmFXUmxja0ZrWkhKbGMzTXNJQ2RQYm14NUlIQnliM1pwWkdWeUlHTmhiaUIxY0dSaGRHVWdjSEpwWTJVbktUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXRZWEpyWlhSZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UTXROVFFLSUNBZ0lDOHZJR052Ym5OMElISmxZMjl5WkNBOUlHTnNiMjVsS0hSb2FYTXVjMlZ5ZG1salpYTW9jMlZ5ZG1salpVbGtLUzUyWVd4MVpTazdDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnY21WamIzSmtMbkJ5YjNacFpHVnlRV1JrY21WemN5d2dKMDl1YkhrZ2NISnZkbWxrWlhJZ1kyRnVJSFZ3WkdGMFpTQndjbWxqWlNjcE93b2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblJ6SURRMUlETXlDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgyMWhjbXRsZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSEpsWTI5eVpDNXdjbTkyYVdSbGNrRmtaSEpsYzNNc0lDZFBibXg1SUhCeWIzWnBaR1Z5SUdOaGJpQjFjR1JoZEdVZ2NISnBZMlVuS1RzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCd2NtOTJhV1JsY2lCallXNGdkWEJrWVhSbElIQnlhV05sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmJXRnlhMlYwWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMkxUVTNDaUFnSUNBdkx5QnlaV052Y21RdWNISnBZMlZOYVdOeWIwRnNaMjl6SUQwZ2JtVjNVSEpwWTJWTmFXTnliMEZzWjI5ek93b2dJQ0FnTHk4Z2RHaHBjeTV6WlhKMmFXTmxjeWh6WlhKMmFXTmxTV1FwTG5aaGJIVmxJRDBnWTJ4dmJtVW9jbVZqYjNKa0tUc0tJQ0FnSUhCMWMyaHBiblFnTVRJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0psY0d4aFkyVWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXRZWEpyWlhSZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklIQjFZbXhwWXlCMWNHUmhkR1ZUWlhKMmFXTmxVSEpwWTJVb2MyVnlkbWxqWlVsa09pQjFhVzUwTmpRc0lHNWxkMUJ5YVdObFRXbGpjbTlCYkdkdmN6b2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgyMWhjbXRsZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFXZGxiblJOWVhKclpYUlNaV2RwYzNSeWVTNWtaV0ZqZEdsMllYUmxVMlZ5ZG1salpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsWVdOMGFYWmhkR1ZUWlhKMmFXTmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDIxaGNtdGxkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnY0hWaWJHbGpJR1JsWVdOMGFYWmhkR1ZUWlhKMmFXTmxLSE5sY25acFkyVkpaRG9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmJXRnlhMlYwWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXpaWEoyYVdObGN5aHpaWEoyYVdObFNXUXBMbVY0YVhOMGN5d2dKMU5sY25acFkyVWdaRzlsY3lCdWIzUWdaWGhwYzNRbktUc0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl0WVhKclpYUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJSE5sY25acFkyVnpJRDBnUW05NFRXRndQSFZwYm5RMk5Dd2dVMlZ5ZG1salpWSmxZMjl5WkQ0b2V5QnJaWGxRY21WbWFYZzZJQ2R6WlhKMmFXTmxjeWNnZlNrN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKelpYSjJhV05sY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYMjFoY210bGRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YzJWeWRtbGpaWE1vYzJWeWRtbGpaVWxrS1M1bGVHbHpkSE1zSUNkVFpYSjJhV05sSUdSdlpYTWdibTkwSUdWNGFYTjBKeWs3Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUZObGNuWnBZMlVnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl0WVhKclpYUmZZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCeVpXTnZjbVF1Y0hKdmRtbGtaWEpCWkdSeVpYTnpMQ0FuVDI1c2VTQndjbTkyYVdSbGNpQmpZVzRnWkdWaFkzUnBkbUYwWlNjcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgyMWhjbXRsZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1pMDJNd29nSUNBZ0x5OGdZMjl1YzNRZ2NtVmpiM0prSUQwZ1kyeHZibVVvZEdocGN5NXpaWEoyYVdObGN5aHpaWEoyYVdObFNXUXBMblpoYkhWbEtUc0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0J5WldOdmNtUXVjSEp2ZG1sa1pYSkJaR1J5WlhOekxDQW5UMjVzZVNCd2NtOTJhV1JsY2lCallXNGdaR1ZoWTNScGRtRjBaU2NwT3dvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUnpJRFExSURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDIxaGNtdGxkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTXdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlISmxZMjl5WkM1d2NtOTJhV1JsY2tGa1pISmxjM01zSUNkUGJteDVJSEJ5YjNacFpHVnlJR05oYmlCa1pXRmpkR2wyWVhSbEp5azdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2djSEp2ZG1sa1pYSWdZMkZ1SUdSbFlXTjBhWFpoZEdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXRZWEpyWlhSZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qVXROallLSUNBZ0lDOHZJSEpsWTI5eVpDNWhZM1JwZG1VZ1BTQm1ZV3h6WlRzS0lDQWdJQzh2SUhSb2FYTXVjMlZ5ZG1salpYTW9jMlZ5ZG1salpVbGtLUzUyWVd4MVpTQTlJR05zYjI1bEtISmxZMjl5WkNrN0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdPRFVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXRZWEpyWlhSZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qVUtJQ0FnSUM4dklISmxZMjl5WkM1aFkzUnBkbVVnUFNCbVlXeHpaVHNLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDIxaGNtdGxkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTlMwMk5nb2dJQ0FnTHk4Z2NtVmpiM0prTG1GamRHbDJaU0E5SUdaaGJITmxPd29nSUNBZ0x5OGdkR2hwY3k1elpYSjJhV05sY3loelpYSjJhV05sU1dRcExuWmhiSFZsSUQwZ1kyeHZibVVvY21WamIzSmtLVHNLSUNBZ0lITmxkR0pwZEFvZ0lDQWdjSFZ6YUdsdWRDQTROUW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0psY0d4aFkyVWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXRZWEpyWlhSZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklIQjFZbXhwWXlCa1pXRmpkR2wyWVhSbFUyVnlkbWxqWlNoelpYSjJhV05sU1dRNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5dFlYSnJaWFJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tGblpXNTBUV0Z5YTJWMFVtVm5hWE4wY25rdWNtVmpiM0prUTI5dGNHeGxkR2x2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxZMjl5WkVOdmJYQnNaWFJwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZiV0Z5YTJWMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTVDaUFnSUNBdkx5QndkV0pzYVdNZ2NtVmpiM0prUTI5dGNHeGxkR2x2YmloelpYSjJhV05sU1dRNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYMjFoY210bGRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNQW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUVkc2IySmhiQzVqY21WaGRHOXlRV1JrY21WemN5d2dKMDl1YkhrZ1lXUnRhVzRnWTJGdUlISmxZMjl5WkNCamIyMXdiR1YwYVc5dUp5azdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCaFpHMXBiaUJqWVc0Z2NtVmpiM0prSUdOdmJYQnNaWFJwYjI0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXRZWEpyWlhSZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56RUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbk5sY25acFkyVnpLSE5sY25acFkyVkpaQ2t1WlhocGMzUnpMQ0FuVTJWeWRtbGpaU0JrYjJWeklHNXZkQ0JsZUdsemRDY3BPd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDIxaGNtdGxkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnYzJWeWRtbGpaWE1nUFNCQ2IzaE5ZWEE4ZFdsdWREWTBMQ0JUWlhKMmFXTmxVbVZqYjNKa1BpaDdJR3RsZVZCeVpXWnBlRG9nSjNObGNuWnBZMlZ6SnlCOUtUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTmxjblpwWTJWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmYldGeWEyVjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN4Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1elpYSjJhV05sY3loelpYSjJhV05sU1dRcExtVjRhWE4wY3l3Z0oxTmxjblpwWTJVZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FuS1RzS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1UyVnlkbWxqWlNCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDIxaGNtdGxkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTXkwM05Bb2dJQ0FnTHk4Z1kyOXVjM1FnY21WamIzSmtJRDBnWTJ4dmJtVW9kR2hwY3k1elpYSjJhV05sY3loelpYSjJhV05sU1dRcExuWmhiSFZsS1RzS0lDQWdJQzh2SUhKbFkyOXlaQzVqYjIxd2JHVjBaV1JLYjJKeklEMGdjbVZqYjNKa0xtTnZiWEJzWlhSbFpFcHZZbk1nS3lBeE93b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRGMzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXRZWEpyWlhSZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56UUtJQ0FnSUM4dklISmxZMjl5WkM1amIyMXdiR1YwWldSS2IySnpJRDBnY21WamIzSmtMbU52YlhCc1pYUmxaRXB2WW5NZ0t5QXhPd29nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXRZWEpyWlhSZlkyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56UXROelVLSUNBZ0lDOHZJSEpsWTI5eVpDNWpiMjF3YkdWMFpXUktiMkp6SUQwZ2NtVmpiM0prTG1OdmJYQnNaWFJsWkVwdlluTWdLeUF4T3dvZ0lDQWdMeThnZEdocGN5NXpaWEoyYVdObGN5aHpaWEoyYVdObFNXUXBMblpoYkhWbElEMGdZMnh2Ym1Vb2NtVmpiM0prS1RzS0lDQWdJSEIxYzJocGJuUWdOemNLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl5WlhCc1lXTmxJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZiV0Z5YTJWMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTVDaUFnSUNBdkx5QndkV0pzYVdNZ2NtVmpiM0prUTI5dGNHeGxkR2x2YmloelpYSjJhV05sU1dRNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUWdBQWlZQ0NITmxjblpwWTJWekRXNWxlSFJUWlhKMmFXTmxTV1F4R0VBQUF5a2laekViUVFBck1Sa1VSREVZUklJRUJMOWpEVXdFTWdxaUF3U2ZMWjZVQkdNc1VxMDJHZ0NPQkFBSkFNb0E5d0VpQURFWkZERVlGQkJETmhvQlNTUlpKUWhMQVJVU1JGY0NBRFlhQWtra1dTVUlTd0VWRWtSWEFnQTJHZ05KRlNNU1JCYzJHZ1JKRlNJU1JDUlROaG9GU1JVakVrUVhOaG9HU1JVakVrUVhOaG9IU1JVakVrUVhKQ2xsUkVraUNDbE1aekVBVEJaTENCVVdWd1lDVHdsUVN3R0FBZ0JXVUVzQkZZRldDRXNLRlJaWEJnSlBDMUJNRmxjR0FrOENURkJQQ1JaUWdBRUFKRThLVkZCUEJ4WlFUd1lXVUU4RkZsQlBCRkFrRmxDQUFZQlFUd0pRVEZBb1N3SlFTYnhJVEwrQUJCVWZmSFZNVUxBaVF6WWFBVWtWSXhKRUZ6WWFBa2tWSXhKRVRCWW9URkJKdlVVQlJERUFTd0dEQWkwZ3VoSkVnUXhQQXJzaVF6WWFBVWtWSXhKRUZ4WW9URkJKdlVVQlJERUFTd0dEQWkwZ3VoSkVTWUZWSXJva1NWU0JWVXk3SWtNMkdnRkpGU01TUkJjeEFESUpFa1FXS0V4UVNiMUZBVVJKZ1UwanVoY2lDQmFCVFV5N0lrTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
