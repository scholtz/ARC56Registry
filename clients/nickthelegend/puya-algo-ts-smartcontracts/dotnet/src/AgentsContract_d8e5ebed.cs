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

namespace Arc56.Generated.nickthelegend.puya_algo_ts_smartcontracts.AgentsContract_d8e5ebed
{


    public class AgentsContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgentsContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Agent : AVMObjectType
            {
                public string Name { get; set; }

                public string Details { get; set; }

                public ulong FixedPricing { get; set; }

                public ulong CreatedAt { get; set; }

                public ulong AppId { get; set; }

                public string CreatorName { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDetails = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDetails.From(Details);
                    stringRef[ret.Count] = vDetails.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFixedPricing = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFixedPricing.From(FixedPricing);
                    ret.AddRange(vFixedPricing.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAppId.From(AppId);
                    ret.AddRange(vAppId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatorName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCreatorName.From(CreatorName);
                    stringRef[ret.Count] = vCreatorName.Encode();
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

                public static Agent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Agent();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexDetails = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDetails = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDetails.Decode(bytes.Skip(indexDetails + prefixOffset).ToArray());
                    var valueDetails = vDetails.ToValue();
                    if (valueDetails is string vDetailsValue) { ret.Details = vDetailsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFixedPricing = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFixedPricing.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFixedPricing = vFixedPricing.ToValue();
                    if (valueFixedPricing is ulong vFixedPricingValue) { ret.FixedPricing = vFixedPricingValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAppId = vAppId.ToValue();
                    if (valueAppId is ulong vAppIdValue) { ret.AppId = vAppIdValue; }
                    var indexCreatorName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatorName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCreatorName.Decode(bytes.Skip(indexCreatorName + prefixOffset).ToArray());
                    var valueCreatorName = vCreatorName.ToValue();
                    if (valueCreatorName is string vCreatorNameValue) { ret.CreatorName = vCreatorNameValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Agent);
                }
                public bool Equals(Agent? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Agent left, Agent right)
                {
                    return EqualityComparer<Agent>.Default.Equals(left, right);
                }
                public static bool operator !=(Agent left, Agent right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="maintainerAddress"> </param>
        public async Task CreateApplication(Address maintainerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { maintainerAddress });
            byte maintainerAddressRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 218, 83, 254, 254 };
            var maintainerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); maintainerAddressAbi.From(maintainerAddress);

            var result = await base.CallApp(new List<object> { abiHandle, maintainerAddressRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Address maintainerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { maintainerAddress });
            byte maintainerAddressRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 218, 83, 254, 254 };
            var maintainerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); maintainerAddressAbi.From(maintainerAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, maintainerAddressRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentName"> </param>
        /// <param name="agentIPFS"> </param>
        /// <param name="pricing"> </param>
        /// <param name="agentImage"> </param>
        public async Task<ulong> CreateAgent(string agentName, string agentIPFS, ulong pricing, string agentImage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 147, 94, 13 };
            var agentNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agentNameAbi.From(agentName);
            var agentIPFSAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agentIPFSAbi.From(agentIPFS);
            var pricingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricingAbi.From(pricing);
            var agentImageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agentImageAbi.From(agentImage);

            var result = await base.CallApp(new List<object> { abiHandle, agentNameAbi, agentIPFSAbi, pricingAbi, agentImageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateAgent_Transactions(string agentName, string agentIPFS, ulong pricing, string agentImage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 147, 94, 13 };
            var agentNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agentNameAbi.From(agentName);
            var agentIPFSAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agentIPFSAbi.From(agentIPFS);
            var pricingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricingAbi.From(pricing);
            var agentImageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agentImageAbi.From(agentImage);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentNameAbi, agentIPFSAbi, pricingAbi, agentImageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        public async Task DeleteAgent(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 158, 97, 150 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            var result = await base.CallApp(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteAgent_Transactions(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 158, 97, 150 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdlbnRzQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQWdlbnQiOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImRldGFpbHMiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZml4ZWRQcmljaW5nIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNyZWF0ZWRBdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhcHBJRCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjcmVhdG9yTmFtZSIsInR5cGUiOiJzdHJpbmcifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1haW50YWluZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZUFnZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50TmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRJUEZTIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljaW5nIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudEltYWdlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlQWdlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEwODhdLCJlcnJvck1lc3NhZ2UiOiJBZ2VudCBkb2VzIG5vdCBleGlzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzLDY5LDEwM10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwODBdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHRoZSBtYWludGFpbmVyIGNhbiBkZWxldGUgYWdlbnRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA3OF0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwN10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2LDcyXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk5NywxMDA3LDEwOTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRFlLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbTUxYldKbGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkSE11WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRm5aVzUwYzBOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBNUNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFpHRTFNMlpsWm1VZ01IaGtNRGt6TldVd1pDQXdlR015T1dVMk1UazJJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvWVdOamIzVnVkQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmpjbVZoZEdWQloyVnVkQ2h6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkN4emRISnBibWNwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0prWld4bGRHVkJaMlZ1ZENoMWFXNTBOalFwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI1ZmNtOTFkR1ZBTXlCdFlXbHVYMk55WldGMFpVRm5aVzUwWDNKdmRYUmxRRFFnYldGcGJsOWtaV3hsZEdWQloyVnVkRjl5YjNWMFpVQTFDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRITXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGblpXNTBjME52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWtaV3hsZEdWQloyVnVkRjl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwY3k1aGJHZHZMblJ6T2preUNpQWdJQ0F2THlCa1pXeGxkR1ZCWjJWdWRDaGhaMlZ1ZEVsa09pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MGN5NWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVdkbGJuUnpRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblJ6TG1Gc1oyOHVkSE02T1RJS0lDQWdJQzh2SUdSbGJHVjBaVUZuWlc1MEtHRm5aVzUwU1dRNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdZMkZzYkhOMVlpQmtaV3hsZEdWQloyVnVkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWQloyVnVkRjl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwY3k1aGJHZHZMblJ6T2pRM0NpQWdJQ0F2THlCamNtVmhkR1ZCWjJWdWRDaGhaMlZ1ZEU1aGJXVTZJRk4wY2l3Z1lXZGxiblJKVUVaVE9pQlRkSElzSUhCeWFXTnBibWM2SUdGeVl6UXVWV2x1ZEU0Mk5Dd2dZV2RsYm5SSmJXRm5aVG9nVTNSeUtUb2dkV2x1ZERZMGV3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UVdkbGJuUnpMbUZzWjI4dWRITTZNamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQloyVnVkSE5EYjI1MGNtRmpkQ0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEhNdVlXeG5ieTUwY3pvME53b2dJQ0FnTHk4Z1kzSmxZWFJsUVdkbGJuUW9ZV2RsYm5ST1lXMWxPaUJUZEhJc0lHRm5aVzUwU1ZCR1V6b2dVM1J5TENCd2NtbGphVzVuT2lCaGNtTTBMbFZwYm5ST05qUXNJR0ZuWlc1MFNXMWhaMlU2SUZOMGNpazZJSFZwYm5RMk5Ic0tJQ0FnSUdOaGJHeHpkV0lnWTNKbFlYUmxRV2RsYm5RS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVkJjSEJzYVdOaGRHbHZibDl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwY3k1aGJHZHZMblJ6T2pRd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblJ6TG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJaMlZ1ZEhORGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRmpZMjkxYm5SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UVdkbGJuUnpMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRITXVZV3huYnk1MGN6bzZRV2RsYm5SelEyOXVkSEpoWTNRdVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b2JXRnBiblJoYVc1bGNrRmtaSEpsYzNNNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRITXVZV3huYnk1MGN6bzBNQzAwTVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmlodFlXbHVkR0ZwYm1WeVFXUmtjbVZ6Y3pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblJ6TG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUcxaGFXNTBZV2x1WlhKQlpHUnlaWE56SUQwZ0lFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2s3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbTFoYVc1MFlXbHVaWEpCWkdSeVpYTnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwY3k1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCMGFHbHpMbTFoYVc1MFlXbHVaWEpCWkdSeVpYTnpMblpoYkhWbElEMGdiV0ZwYm5SaGFXNWxja0ZrWkhKbGMzTTdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblJ6TG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUc1MWJXSmxjaUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltNTFiV0psY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRITXVZV3huYnk1MGN6bzBOQW9nSUNBZ0x5OGdkR2hwY3k1dWRXMWlaWEl1ZG1Gc2RXVWdQU0F3T3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5SekxtRnNaMjh1ZEhNNk9rRm5aVzUwYzBOdmJuUnlZV04wTG1OeVpXRjBaVUZuWlc1MEtHRm5aVzUwVG1GdFpUb2dZbmwwWlhNc0lHRm5aVzUwU1ZCR1V6b2dZbmwwWlhNc0lIQnlhV05wYm1jNklHSjVkR1Z6TENCaFoyVnVkRWx0WVdkbE9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncGpjbVZoZEdWQloyVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEhNdVlXeG5ieTUwY3pvME53b2dJQ0FnTHk4Z1kzSmxZWFJsUVdkbGJuUW9ZV2RsYm5ST1lXMWxPaUJUZEhJc0lHRm5aVzUwU1ZCR1V6b2dVM1J5TENCd2NtbGphVzVuT2lCaGNtTTBMbFZwYm5ST05qUXNJR0ZuWlc1MFNXMWhaMlU2SUZOMGNpazZJSFZwYm5RMk5Ic0tJQ0FnSUhCeWIzUnZJRFFnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MGN5NWhiR2R2TG5Sek9qVTNMVFkzQ2lBZ0lDQXZMeUJqYjI1emRDQm9aV3hzYjBGd2NDQTlJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRndjR3hwWTJGMGFXOXVRMkZzYkNoN0NpQWdJQ0F2THlBZ0lDQWdZWEJ3UVhKbmN6b2dXMjFsZEdodlpGTmxiR1ZqZEc5eUtGTnBibWRzWlVGblpXNTBRMjl1ZEhKaFkzUXVjSEp2ZEc5MGVYQmxMbU55WldGMFpVRndjR3hwWTJGMGFXOXVLU3hoWjJWdWRFNWhiV1VzWVdkbGJuUkpVRVpUTENCd2NtbGphVzVuSUYwc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3Y205MllXeFFjbTluY21GdE9pQmpiMjF3YVd4bFpDNWhjSEJ5YjNaaGJGQnliMmR5WVcwc0NpQWdJQ0F2THlBZ0lDQWdZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMDZJR052YlhCcGJHVmtMbU5zWldGeVUzUmhkR1ZRY205bmNtRnRMQW9nSUNBZ0x5OGdJQ0FnSUdkc2IySmhiRTUxYlVKNWRHVnpPaUJqYjIxd2FXeGxaQzVuYkc5aVlXeENlWFJsY3l3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnTHk4Z0lDQmhZMk52ZFc1MGN6b2dXeUIxYzJWeVFXUmtjbVZ6Y3lCZExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBZ0lDQm5iRzlpWVd4T2RXMVZhVzUwT2lBMkxDQXZMeUE4TFMwZ1FXeHNiM2NnTVNCMWFXNTBJR2x1SUdkc2IySmhiQ0J6ZEdGMFpTd0tJQ0FnSUM4dklBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2t1WTNKbFlYUmxaRUZ3Y0FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwY3k1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCbmJHOWlZV3hPZFcxVmFXNTBPaUEyTENBdkx5QThMUzBnUVd4c2IzY2dNU0IxYVc1MElHbHVJR2RzYjJKaGJDQnpkR0YwWlN3S0lDQWdJR2x1ZEdOZk1pQXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRWRzYjJKaGJFNTFiVlZwYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRITXVZV3huYnk1MGN6bzFOQW9nSUNBZ0x5OGdZMjl1YzNRZ1kyOXRjR2xzWldRZ1BTQmpiMjF3YVd4bEtGTnBibWRzWlVGblpXNTBRMjl1ZEhKaFkzUXBDaUFnSUNCd2RYTm9hVzUwSURNZ0x5OGdNd29nSUNBZ2FYUjRibDltYVdWc1pDQkhiRzlpWVd4T2RXMUNlWFJsVTJ4cFkyVUtJQ0FnSUhCMWMyaGllWFJsY3lCaVlYTmxOalFvUTI5RlFsRjNQVDBwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRVR0ZuWlhNS0lDQWdJSEIxYzJoaWVYUmxjeUJpWVhObE5qUW9RMmxCUlVGQlNHRjBObkpzUVdkWmJVSjNlSFprTWpWc1kydEdhMXBJU214ak0wMUtaRWRHZW1Fd1RuWmtWelV3UWs1cFpIVnJhMFZpYlVaMFdsRjRiV0ZZYUd4YVJrSjVZVmRPY0dKdFkwTkJSRTFLUVVGa2VtUlhUbXBhV0U1NlRWSjBRa0ZFYVVOQ2QxUkJVek5ZTUVKT1dGUkpNR05GWVRKblJFZEJWRVpTYWpkeFFrODBlbXRUT0VVNE4zRnBZMEZVYTJNNFkwdE9hRzlCYW1kalFXVm5RblZCUm1kQlRtZEJaMEZCTkVGQmFVcEVUVkpyVlZKRVJWbFNTV2REVEVOT1JFMVNhMVZTUkVWWlVrUlpZVUZTWmtGSVNXZERRMmxPUkUxU2ExVlNSRVZaVWtSWllVRlNaa0ZJUkZsaFFXaGxTVUZpVldwUmVrVmFSa1ZSZUVkRlVUSkhaMFZZVG1odlEwNW9iMFJPYUc5RlRtaHZSazVvYjBkT2FHOUlhVUZGYlVrd1RYaEhVbEpGVFZKb1JVMVNXV3BEVldzMFJVTk5VMUpKWjBGcmVVNUVUVkpyVlZKRVJWbFNTV2RCVlhsT1JFMVNhMVZTUkVWWlJrVlJNa2RuUmxoQlowRXlSMmRLV0VGblFUSkhaMDFZYVVGQlEwa3dUMHRCZDBGdlRWRkNia3MwZGpsYU5FRklXa2RXTUZsWGJITmpOSFlyV2pSMkwyZGpRMFZRVVhOdVFrVjRibWRCYkdwamJWWm9aRWRXYTFGWVVYbENNbU53U1RKbFNuTlRTWEphVlZONVNtOUJRMVZzUTNsS1dVVkRjMmxQUW1kT1JHSjNMMUZEYzJsTFFrRTNTVkZKY2tsQ2N6UkJUVmxYWkd4aWJsSkNZek5PYkdSRmJFVjBSSGh1YVZsdlFrRkpkaTlQUVdONVEyaEtSV2t2T0RSRFEwbHVRa2RXUlVWclVXbExWMVpGVTFKWmVVSjRZVXd2ZW1kQlUzZExRVUZSUWxGVWQwcFJTbmRXVVZSR1EwRklaMEZqVlVkR05XSlhWblZrUTBKRllqSTFiRWxUUlhOSlJsSm9Zekp6WjFFelNteFpXRkpzV2taQ1RFRmllRWwyZVUxSlMxVjRibk5VU1VsR2FYRjVSMjlCUmtGQlRuZFpXRzE1UjNKSllVcDNZWGxIYVZONVIwTlhlVVZEUzNsQllrOUthV2RqUVVscmJVd3JVbHBLZG10UmVVSjRZVXdyYVVwVVVWRkNTR2t2TWsxQlNYWTNTV3hPUWtGRE1rd3ZiM2RDYVM5M2FWVXdSVUZIYjNZdmFYZEtTbWwzUWxGcGQxSlJTbmRXVVZSM1NsRnBkMFpSVTNkSE9GTk1LMHBwZDA1WVJYbENReThyUTB4Qk1HMUNSVlpzVEVGU1ZsTnFRVVpETHpocFRFRTBSa0ZWTkVGQ1FVTktVRUZzVTAxQlJVd3Zja2x2UTBGRVJVRkphV2hzVWtKS1JYTlpkaXR6WjJWTUx6ZEpTVWszU1ZGSmNrbENjemRGZVVOQ1dYRnphSEZCUTBoa2NHUkhhR3RqYlVZemMyaHhlVWRwWTBkemFHOXJjMmhuYkhOb1FXbHpaMGQ2YVZsdlFrRkVSVUZKYVdoc1VrSktSVXRKZGk5YU5HMTRUV2RuVjB0eVNXRm5RVTUzV1ZodGVVZHlTV0ZuUVdSNlpGZE9hbHBZVG5wemFHOXJjMmhuYkhOb1FXbHpaMGQ2YVZFOVBTa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndjbTkyWVd4UWNtOW5jbUZ0VUdGblpYTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkSE11WVd4bmJ5NTBjem8xT1FvZ0lDQWdMeThnWVhCd1FYSm5jem9nVzIxbGRHaHZaRk5sYkdWamRHOXlLRk5wYm1kc1pVRm5aVzUwUTI5dWRISmhZM1F1Y0hKdmRHOTBlWEJsTG1OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1S1N4aFoyVnVkRTVoYldVc1lXZGxiblJKVUVaVExDQndjbWxqYVc1bklGMHNDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGpNRFJpTnpWbU5DQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpVRndjR3hwWTJGMGFXOXVLSE4wY21sdVp5eHpkSEpwYm1jc2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MGN5NWhiR2R2TG5Sek9qVTNMVFkyQ2lBZ0lDQXZMeUJqYjI1emRDQm9aV3hzYjBGd2NDQTlJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRndjR3hwWTJGMGFXOXVRMkZzYkNoN0NpQWdJQ0F2THlBZ0lDQWdZWEJ3UVhKbmN6b2dXMjFsZEdodlpGTmxiR1ZqZEc5eUtGTnBibWRzWlVGblpXNTBRMjl1ZEhKaFkzUXVjSEp2ZEc5MGVYQmxMbU55WldGMFpVRndjR3hwWTJGMGFXOXVLU3hoWjJWdWRFNWhiV1VzWVdkbGJuUkpVRVpUTENCd2NtbGphVzVuSUYwc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3Y205MllXeFFjbTluY21GdE9pQmpiMjF3YVd4bFpDNWhjSEJ5YjNaaGJGQnliMmR5WVcwc0NpQWdJQ0F2THlBZ0lDQWdZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMDZJR052YlhCcGJHVmtMbU5zWldGeVUzUmhkR1ZRY205bmNtRnRMQW9nSUNBZ0x5OGdJQ0FnSUdkc2IySmhiRTUxYlVKNWRHVnpPaUJqYjIxd2FXeGxaQzVuYkc5aVlXeENlWFJsY3l3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnTHk4Z0lDQmhZMk52ZFc1MGN6b2dXeUIxYzJWeVFXUmtjbVZ6Y3lCZExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBZ0lDQm5iRzlpWVd4T2RXMVZhVzUwT2lBMkxDQXZMeUE4TFMwZ1FXeHNiM2NnTVNCMWFXNTBJR2x1SUdkc2IySmhiQ0J6ZEdGMFpTd0tJQ0FnSUM4dklBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2FXNTBZMTh5SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MGN5NWhiR2R2TG5Sek9qVTNMVFkzQ2lBZ0lDQXZMeUJqYjI1emRDQm9aV3hzYjBGd2NDQTlJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRndjR3hwWTJGMGFXOXVRMkZzYkNoN0NpQWdJQ0F2THlBZ0lDQWdZWEJ3UVhKbmN6b2dXMjFsZEdodlpGTmxiR1ZqZEc5eUtGTnBibWRzWlVGblpXNTBRMjl1ZEhKaFkzUXVjSEp2ZEc5MGVYQmxMbU55WldGMFpVRndjR3hwWTJGMGFXOXVLU3hoWjJWdWRFNWhiV1VzWVdkbGJuUkpVRVpUTENCd2NtbGphVzVuSUYwc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3Y205MllXeFFjbTluY21GdE9pQmpiMjF3YVd4bFpDNWhjSEJ5YjNaaGJGQnliMmR5WVcwc0NpQWdJQ0F2THlBZ0lDQWdZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMDZJR052YlhCcGJHVmtMbU5zWldGeVUzUmhkR1ZRY205bmNtRnRMQW9nSUNBZ0x5OGdJQ0FnSUdkc2IySmhiRTUxYlVKNWRHVnpPaUJqYjIxd2FXeGxaQzVuYkc5aVlXeENlWFJsY3l3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnTHk4Z0lDQmhZMk52ZFc1MGN6b2dXeUIxYzJWeVFXUmtjbVZ6Y3lCZExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBZ0lDQm5iRzlpWVd4T2RXMVZhVzUwT2lBMkxDQXZMeUE4TFMwZ1FXeHNiM2NnTVNCMWFXNTBJR2x1SUdkc2IySmhiQ0J6ZEdGMFpTd0tJQ0FnSUM4dklBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2t1WTNKbFlYUmxaRUZ3Y0FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEhNdVlXeG5ieTUwY3pvMk53b2dJQ0FnTHk4Z0xuTjFZbTFwZENncExtTnlaV0YwWldSQmNIQUtJQ0FnSUdsMGVHNGdRM0psWVhSbFpFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJaMlZ1ZEhNdVlXeG5ieTUwY3pvM01nb2dJQ0FnTHk4Z1kzSmxZWFJsWkVGME9pQnVaWGNnWVhKak5DNVZhVzUwVGpZMEtFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEFwTEFvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MGN5NWhiR2R2TG5Sek9qY3pDaUFnSUNBdkx5QmhjSEJKUkRvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNob1pXeHNiMEZ3Y0M1cFpDa2dMR055WldGMGIzSk9ZVzFsT2lCaFoyVnVkRWx0WVdkbENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBjeTVoYkdkdkxuUnpPalk0TFRjMENpQWdJQ0F2THlCMGFHbHpMbUZuWlc1MFRXRndLSFJvYVhNdWJuVnRZbVZ5TG5aaGJIVmxLUzUyWVd4MVpTQTlJRzVsZHlCQloyVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdibUZ0WlRvZ1lXZGxiblJPWVcxbExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUdSbGRHRnBiSE02SUdGblpXNTBTVkJHVXl3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0JtYVhobFpGQnlhV05wYm1jNklIQnlhV05wYm1jc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnWTNKbFlYUmxaRUYwT2lCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0Vkc2IySmhiQzVzWVhSbGMzUlVhVzFsYzNSaGJYQXBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQmhjSEJKUkRvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNob1pXeHNiMEZ3Y0M1cFpDa2dMR055WldGMGIzSk9ZVzFsT2lCaFoyVnVkRWx0WVdkbENpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNBZ0lDQWdJSDBwT3dvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016QWdMeThnTXpBS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNV1VLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MGN5NWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QnVkVzFpWlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWliblZ0WW1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRITXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdkR2hwY3k1aFoyVnVkRTFoY0NoMGFHbHpMbTUxYldKbGNpNTJZV3gxWlNrdWRtRnNkV1VnUFNCdVpYY2dRV2RsYm5Rb2V3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBjeTVoYkdkdkxuUnpPalk0TFRjMENpQWdJQ0F2THlCMGFHbHpMbUZuWlc1MFRXRndLSFJvYVhNdWJuVnRZbVZ5TG5aaGJIVmxLUzUyWVd4MVpTQTlJRzVsZHlCQloyVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdibUZ0WlRvZ1lXZGxiblJPWVcxbExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUdSbGRHRnBiSE02SUdGblpXNTBTVkJHVXl3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0JtYVhobFpGQnlhV05wYm1jNklIQnlhV05wYm1jc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnWTNKbFlYUmxaRUYwT2lCdVpYY2dZWEpqTkM1VmFXNTBUalkwS0Vkc2IySmhiQzVzWVhSbGMzUlVhVzFsYzNSaGJYQXBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQmhjSEJKUkRvZ2JtVjNJR0Z5WXpRdVZXbHVkRTQyTkNob1pXeHNiMEZ3Y0M1cFpDa2dMR055WldGMGIzSk9ZVzFsT2lCaFoyVnVkRWx0WVdkbENpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNBZ0lDQWdJSDBwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkSE11WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnYm5WdFltVnlJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW01MWJXSmxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblJ6TG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUhSb2FYTXViblZ0WW1WeUxuWmhiSFZsSUNzOU1Uc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5SekxtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklHNTFiV0psY2lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTUxYldKbGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkSE11WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnZEdocGN5NXVkVzFpWlhJdWRtRnNkV1VnS3oweE93b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkSE11WVd4bmJ5NTBjem8zT0MwNE5Bb2dJQ0FnTHk4Z1kyOXVjM1FnWTJGc2JGUjRiaUE5SUdsMGVHNEtJQ0FnSUM4dklDQWdJQ0FnSUM1aGNIQnNhV05oZEdsdmJrTmhiR3dvZXdvZ0lDQWdMeThnSUdGd2NFbGtPbUZ3Y0VsRUxBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdJQ0JoY0hCQmNtZHpPaUJiWVhKak5DNXRaWFJvYjJSVFpXeGxZM1J2Y2lnblpXMXBkRjlzYjJjb2MzUnlhVzVuTEhWcGJuUTJOQ3h6ZEhKcGJtY3BKeWtzSUNKamNtVmhkR1ZCWjJWdWRDSXNJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpaQzVwWkN3Z0luTjFZMk5sYzNNaUlGMHNDaUFnSUNBdkx5QWdJQ0FnSUNCOUtRb2dJQ0FnTHk4Z0lDQWdJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblJ6TG1Gc1oyOHVkSE02T0RJS0lDQWdJQzh2SUdGd2NFRnlaM002SUZ0aGNtTTBMbTFsZEdodlpGTmxiR1ZqZEc5eUtDZGxiV2wwWDJ4dlp5aHpkSEpwYm1jc2RXbHVkRFkwTEhOMGNtbHVaeWtuS1N3Z0ltTnlaV0YwWlVGblpXNTBJaXdnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xrTG1sa0xDQWljM1ZqWTJWemN5SWdYU3dLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlUVTNaakU0T1RJZ0x5OGdiV1YwYUc5a0lDSmxiV2wwWDJ4dlp5aHpkSEpwYm1jc2RXbHVkRFkwTEhOMGNtbHVaeWtpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHSjVkR1Z6SUNKamNtVmhkR1ZCWjJWdWRDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHSjVkR1Z6SUNKemRXTmpaWE56SWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QloyVnVkSE11WVd4bmJ5NTBjem8zTmdvZ0lDQWdMeThnWTI5dWMzUWdZWEJ3U1VRZ1BTQWdRWEJ3YkdsallYUnBiMjRvTnpRNU16YzROVEl5S1RzS0lDQWdJSEIxYzJocGJuUWdOelE1TXpjNE5USXlJQzh2SURjME9UTTNPRFV5TWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UVdkbGJuUnpMbUZzWjI4dWRITTZOemd0T0RNS0lDQWdJQzh2SUdOdmJuTjBJR05oYkd4VWVHNGdQU0JwZEhodUNpQWdJQ0F2THlBZ0lDQWdJQ0F1WVhCd2JHbGpZWFJwYjI1RFlXeHNLSHNLSUNBZ0lDOHZJQ0JoY0hCSlpEcGhjSEJKUkN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3UVhKbmN6b2dXMkZ5WXpRdWJXVjBhRzlrVTJWc1pXTjBiM0lvSjJWdGFYUmZiRzluS0hOMGNtbHVaeXgxYVc1ME5qUXNjM1J5YVc1bktTY3BMQ0FpWTNKbFlYUmxRV2RsYm5RaUxDQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVNXUXVhV1FzSUNKemRXTmpaWE56SWlCZExBb2dJQ0FnTHk4Z0lDQWdJQ0FnZlNrS0lDQWdJR2x1ZEdOZk1pQXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblJ6TG1Gc1oyOHVkSE02T0RFS0lDQWdJQzh2SUdabFpUb2dNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwY3k1aGJHZHZMblJ6T2pjNExUZzBDaUFnSUNBdkx5QmpiMjV6ZENCallXeHNWSGh1SUQwZ2FYUjRiZ29nSUNBZ0x5OGdJQ0FnSUNBZ0xtRndjR3hwWTJGMGFXOXVRMkZzYkNoN0NpQWdJQ0F2THlBZ1lYQndTV1E2WVhCd1NVUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0FnSUdGd2NFRnlaM002SUZ0aGNtTTBMbTFsZEdodlpGTmxiR1ZqZEc5eUtDZGxiV2wwWDJ4dlp5aHpkSEpwYm1jc2RXbHVkRFkwTEhOMGNtbHVaeWtuS1N3Z0ltTnlaV0YwWlVGblpXNTBJaXdnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xrTG1sa0xDQWljM1ZqWTJWemN5SWdYU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lIMHBDaUFnSUNBdkx5QWdJQ0FnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5SekxtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklISmxkSFZ5YmlCb1pXeHNiMEZ3Y0M1cFpBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGblpXNTBjeTVoYkdkdkxuUnpPanBCWjJWdWRITkRiMjUwY21GamRDNWtaV3hsZEdWQloyVnVkQ2hoWjJWdWRFbGtPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbVJsYkdWMFpVRm5aVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MGN5NWhiR2R2TG5Sek9qa3lDaUFnSUNBdkx5QmtaV3hsZEdWQloyVnVkQ2hoWjJWdWRFbGtPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MGN5NWhiR2R2TG5Sek9qa3pDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnVkhodUxtRndjR3hwWTJGMGFXOXVTV1F1WTNKbFlYUnZjaXdnSjA5dWJIa2dkR2hsSUcxaGFXNTBZV2x1WlhJZ1kyRnVJR1JsYkdWMFpTQmhaMlZ1ZEhNbktUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCRGNtVmhkRzl5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3YkdsallYUnBiMjRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dkR2hsSUcxaGFXNTBZV2x1WlhJZ1kyRnVJR1JsYkdWMFpTQmhaMlZ1ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRITXVZV3huYnk1MGN6bzVOQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WVdkbGJuUk5ZWEFvWVdkbGJuUkpaQ2t1WlhocGMzUnpMQ0FuUVdkbGJuUWdaRzlsY3lCdWIzUWdaWGhwYzNRbktUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaMlZ1ZENCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRm5aVzUwY3k1aGJHZHZMblJ6T2prNUNpQWdJQ0F2THlCMGFHbHpMbUZuWlc1MFRXRndLR0ZuWlc1MFNXUXBMbVJsYkdWMFpTZ3BPd29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRV2RsYm5SekxtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklHNTFiV0psY2lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnVkVzFpWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MGN5NWhiR2R2TG5Sek9qRXdNQW9nSUNBZ0x5OGdkR2hwY3k1dWRXMWlaWEl1ZG1Gc2RXVWdMVDBnTVRzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFXZGxiblJ6TG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUc1MWJXSmxjaUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltNTFiV0psY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCWjJWdWRITXVZV3huYnk1MGN6b3hNREFLSUNBZ0lDOHZJSFJvYVhNdWJuVnRZbVZ5TG5aaGJIVmxJQzA5SURFN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQUFFR0pnRUdiblZ0WW1WeU1SdEJBQnlDQXdUYVUvNytCTkNUWGcwRXdwNWhsallhQUk0REFEUUFFZ0FDSWtNeEdSUkVNUmhFTmhvQkY0Z0Q3U05ETVJrVVJERVlSRFlhQVRZYUFqWWFBellhQklnQVBCYUFCQlVmZkhWTVVMQWpRekVaRkVReEdCUkVOaG9CRjhBY2lBQUNJME9LQVFDQUVXMWhhVzUwWVdsdVpYSkJaR1J5WlhOemkvOW5LQ0puaVlvRUFiRWtzalNCQTdJMWdBUUtnUUZEc2tLQTR3VUtJQVFBQWRxM3F1VUNCaVlIREc5M2JtVnlRV1JrY21WemN3bDBZWE5yUTI5MWJuUUUySjI2U1FSdVlXMWxER1pwZUdWa1VISnBZMmx1WndJQU13a0FCM04xWTJObGMzTXhHMEVBT0lJSEJNQkxkZlFFMWRNalJ3UnJhQU1ZQk1WR1B1b0U3ak9STHdUenVxSndCT1J6eHdvMkdnQ09Cd0I2QUc0QVdBQTJBQ0FBRGdBQ0lrTXhHUlJFTVJoRWlBSXNJME14R1JSRU1SaEVOaG9CRjhBY2lBSUtJME14R1JSRU1SaEVOaG9CRjhBY05ob0NGNGdCdFNORE1Sa1VSREVZUkRZYUFSYzJHZ0kyR2dNMkdnUTJHZ1UyR2dZMkdnZUlBU1lqUXpFWkZFUXhHRVF4RmlNSlNUZ1FJeEpFaUFDVEkwTXhHUlJFTVJoRWlBQlRJME14R1JSRU1SZ1VSRFlhQVZjQ0FEWWFBbGNDQURZYUF4ZUlBQUlqUTRvREFDZ3hBR2NyaS8xbmdBZGtaWFJoYVd4emkvNW5pLytCd0lROUN5Y0VUR2VBQ1dOeVpXRjBaV1JCZERJSFp5a2paNG14SWl0bFJMSW1nQUpTVUxJbGdRS3lJNEdBME52RDlBS3lJb0VEc2hBaXNnR3pnQXhoWjJWdWRFRnpjMlYwU1VTMFBHZUppZ0VBaS84NEJ6SUtFa1NML3pnSUlpY0VaVVFTUkNJcFpVUkpGaklIRm92L09BQkxBb0FCQUZCUEFsQW5CVkJNVUlBZUFCeFFZWGx0Wlc1MElFUnZibVVoSVN3Z1ZHRnpheUJEY21WaGRHVmtVRXNCdkVpL0l3Z3BUR2V4TWdnV0tySWFnQVVBQTNCaGViSWFzaG9uQnJJYUpMSVlKYklRSXJJQnM0bUtCd0FpU1l2NUZrbStSRElIRm92NklsTkJBRWVML1l3QWkvc2lVMEVBTFl2K2pBR0wvQ0pUUVFBYWkvK0xBa21MQUZDTEJGQW5CVkJQQWxDTEFWQkxBYnhJdjRtTEExY1RJRUwvNElzRFNZRVJXVXNCRlZLTUFVTC95SXNEZ1VCVGdBRUFJazhDVkl3QVF2K3NpZ0lBTVFBaUtHVkVFa1N4aS82eUI0di9zZ2dqc2hBaXNnR3pzVElJRmlxeUdvQUlkMmwwYUdSeVlYZXlHcklhSndheUdpU3lHQ1d5RUNLeUFiT0ppZ0VBTVFBaUtHVkVFa1FvaS85bmliRXlDQllxc2hxQUEzQmhlYklhc2hxQUIzTjFZMk5sYzNPeUdpU3lHQ1d5RUNLeUFiT0pza0NBQk1CTGRmU3lHb3Y4c2hxTC9iSWFpLzZ5R2lTeUVDS3lBYk8wUFRJSEZrc0JGb3Y4RllFZUNFa1dWd1lDZ0FJQUhreFFpLzBWVHdJSVRJditVRThEVUU4Q1VFd1dWd1lDVUl2OFVJdjlVSXYvVUNJb1pVUVdTYnhJVEw4aUtHVkVJd2dvVEdleE1nZ1dnQVNsZnhpU3NocUFDMk55WldGMFpVRm5aVzUwc2hxeUdvQUhjM1ZqWTJWemM3SWFnZHEzcXVVQ3NoZ2tzaEFpc2dHemlZb0JBREVBTVJoeUIwUVNSSXYvRmttOVJRRkV2RWdpS0dWRUl3a29UR2VKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
