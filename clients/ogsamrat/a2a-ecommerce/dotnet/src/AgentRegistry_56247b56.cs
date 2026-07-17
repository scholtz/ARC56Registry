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

namespace Arc56.Generated.ogsamrat.a2a_ecommerce.AgentRegistry_56247b56
{


    public class AgentRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgentRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AgentProfile : AVMObjectType
            {
                public ulong TotalScore { get; set; }

                public ulong FeedbackCount { get; set; }

                public ulong RegisteredAt { get; set; }

                public ulong IsActive { get; set; }

                public ulong Price { get; set; }

                public ulong ListingTypeCode { get; set; }

                public ulong AgentSlot { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalScore.From(TotalScore);
                    ret.AddRange(vTotalScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeedbackCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFeedbackCount.From(FeedbackCount);
                    ret.AddRange(vFeedbackCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegisteredAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRegisteredAt.From(RegisteredAt);
                    ret.AddRange(vRegisteredAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vIsActive.From(IsActive);
                    ret.AddRange(vIsActive.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrice.From(Price);
                    ret.AddRange(vPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vListingTypeCode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vListingTypeCode.From(ListingTypeCode);
                    ret.AddRange(vListingTypeCode.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentSlot = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAgentSlot.From(AgentSlot);
                    ret.AddRange(vAgentSlot.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AgentProfile Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AgentProfile();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalScore = vTotalScore.ToValue();
                    if (valueTotalScore is ulong vTotalScoreValue) { ret.TotalScore = vTotalScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeedbackCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFeedbackCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFeedbackCount = vFeedbackCount.ToValue();
                    if (valueFeedbackCount is ulong vFeedbackCountValue) { ret.FeedbackCount = vFeedbackCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegisteredAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRegisteredAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRegisteredAt = vRegisteredAt.ToValue();
                    if (valueRegisteredAt is ulong vRegisteredAtValue) { ret.RegisteredAt = vRegisteredAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vIsActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsActive = vIsActive.ToValue();
                    if (valueIsActive is ulong vIsActiveValue) { ret.IsActive = vIsActiveValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrice = vPrice.ToValue();
                    if (valuePrice is ulong vPriceValue) { ret.Price = vPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vListingTypeCode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vListingTypeCode.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueListingTypeCode = vListingTypeCode.ToValue();
                    if (valueListingTypeCode is ulong vListingTypeCodeValue) { ret.ListingTypeCode = vListingTypeCodeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentSlot = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAgentSlot.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgentSlot = vAgentSlot.ToValue();
                    if (valueAgentSlot is ulong vAgentSlotValue) { ret.AgentSlot = vAgentSlotValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AgentProfile);
                }
                public bool Equals(AgentProfile? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AgentProfile left, AgentProfile right)
                {
                    return EqualityComparer<AgentProfile>.Default.Equals(left, right);
                }
                public static bool operator !=(AgentProfile left, AgentProfile right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register the calling account as an agent with a service listing.
        ///listingData: UTF-8 JSON bytes — { sellerName, service, description }
        ///price:       listing price in microALGO
        ///typeCode:    0–4 listing type code
        ///</summary>
        /// <param name="listingData"> </param>
        /// <param name="price"> </param>
        /// <param name="typeCode"> </param>
        public async Task RegisterWithListing(byte[] listingData, ulong price, ulong typeCode, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 0, 80, 74 };
            var listingDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); listingDataAbi.From(listingData);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var typeCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); typeCodeAbi.From(typeCode);

            var result = await base.CallApp(new List<object> { abiHandle, listingDataAbi, priceAbi, typeCodeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterWithListing_Transactions(byte[] listingData, ulong price, ulong typeCode, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 0, 80, 74 };
            var listingDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); listingDataAbi.From(listingData);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var typeCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); typeCodeAbi.From(typeCode);

            return await base.MakeTransactionList(new List<object> { abiHandle, listingDataAbi, priceAbi, typeCodeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update a registered agent's listing. Only the agent themselves can call this.
        ///</summary>
        /// <param name="listingData"> </param>
        /// <param name="price"> </param>
        /// <param name="typeCode"> </param>
        public async Task UpdateListing(byte[] listingData, ulong price, ulong typeCode, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 177, 60, 192 };
            var listingDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); listingDataAbi.From(listingData);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var typeCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); typeCodeAbi.From(typeCode);

            var result = await base.CallApp(new List<object> { abiHandle, listingDataAbi, priceAbi, typeCodeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateListing_Transactions(byte[] listingData, ulong price, ulong typeCode, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 177, 60, 192 };
            var listingDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); listingDataAbi.From(listingData);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var typeCodeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); typeCodeAbi.From(typeCode);

            return await base.MakeTransactionList(new List<object> { abiHandle, listingDataAbi, priceAbi, typeCodeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deactivate an agent (admin only).
        ///</summary>
        /// <param name="agent"> </param>
        public async Task DeactivateAgent(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 110, 221, 152 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeactivateAgent_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 110, 221, 152 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Submit a reputation score (0–100) for a registered agent.
        ///Can be called by any account except the agent themselves.
        ///</summary>
        /// <param name="agent"> </param>
        /// <param name="score"> </param>
        public async Task SubmitFeedback(Algorand.Address agent, ulong score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 243, 76, 155 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scoreAbi.From(score);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi, scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitFeedback_Transactions(Algorand.Address agent, ulong score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 243, 76, 155 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scoreAbi.From(score);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi, scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<ulong> GetReputation(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 105, 133, 23 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.SimApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetReputation_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 105, 133, 23 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<Structs.AgentProfile> GetAgentProfile(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 9, 210, 75 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.SimApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AgentProfile.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAgentProfile_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 9, 210, 75 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<ulong> IsRegistered(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 222, 78, 87 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.SimApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsRegistered_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 222, 78, 87 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetAgentCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 94, 84, 40 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAgentCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 94, 84, 40 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetTotalFeedbacks(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 61, 15, 173 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalFeedbacks_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 61, 15, 173 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Pause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 120, 249, 75 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Pause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 120, 249, 75 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Unpause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 82, 157, 232 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Unpause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 82, 157, 232 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newAdmin"> </param>
        public async Task TransferAdmin(Algorand.Address newAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 225, 185, 204 };
            var newAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAdminAbi.From(newAdmin);

            var result = await base.CallApp(new List<object> { abiHandle, newAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferAdmin_Transactions(Algorand.Address newAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 225, 185, 204 };
            var newAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAdminAbi.From(newAdmin);

            return await base.MakeTransactionList(new List<object> { abiHandle, newAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DeleteApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdlbnRSZWdpc3RyeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBZ2VudFByb2ZpbGUiOlt7Im5hbWUiOiJ0b3RhbFNjb3JlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZlZWRiYWNrQ291bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmVnaXN0ZXJlZEF0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImlzQWN0aXZlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByaWNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Imxpc3RpbmdUeXBlQ29kZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhZ2VudFNsb3QiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyV2l0aExpc3RpbmciLCJkZXNjIjoiUmVnaXN0ZXIgdGhlIGNhbGxpbmcgYWNjb3VudCBhcyBhbiBhZ2VudCB3aXRoIGEgc2VydmljZSBsaXN0aW5nLlxubGlzdGluZ0RhdGE6IFVURi04IEpTT04gYnl0ZXMg4oCUIHsgc2VsbGVyTmFtZSwgc2VydmljZSwgZGVzY3JpcHRpb24gfVxucHJpY2U6ICAgICAgIGxpc3RpbmcgcHJpY2UgaW4gbWljcm9BTEdPXG50eXBlQ29kZTogICAgMOKAkzQgbGlzdGluZyB0eXBlIGNvZGUiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibGlzdGluZ0RhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eXBlQ29kZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVMaXN0aW5nIiwiZGVzYyI6IlVwZGF0ZSBhIHJlZ2lzdGVyZWQgYWdlbnQncyBsaXN0aW5nLiBPbmx5IHRoZSBhZ2VudCB0aGVtc2VsdmVzIGNhbiBjYWxsIHRoaXMuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxpc3RpbmdEYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidHlwZUNvZGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVhY3RpdmF0ZUFnZW50IiwiZGVzYyI6IkRlYWN0aXZhdGUgYW4gYWdlbnQgKGFkbWluIG9ubHkpLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VibWl0RmVlZGJhY2siLCJkZXNjIjoiU3VibWl0IGEgcmVwdXRhdGlvbiBzY29yZSAoMOKAkzEwMCkgZm9yIGEgcmVnaXN0ZXJlZCBhZ2VudC5cbkNhbiBiZSBjYWxsZWQgYnkgYW55IGFjY291bnQgZXhjZXB0IHRoZSBhZ2VudCB0aGVtc2VsdmVzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjb3JlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJlcHV0YXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRBZ2VudFByb2ZpbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQWdlbnRQcm9maWxlIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc1JlZ2lzdGVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRBZ2VudENvdW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUb3RhbEZlZWRiYWNrcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5wYXVzZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2ZlckFkbWluIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdBZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjMsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNjZdLCJlcnJvck1lc3NhZ2UiOiJBZ2VudCBhbHJlYWR5IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDQsNTE2XSwiZXJyb3JNZXNzYWdlIjoiQWdlbnQgaXMgaW5hY3RpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODcsNDU0LDQ5NCw1NjMsNjA5XSwiZXJyb3JNZXNzYWdlIjoiQWdlbnQgbm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTddLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA2XSwiZXJyb3JNZXNzYWdlIjoiQ2Fubm90IHJldmlldyB5b3Vyc2VsZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1NywzNzksNDg1XSwiZXJyb3JNZXNzYWdlIjoiQ29udHJhY3QgaXMgcGF1c2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjcxLDM5MV0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgbGlzdGluZyB0eXBlIGNvZGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDddLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBEZWxldGVBcHBsaWNhdGlvbiAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODddLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTAwXSwiZXJyb3JNZXNzYWdlIjoiU2NvcmUgbXVzdCBiZSAwLTEwMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0Niw2NzAsNjgzLDcwNCw3MTddLCJlcnJvck1lc3NhZ2UiOiJhc3NlcnQgdGFyZ2V0IGlzIG1hdGNoIGZvciBjb25kaXRpb25zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU1LDI3NiwzNzcsNDQ0LDQ4Myw1MzksNjQzLDY1NSw2NjgsNjgxLDcwMiw3MTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjIsMzQ0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMwLDM1Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzgsNDcwLDU1NSw2MDEsNjI1LDY5Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDEsMjUwLDM2MywzNzEsNDc4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURnZ016SUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltRWlJQ0poWkcxcGJpSWdJbkJoZFhObFpDSWdNSGd4TlRGbU4yTTNOU0FpWVdkbGJuUkRiM1Z1ZENJZ0luUnZkR0ZzUm1WbFpHSmhZMnR6SWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z1lXZGxiblJEYjNWdWRDQWdJQ0FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTazdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhaMlZ1ZEVOdmRXNTBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCMGIzUmhiRVpsWldSaVlXTnJjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtUc0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUnZkR0ZzUm1WbFpHSmhZMnR6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QndZWFZ6WldRZ0lDQWdJQ0FnSUNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLVHNLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkJoZFhObFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qUTJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVdkbGJuUlNaV2RwYzNSeWVTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VESTBPRGRqTXpKaklDOHZJRzFsZEdodlpDQWlaR1ZzWlhSbFFYQndiR2xqWVhScGIyNG9LWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1WDNKdmRYUmxRRFFLQ20xaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTFPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pvME5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZuWlc1MFVtVm5hWE4wY25rZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTWpBS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnek5qQXdOVEEwWVNBd2VEa3hZakV6WTJNd0lEQjRNMlUyWldSa09UZ2dNSGd5TVdZek5HTTVZaUF3ZURoa05qazROVEUzSURCNFpXRXdPV1F5TkdJZ01IaGtOV1JsTkdVMU55QXdlRFUzTldVMU5ESTRJREI0WWpjelpEQm1ZV1FnTUhnd01UYzRaamswWWlBd2VERmlOVEk1WkdVNElEQjROMlZsTVdJNVkyTWdMeThnYldWMGFHOWtJQ0p5WldkcGMzUmxjbGRwZEdoTWFYTjBhVzVuS0dKNWRHVmJYU3gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVXhwYzNScGJtY29ZbmwwWlZ0ZExIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlaR1ZoWTNScGRtRjBaVUZuWlc1MEtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzNWaWJXbDBSbVZsWkdKaFkyc29ZV1JrY21WemN5eDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFVtVndkWFJoZEdsdmJpaGhaR1J5WlhOektYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBRV2RsYm5SUWNtOW1hV3hsS0dGa1pISmxjM01wS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWx6VW1WbmFYTjBaWEpsWkNoaFpHUnlaWE56S1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFFXZGxiblJEYjNWdWRDZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJVYjNSaGJFWmxaV1JpWVdOcmN5Z3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSndZWFZ6WlNncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZFc1d1lYVnpaU2dwZG05cFpDSXNJRzFsZEdodlpDQWlkSEpoYm5ObVpYSkJaRzFwYmloaFpHUnlaWE56S1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J5WldkcGMzUmxjbGRwZEdoTWFYTjBhVzVuSUhWd1pHRjBaVXhwYzNScGJtY2daR1ZoWTNScGRtRjBaVUZuWlc1MElITjFZbTFwZEVabFpXUmlZV05ySUdkbGRGSmxjSFYwWVhScGIyNGdaMlYwUVdkbGJuUlFjbTltYVd4bElHbHpVbVZuYVhOMFpYSmxaQ0JuWlhSQloyVnVkRU52ZFc1MElHZGxkRlJ2ZEdGc1JtVmxaR0poWTJ0eklIQmhkWE5sSUhWdWNHRjFjMlVnZEhKaGJuTm1aWEpCWkcxcGJnb2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FESXdPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pvME5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZuWlc1MFVtVm5hWE4wY25rZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaU9EUTBOMkl6TmlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsUVhCd2JHbGpZWFJwYjI0S0lDQWdJR1Z5Y2dvS2JXRnBibDlrWld4bGRHVkJjSEJzYVdOaGRHbHZibDl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE9Ua0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDSkVaV3hsZEdWQmNIQnNhV05oZEdsdmJpSWdmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJSEIxYzJocGJuUWdOU0F2THlCRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmdvZ0lDQWdQVDBLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUVSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHSWdaR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtDZ292THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPanBCWjJWdWRGSmxaMmx6ZEhKNUxtTnlaV0YwWlVGd2NHeHBZMkYwYVc5dVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbFFYQndiR2xqWVhScGIyNDZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pRM0NpQWdJQ0F2THlCaFpHMXBiaUFnSUNBZ0lDQWdJQ0E5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDazdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhaRzFwYmlJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZOakVLSUNBZ0lDOHZJSFJvYVhNdVlXUnRhVzR1ZG1Gc2RXVWdQU0JVZUc0dWMyVnVaR1Z5T3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDSk9iMDl3SWl3Z2IyNURjbVZoZEdVNklDSnlaWEYxYVhKbElpQjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02T2tGblpXNTBVbVZuYVhOMGNua3VjbVZuYVhOMFpYSlhhWFJvVEdsemRHbHVaMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFoybHpkR1Z5VjJsMGFFeHBjM1JwYm1jNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPamN5TFRjMkNpQWdJQ0F2THlCd2RXSnNhV01nY21WbmFYTjBaWEpYYVhSb1RHbHpkR2x1WnlnS0lDQWdJQzh2SUNBZ2JHbHpkR2x1WjBSaGRHRTZJR0o1ZEdWekxBb2dJQ0FnTHk4Z0lDQndjbWxqWlRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCMGVYQmxRMjlrWlRvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem8zTndvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWNHRjFjMlZrTG5aaGJIVmxJRDA5UFNCVmFXNTBOalFvTUNrc0lDSkRiMjUwY21GamRDQnBjeUJ3WVhWelpXUWlLVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCd1lYVnpaV1FnSUNBZ0lDQWdJQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtUc0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luQmhkWE5sWkNJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZOemNLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5CaGRYTmxaQzUyWVd4MVpTQTlQVDBnVldsdWREWTBLREFwTENBaVEyOXVkSEpoWTNRZ2FYTWdjR0YxYzJWa0lpazdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRU52Ym5SeVlXTjBJR2x6SUhCaGRYTmxaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z1lXZGxiblJ6SUNBZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1FXZGxiblJRY205bWFXeGxQaWg3SUd0bGVWQnlaV1pwZURvZ0ltRWlJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVNJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZOemdLSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hkR2hwY3k1aFoyVnVkSE1vVkhodUxuTmxibVJsY2lrdVpYaHBjM1J6TENBaVFXZGxiblFnWVd4eVpXRmtlU0J5WldkcGMzUmxjbVZrSWlrN0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qVXpDaUFnSUNBdkx5QmhaMlZ1ZEhNZ0lDQTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQkJaMlZ1ZEZCeWIyWnBiR1UrS0hzZ2EyVjVVSEpsWm1sNE9pQWlZU0lnZlNrN0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUdGemMyVnlkQ2doZEdocGN5NWhaMlZ1ZEhNb1ZIaHVMbk5sYm1SbGNpa3VaWGhwYzNSekxDQWlRV2RsYm5RZ1lXeHlaV0ZrZVNCeVpXZHBjM1JsY21Wa0lpazdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaMlZ1ZENCaGJISmxZV1I1SUhKbFoybHpkR1Z5WldRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZOemtLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBlWEJsUTI5a1pTQThQU0JWYVc1ME5qUW9OQ2tzSUNKSmJuWmhiR2xrSUd4cGMzUnBibWNnZEhsd1pTQmpiMlJsSWlrN0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlBMENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUWdiR2x6ZEdsdVp5QjBlWEJsSUdOdlpHVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02T0RFS0lDQWdJQzh2SUdOdmJuTjBJSE5zYjNRZ1BTQjBhR2x6TG1GblpXNTBRMjkxYm5RdWRtRnNkV1U3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z1lXZGxiblJEYjNWdWRDQWdJQ0FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTazdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmhaMlZ1ZEVOdmRXNTBJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pvNE1Rb2dJQ0FnTHk4Z1kyOXVjM1FnYzJ4dmRDQTlJSFJvYVhNdVlXZGxiblJEYjNWdWRDNTJZV3gxWlRzS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qZ3lMVGt3Q2lBZ0lDQXZMeUJqYjI1emRDQndjbTltYVd4bE9pQkJaMlZ1ZEZCeWIyWnBiR1VnUFNCN0NpQWdJQ0F2THlBZ0lIUnZkR0ZzVTJOdmNtVTZJQ0FnSUNBZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQm1aV1ZrWW1GamEwTnZkVzUwT2lBZ0lGVnBiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdjbVZuYVhOMFpYSmxaRUYwT2lBZ0lDQnpiRzkwTEFvZ0lDQWdMeThnSUNCcGMwRmpkR2wyWlRvZ0lDQWdJQ0FnSUZWcGJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNBZ2NISnBZMlVzQ2lBZ0lDQXZMeUFnSUd4cGMzUnBibWRVZVhCbFEyOWtaVG9nZEhsd1pVTnZaR1VzQ2lBZ0lDQXZMeUFnSUdGblpXNTBVMnh2ZERvZ0lDQWdJQ0FnYzJ4dmRDd0tJQ0FnSUM4dklIMDdDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPamcyQ2lBZ0lDQXZMeUJwYzBGamRHbDJaVG9nSUNBZ0lDQWdJRlZwYm5RMk5DZ3hLU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pneUxUa3dDaUFnSUNBdkx5QmpiMjV6ZENCd2NtOW1hV3hsT2lCQloyVnVkRkJ5YjJacGJHVWdQU0I3Q2lBZ0lDQXZMeUFnSUhSdmRHRnNVMk52Y21VNklDQWdJQ0FnVldsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNCbVpXVmtZbUZqYTBOdmRXNTBPaUFnSUZWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ2NtVm5hWE4wWlhKbFpFRjBPaUFnSUNCemJHOTBMQW9nSUNBZ0x5OGdJQ0JwYzBGamRHbDJaVG9nSUNBZ0lDQWdJRlZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnY0hKcFkyVXNDaUFnSUNBdkx5QWdJR3hwYzNScGJtZFVlWEJsUTI5a1pUb2dkSGx3WlVOdlpHVXNDaUFnSUNBdkx5QWdJR0ZuWlc1MFUyeHZkRG9nSUNBZ0lDQWdjMnh2ZEN3S0lDQWdJQzh2SUgwN0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJoWjJWdWRITWdJQ0E5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0JCWjJWdWRGQnliMlpwYkdVK0tIc2dhMlY1VUhKbFptbDRPaUFpWVNJZ2ZTazdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pvNU1Rb2dJQ0FnTHk4Z2RHaHBjeTVoWjJWdWRITW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdJQ0E5SUdOc2IyNWxLSEJ5YjJacGJHVXBPd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnWVdkbGJuUnpJQ0FnUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnUVdkbGJuUlFjbTltYVd4bFBpaDdJR3RsZVZCeVpXWnBlRG9nSW1FaUlIMHBPd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qa3hDaUFnSUNBdkx5QjBhR2x6TG1GblpXNTBjeWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0FnSUQwZ1kyeHZibVVvY0hKdlptbHNaU2s3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJzYVhOMGFXNW5jeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0JpZVhSbGN6NG9leUJyWlhsUWNtVm1hWGc2SUNKc0lpQjlLVHNLSUNBZ0lIQjFjMmhpZVhSbGN5QWliQ0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk9USUtJQ0FnSUM4dklIUm9hWE11YkdsemRHbHVaM01vVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCc2FYTjBhVzVuUkdGMFlUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJR3hwYzNScGJtZHpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJR0o1ZEdWelBpaDdJR3RsZVZCeVpXWnBlRG9nSW13aUlIMHBPd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qa3lDaUFnSUNBdkx5QjBhR2x6TG14cGMzUnBibWR6S0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQwZ2JHbHpkR2x1WjBSaGRHRTdDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2prekNpQWdJQ0F2THlCMGFHbHpMbUZuWlc1MFEyOTFiblF1ZG1Gc2RXVWdQU0J6Ykc5MElDc2dWV2x1ZERZMEtERXBPd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJR0ZuWlc1MFEyOTFiblFnSUNBZ0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwT3dvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVdkbGJuUkRiM1Z1ZENJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZPVE1LSUNBZ0lDOHZJSFJvYVhNdVlXZGxiblJEYjNWdWRDNTJZV3gxWlNBOUlITnNiM1FnS3lCVmFXNTBOalFvTVNrN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem8zTWkwM05nb2dJQ0FnTHk4Z2NIVmliR2xqSUhKbFoybHpkR1Z5VjJsMGFFeHBjM1JwYm1jb0NpQWdJQ0F2THlBZ0lHeHBjM1JwYm1kRVlYUmhPaUJpZVhSbGN5d0tJQ0FnSUM4dklDQWdjSEpwWTJVNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2RIbHdaVU52WkdVNklIVnBiblEyTkN3S0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk9rRm5aVzUwVW1WbmFYTjBjbmt1ZFhCa1lYUmxUR2x6ZEdsdVoxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ3WkdGMFpVeHBjM1JwYm1jNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPams1TFRFd013b2dJQ0FnTHk4Z2NIVmliR2xqSUhWd1pHRjBaVXhwYzNScGJtY29DaUFnSUNBdkx5QWdJR3hwYzNScGJtZEVZWFJoT2lCaWVYUmxjeXdLSUNBZ0lDOHZJQ0FnY0hKcFkyVTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdkSGx3WlVOdlpHVTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE1EUUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbkJoZFhObFpDNTJZV3gxWlNBOVBUMGdWV2x1ZERZMEtEQXBMQ0FpUTI5dWRISmhZM1FnYVhNZ2NHRjFjMlZrSWlrN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZuYVhOMGNua3VZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdjR0YxYzJWa0lDQWdJQ0FnSUNBZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2s3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p3WVhWelpXUWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFd05Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVjR0YxYzJWa0xuWmhiSFZsSUQwOVBTQlZhVzUwTmpRb01Da3NJQ0pEYjI1MGNtRmpkQ0JwY3lCd1lYVnpaV1FpS1RzS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1EyOXVkSEpoWTNRZ2FYTWdjR0YxYzJWa0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJoWjJWdWRITWdJQ0E5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0JCWjJWdWRGQnliMlpwYkdVK0tIc2dhMlY1VUhKbFptbDRPaUFpWVNJZ2ZTazdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE1EVUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUZuWlc1MGN5aFVlRzR1YzJWdVpHVnlLUzVsZUdsemRITXNJQ0pCWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkNJcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZuYVhOMGNua3VZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdZV2RsYm5SeklDQWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dRV2RsYm5SUWNtOW1hV3hsUGloN0lHdGxlVkJ5WldacGVEb2dJbUVpSUgwcE93b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFd05Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZV2RsYm5SektGUjRiaTV6Wlc1a1pYSXBMbVY0YVhOMGN5d2dJa0ZuWlc1MElHNXZkQ0J5WldkcGMzUmxjbVZrSWlrN0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaMlZ1ZENCdWIzUWdjbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE1EWUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGVYQmxRMjlrWlNBOFBTQlZhVzUwTmpRb05Da3NJQ0pKYm5aaGJHbGtJR3hwYzNScGJtY2dkSGx3WlNCamIyUmxJaWs3Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lHeHBjM1JwYm1jZ2RIbHdaU0JqYjJSbENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJoWjJWdWRITWdJQ0E5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0JCWjJWdWRGQnliMlpwYkdVK0tIc2dhMlY1VUhKbFptbDRPaUFpWVNJZ2ZTazdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE1EZ0tJQ0FnSUM4dklHTnZibk4wSUhCeWIyWnBiR1VnUFNCamJHOXVaU2gwYUdsekxtRm5aVzUwY3loVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNrN0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qVXpDaUFnSUNBdkx5QmhaMlZ1ZEhNZ0lDQTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQkJaMlZ1ZEZCeWIyWnBiR1UrS0hzZ2EyVjVVSEpsWm1sNE9pQWlZU0lnZlNrN0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRBNENpQWdJQ0F2THlCamIyNXpkQ0J3Y205bWFXeGxJRDBnWTJ4dmJtVW9kR2hwY3k1aFoyVnVkSE1vVkhodUxuTmxibVJsY2lrdWRtRnNkV1VwT3dvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUVKdmVDQnRkWE4wSUdoaGRtVWdkbUZzZFdVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZNVEE1Q2lBZ0lDQXZMeUJoYzNObGNuUW9jSEp2Wm1sc1pTNXBjMEZqZEdsMlpTQTlQVDBnVldsdWREWTBLREVwTENBaVFXZGxiblFnYVhNZ2FXNWhZM1JwZG1VaUtUc0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F5TkNBdkx5QXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGblpXNTBJR2x6SUdsdVlXTjBhWFpsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRXhNZ29nSUNBZ0x5OGdkWEJrWVhSbFpDNXdjbWxqWlNBZ0lDQWdJQ0FnSUNBZ1BTQndjbWxqWlRzS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NtVndiR0ZqWlRJZ016SUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRFekNpQWdJQ0F2THlCMWNHUmhkR1ZrTG14cGMzUnBibWRVZVhCbFEyOWtaU0E5SUhSNWNHVkRiMlJsT3dvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdOREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklHRm5aVzUwY3lBZ0lEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lFRm5aVzUwVUhKdlptbHNaVDRvZXlCclpYbFFjbVZtYVhnNklDSmhJaUI5S1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1FaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPakV4TkFvZ0lDQWdMeThnZEdocGN5NWhaMlZ1ZEhNb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ0lDQTlJR05zYjI1bEtIVndaR0YwWldRcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZuYVhOMGNua3VZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdZV2RsYm5SeklDQWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dRV2RsYm5SUWNtOW1hV3hsUGloN0lHdGxlVkJ5WldacGVEb2dJbUVpSUgwcE93b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFeE5Bb2dJQ0FnTHk4Z2RHaHBjeTVoWjJWdWRITW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdJQ0E5SUdOc2IyNWxLSFZ3WkdGMFpXUXBPd29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZuYVhOMGNua3VZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdiR2x6ZEdsdVozTWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dZbmwwWlhNK0tIc2dhMlY1VUhKbFptbDRPaUFpYkNJZ2ZTazdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltd2lDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFeE5Rb2dJQ0FnTHk4Z2RHaHBjeTVzYVhOMGFXNW5jeWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUd4cGMzUnBibWRFWVhSaE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZuYVhOMGNua3VZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdiR2x6ZEdsdVozTWdQU0JDYjNoTllYQThRV05qYjNWdWRDd2dZbmwwWlhNK0tIc2dhMlY1VUhKbFptbDRPaUFpYkNJZ2ZTazdDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1URTFDaUFnSUNBdkx5QjBhR2x6TG14cGMzUnBibWR6S0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQwZ2JHbHpkR2x1WjBSaGRHRTdDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZuYVhOMGNua3VZV3huYnk1MGN6bzVPUzB4TURNS0lDQWdJQzh2SUhCMVlteHBZeUIxY0dSaGRHVk1hWE4wYVc1bktBb2dJQ0FnTHk4Z0lDQnNhWE4wYVc1blJHRjBZVG9nWW5sMFpYTXNDaUFnSUNBdkx5QWdJSEJ5YVdObE9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lIUjVjR1ZEYjJSbE9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qcEJaMlZ1ZEZKbFoybHpkSEo1TG1SbFlXTjBhWFpoZEdWQloyVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbFlXTjBhWFpoZEdWQloyVnVkRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1URTVDaUFnSUNBdkx5QndkV0pzYVdNZ1pHVmhZM1JwZG1GMFpVRm5aVzUwS0dGblpXNTBPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRJd0NpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaFVlRzRzSUhzZ2MyVnVaR1Z5T2lCMGFHbHpMbUZrYldsdUxuWmhiSFZsSUgwcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklHRmtiV2x1SUNBZ0lDQWdJQ0FnSUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LVHNLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZrYldsdUlnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TWpBS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tGUjRiaXdnZXlCelpXNWtaWEk2SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1VnZlNrN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sY25RZ2RHRnlaMlYwSUdseklHMWhkR05vSUdadmNpQmpiMjVrYVhScGIyNXpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCaFoyVnVkSE1nSUNBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCQloyVnVkRkJ5YjJacGJHVStLSHNnYTJWNVVISmxabWw0T2lBaVlTSWdmU2s3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPakV5TVFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVlXZGxiblJ6S0dGblpXNTBLUzVsZUdsemRITXNJQ0pCWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkNJcE93b2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaMlZ1ZENCdWIzUWdjbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE1qVUtJQ0FnSUM4dklIVndaR0YwWldRdWFYTkJZM1JwZG1VZ1BTQlZhVzUwTmpRb01DazdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TWpVdE1USTJDaUFnSUNBdkx5QjFjR1JoZEdWa0xtbHpRV04wYVhabElEMGdWV2x1ZERZMEtEQXBPd29nSUNBZ0x5OGdkR2hwY3k1aFoyVnVkSE1vWVdkbGJuUXBMblpoYkhWbElEMGdZMnh2Ym1Vb2RYQmtZWFJsWkNrN0NpQWdJQ0J3ZFhOb2FXNTBJREkwSUM4dklESTBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TVRrS0lDQWdJQzh2SUhCMVlteHBZeUJrWldGamRHbDJZWFJsUVdkbGJuUW9ZV2RsYm5RNklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qcEJaMlZ1ZEZKbFoybHpkSEo1TG5OMVltMXBkRVpsWldSaVlXTnJXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzNWaWJXbDBSbVZsWkdKaFkyczZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFek5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhOMVltMXBkRVpsWldSaVlXTnJLR0ZuWlc1ME9pQkJZMk52ZFc1MExDQnpZMjl5WlRvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZNVE0yQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1d1lYVnpaV1F1ZG1Gc2RXVWdQVDA5SUZWcGJuUTJOQ2d3S1N3Z0lrTnZiblJ5WVdOMElHbHpJSEJoZFhObFpDSXBPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUhCaGRYTmxaQ0FnSUNBZ0lDQWdJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcE93b2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNHRjFjMlZrSWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hNellLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5CaGRYTmxaQzUyWVd4MVpTQTlQVDBnVldsdWREWTBLREFwTENBaVEyOXVkSEpoWTNRZ2FYTWdjR0YxYzJWa0lpazdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRU52Ym5SeVlXTjBJR2x6SUhCaGRYTmxaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z1lXZGxiblJ6SUNBZ1BTQkNiM2hOWVhBOFFXTmpiM1Z1ZEN3Z1FXZGxiblJRY205bWFXeGxQaWg3SUd0bGVWQnlaV1pwZURvZ0ltRWlJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVNJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRNM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWhaMlZ1ZEhNb1lXZGxiblFwTG1WNGFYTjBjeXdnSWtGblpXNTBJRzV2ZENCeVpXZHBjM1JsY21Wa0lpazdDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRUZuWlc1MElHNXZkQ0J5WldkcGMzUmxjbVZrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRXpPQW9nSUNBZ0x5OGdZWE56WlhKMEtITmpiM0psSUR3OUlFMUJXRjlUUTA5U1JTd2dJbE5qYjNKbElHMTFjM1FnWW1VZ01DMHhNREFpS1RzS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJREV3TUNBdkx5QXhNREFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1UyTnZjbVVnYlhWemRDQmlaU0F3TFRFd01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TXprS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUNFOVBTQmhaMlZ1ZEN3Z0lrTmhibTV2ZENCeVpYWnBaWGNnZVc5MWNuTmxiR1lpS1RzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJEWVc1dWIzUWdjbVYyYVdWM0lIbHZkWEp6Wld4bUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPakUwTVFvZ0lDQWdMeThnWTI5dWMzUWdjSEp2Wm1sc1pTQTlJR05zYjI1bEtIUm9hWE11WVdkbGJuUnpLR0ZuWlc1MEtTNTJZV3gxWlNrN0NpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TkRJS0lDQWdJQzh2SUdGemMyVnlkQ2h3Y205bWFXeGxMbWx6UVdOMGFYWmxJRDA5UFNCVmFXNTBOalFvTVNrc0lDSkJaMlZ1ZENCcGN5QnBibUZqZEdsMlpTSXBPd29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJMElDOHZJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FXZGxiblFnYVhNZ2FXNWhZM1JwZG1VS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZNVFExQ2lBZ0lDQXZMeUIxY0dSaGRHVmtMblJ2ZEdGc1UyTnZjbVVnSUNBZ1BTQjFjR1JoZEdWa0xuUnZkR0ZzVTJOdmNtVWdJQ0FnS3lCelkyOXlaVHNLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRRMkNpQWdJQ0F2THlCMWNHUmhkR1ZrTG1abFpXUmlZV05yUTI5MWJuUWdQU0IxY0dSaGRHVmtMbVpsWldSaVlXTnJRMjkxYm5RZ0t5QlZhVzUwTmpRb01TazdDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEZ0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRRM0NpQWdJQ0F2THlCMGFHbHpMbUZuWlc1MGN5aGhaMlZ1ZENrdWRtRnNkV1VnUFNCamJHOXVaU2gxY0dSaGRHVmtLVHNLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZNVFE0Q2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzUm1WbFpHSmhZMnR6TG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkVabFpXUmlZV05yY3k1MllXeDFaU0FySUZWcGJuUTJOQ2d4S1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qUTVDaUFnSUNBdkx5QjBiM1JoYkVabFpXUmlZV05yY3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLVHNLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ2ZEdGc1JtVmxaR0poWTJ0eklnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TkRnS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4R1pXVmtZbUZqYTNNdWRtRnNkV1VnUFNCMGFHbHpMblJ2ZEdGc1JtVmxaR0poWTJ0ekxuWmhiSFZsSUNzZ1ZXbHVkRFkwS0RFcE93b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCMGIzUmhiRVpsWldSaVlXTnJjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtUc0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUnZkR0ZzUm1WbFpHSmhZMnR6SWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hORGdLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hHWldWa1ltRmphM011ZG1Gc2RXVWdQU0IwYUdsekxuUnZkR0ZzUm1WbFpHSmhZMnR6TG5aaGJIVmxJQ3NnVldsdWREWTBLREVwT3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZNVE0xQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjM1ZpYldsMFJtVmxaR0poWTJzb1lXZGxiblE2SUVGalkyOTFiblFzSUhOamIzSmxPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPanBCWjJWdWRGSmxaMmx6ZEhKNUxtZGxkRkpsY0hWMFlYUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUlNaWEIxZEdGMGFXOXVPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE5UTUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCaFoyVnVkSE1nSUNBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCQloyVnVkRkJ5YjJacGJHVStLSHNnYTJWNVVISmxabWw0T2lBaVlTSWdmU2s3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPakUxTlFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVlXZGxiblJ6S0dGblpXNTBLUzVsZUdsemRITXNJQ0pCWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkNJcE93b2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaMlZ1ZENCdWIzUWdjbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE5UWUtJQ0FnSUM4dklHTnZibk4wSUhCeWIyWnBiR1VnUFNCamJHOXVaU2gwYUdsekxtRm5aVzUwY3loaFoyVnVkQ2t1ZG1Gc2RXVXBPd29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UVTNDaUFnSUNBdkx5QnBaaUFvY0hKdlptbHNaUzVtWldWa1ltRmphME52ZFc1MElEMDlQU0JWYVc1ME5qUW9NQ2twSUhKbGRIVnliaUJWYVc1ME5qUW9NQ2s3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1ltNTZJR2RsZEZKbGNIVjBZWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWjJWMFVtVndkWFJoZEdsdmJsOWhablJsY2w5cGJteHBibVZrWDJOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZPa0ZuWlc1MFVtVm5hWE4wY25rdVoyVjBVbVZ3ZFhSaGRHbHZia0EwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hOVE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1oyVjBVbVZ3ZFhSaGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFMU9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUNod2NtOW1hV3hsTG5SdmRHRnNVMk52Y21VZ0tpQlRRMEZNUlNrZ0x5QndjbTltYVd4bExtWmxaV1JpWVdOclEyOTFiblE3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElERXdNQ0F2THlBeE1EQUtJQ0FnSUNvS0lDQWdJR1JwWnlBeENpQWdJQ0F2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRTFNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmlJR2RsZEZKbGNIVjBZWFJwYjI1ZllXWjBaWEpmYVc1c2FXNWxaRjlqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qcEJaMlZ1ZEZKbFoybHpkSEo1TG1kbGRGSmxjSFYwWVhScGIyNUFOQW9LQ2k4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02T2tGblpXNTBVbVZuYVhOMGNua3VaMlYwUVdkbGJuUlFjbTltYVd4bFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwUVdkbGJuUlFjbTltYVd4bE9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TmpFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJoWjJWdWRITWdJQ0E5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0JCWjJWdWRGQnliMlpwYkdVK0tIc2dhMlY1VUhKbFptbDRPaUFpWVNJZ2ZTazdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRTJNd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WVdkbGJuUnpLR0ZuWlc1MEtTNWxlR2x6ZEhNc0lDSkJaMlZ1ZENCdWIzUWdjbVZuYVhOMFpYSmxaQ0lwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCQloyVnVkQ0J1YjNRZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TmpRS0lDQWdJQzh2SUhKbGRIVnliaUJqYkc5dVpTaDBhR2x6TG1GblpXNTBjeWhoWjJWdWRDa3VkbUZzZFdVcE93b2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFMk1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem82UVdkbGJuUlNaV2RwYzNSeWVTNXBjMUpsWjJsemRHVnlaV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGMxSmxaMmx6ZEdWeVpXUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFMk53b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUdGblpXNTBjeUFnSUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUVGblpXNTBVSEp2Wm1sc1pUNG9leUJyWlhsUWNtVm1hWGc2SUNKaElpQjlLVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUVpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZNVFk1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1aFoyVnVkSE1vWVdkbGJuUXBMbVY0YVhOMGN5QS9JRlZwYm5RMk5DZ3hLU0E2SUZWcGJuUTJOQ2d3S1RzS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE5qY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02T2tGblpXNTBVbVZuYVhOMGNua3VaMlYwUVdkbGJuUkRiM1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRUZuWlc1MFEyOTFiblE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRTNOQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WVdkbGJuUkRiM1Z1ZEM1MllXeDFaVHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCaFoyVnVkRU52ZFc1MElDQWdJQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtUc0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRm5aVzUwUTI5MWJuUWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFM05Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZV2RsYm5SRGIzVnVkQzUyWVd4MVpUc0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPakUzTWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZuYVhOMGNua3VZV3huYnk1MGN6bzZRV2RsYm5SU1pXZHBjM1J5ZVM1blpYUlViM1JoYkVabFpXUmlZV05yYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRlJ2ZEdGc1JtVmxaR0poWTJ0ek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TnprS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuUnZkR0ZzUm1WbFpHSmhZMnR6TG5aaGJIVmxPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUhSdmRHRnNSbVZsWkdKaFkydHpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcE93b2dJQ0FnWW5sMFpXTWdOU0F2THlBaWRHOTBZV3hHWldWa1ltRmphM01pQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRTNPUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11ZEc5MFlXeEdaV1ZrWW1GamEzTXVkbUZzZFdVN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hOemNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk9rRm5aVzUwVW1WbmFYTjBjbmt1Y0dGMWMyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B3WVhWelpUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRnMUNpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaFVlRzRzSUhzZ2MyVnVaR1Z5T2lCMGFHbHpMbUZrYldsdUxuWmhiSFZsSUgwcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklHRmtiV2x1SUNBZ0lDQWdJQ0FnSUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LVHNLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZrYldsdUlnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94T0RVS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tGUjRiaXdnZXlCelpXNWtaWEk2SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1VnZlNrN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sY25RZ2RHRnlaMlYwSUdseklHMWhkR05vSUdadmNpQmpiMjVrYVhScGIyNXpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCd1lYVnpaV1FnSUNBZ0lDQWdJQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtUc0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luQmhkWE5sWkNJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZNVGcyQ2lBZ0lDQXZMeUIwYUdsekxuQmhkWE5sWkM1MllXeDFaU0E5SUZWcGJuUTJOQ2d4S1RzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hPRFFLSUNBZ0lDOHZJSEIxWW14cFl5QndZWFZ6WlNncE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qcEJaMlZ1ZEZKbFoybHpkSEo1TG5WdWNHRjFjMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWJuQmhkWE5sT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hPVEFLSUNBZ0lDOHZJR0Z6YzJWeWRFMWhkR05vS0ZSNGJpd2dleUJ6Wlc1a1pYSTZJSFJvYVhNdVlXUnRhVzR1ZG1Gc2RXVWdmU2s3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem8wTndvZ0lDQWdMeThnWVdSdGFXNGdJQ0FnSUNBZ0lDQWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncE93b2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXUnRhVzRpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRTVNQW9nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvVkhodUxDQjdJSE5sYm1SbGNqb2dkR2hwY3k1aFpHMXBiaTUyWVd4MVpTQjlLVHNLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVnlkQ0IwWVhKblpYUWdhWE1nYldGMFkyZ2dabTl5SUdOdmJtUnBkR2x2Ym5NS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJSEJoZFhObFpDQWdJQ0FnSUNBZ0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwT3dvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY0dGMWMyVmtJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE9URUtJQ0FnSUM4dklIUm9hWE11Y0dGMWMyVmtMblpoYkhWbElEMGdWV2x1ZERZMEtEQXBPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFNE9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhWdWNHRjFjMlVvS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVm5hWE4wY25rdVlXeG5ieTUwY3pvNlFXZGxiblJTWldkcGMzUnllUzUwY21GdWMyWmxja0ZrYldsdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkSEpoYm5ObVpYSkJaRzFwYmpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZNVGswQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkSEpoYm5ObVpYSkJaRzFwYmlodVpYZEJaRzFwYmpvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRTVOUW9nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvVkhodUxDQjdJSE5sYm1SbGNqb2dkR2hwY3k1aFpHMXBiaTUyWVd4MVpTQjlLVHNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWldkcGMzUnllUzVoYkdkdkxuUnpPalEzQ2lBZ0lDQXZMeUJoWkcxcGJpQWdJQ0FnSUNBZ0lDQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0NrN0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaFpHMXBiaUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UazFDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2hVZUc0c0lIc2djMlZ1WkdWeU9pQjBhR2x6TG1Ga2JXbHVMblpoYkhWbElIMHBPd29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYSjBJSFJoY21kbGRDQnBjeUJ0WVhSamFDQm1iM0lnWTI5dVpHbDBhVzl1Y3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZuYVhOMGNua3VZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdZV1J0YVc0Z0lDQWdJQ0FnSUNBZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwT3dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVdSdGFXNGlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFNU5nb2dJQ0FnTHk4Z2RHaHBjeTVoWkcxcGJpNTJZV3gxWlNBOUlHNWxkMEZrYldsdU93b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRrMENpQWdJQ0F2THlCd2RXSnNhV01nZEhKaGJuTm1aWEpCWkcxcGJpaHVaWGRCWkcxcGJqb2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsWjJsemRISjVMbUZzWjI4dWRITTZPa0ZuWlc1MFVtVm5hWE4wY25rdVpHVnNaWFJsUVhCd2JHbGpZWFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaV3hsZEdWQmNIQnNhV05oZEdsdmJqb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TWpBeENpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaFVlRzRzSUhzZ2MyVnVaR1Z5T2lCMGFHbHpMbUZrYldsdUxuWmhiSFZsSUgwcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklHRmtiV2x1SUNBZ0lDQWdJQ0FnSUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9LVHNLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZrYldsdUlnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem95TURFS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tGUjRiaXdnZXlCelpXNWtaWEk2SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1VnZlNrN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sY25RZ2RHRnlaMlYwSUdseklHMWhkR05vSUdadmNpQmpiMjVrYVhScGIyNXpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFNU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0lrUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUlpQjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFSUlDWUdBV0VGWVdSdGFXNEdjR0YxYzJWa0JCVWZmSFVLWVdkbGJuUkRiM1Z1ZEE1MGIzUmhiRVpsWldSaVlXTnJjekVZUUFBTEp3UWlaeWNGSW1jcUltZUFCQ1NId3l3MkdnQ09BUUJ6TVJrVVJERVlRUUJjZ2d3RU5nQlFTZ1NSc1R6QUJENXUzWmdFSWZOTW13U05hWVVYQk9vSjBrc0UxZDVPVndSWFhsUW9CTGM5RDYwRUFYajVTd1FiVXAzb0JIN2h1Y3cyR2dDT0RBQWhBSnNBOXdFWEFXd0JtZ0d5QWNjQjB3SGZBZXdCK1FDQUJMaEVlelkyR2dDT0FRQU5BREVaZ1FVU01SZ1FSRUlCOHlreEFHY2pRellhQVVraVdZRUNDRXNCRlJKRVZ3SUFOaG9DU1JVa0VrUVhOaG9EU1JVa0VrUVhJaXBsUkJSRUtERUFVTDFGQVJSRVNZRUVEa1FpSndSbFJFa1dnQkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFTd0ZRSXhaUVR3UVdVRThERmxCTVVDZ3hBRkJNdjRBQmJERUFVRW04U0U4Q3Z5TUlKd1JNWnlORE5ob0JTU0paZ1FJSVN3RVZFa1JYQWdBMkdnSkpGU1FTUkRZYUEwa1ZKQkpFU1JjaUttVkVGRVFvTVFCUXZVVUJSSUVFRGtRb01RQlF2a1JKZ1JoYkl4SkVUd0pjSUV4Y0tDZ3hBRkJNdjRBQmJERUFVRW04U0V5L0kwTTJHZ0ZKRlNVU1JERUFJaWxsUkJKRUtFeFFTYjFGQVVRaUZvRVlUTHNqUXpZYUFVa1ZKUkpFTmhvQ1NSVWtFa1FYSWlwbFJCUkVLRXNDVUVtOVJRRkVTd0dCWkE1RU1RQlBBeE5FU2I1SVNZRVlXeU1TUkVraVcwOERDQlpjQUVra1d5TUlGbHdJdnlJbkJXVkVJd2duQlV4bkkwTTJHZ0ZKRlNVU1JDaE1VRW05UlFGRXZraEpKRnRKUUFBSUloWXJURkN3STBOTEFTSmJnV1FMU3dFS1F2L3NOaG9CU1JVbEVrUW9URkJKdlVVQlJMNUlLMHhRc0NORE5ob0JTUlVsRWtRb1RGQzlSUUVXSzB4UXNDTkRJaWNFWlVRV0sweFFzQ05ESWljRlpVUVdLMHhRc0NORE1RQWlLV1ZFRWtRcUkyY2pRekVBSWlsbFJCSkVLaUpuSTBNMkdnRkpGU1VTUkRFQUlpbGxSQkpFS1V4bkkwTXhBQ0lwWlVRU1JDTkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
