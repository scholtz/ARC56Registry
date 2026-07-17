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

namespace Arc56.Generated.SamyaDeb.ChainPe.ChainPeRegistry_dfef2186
{


    public class ChainPeRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ChainPeRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ServiceData : AVMObjectType
            {
                public string Name { get; set; }

                public string Description { get; set; }

                public string Tags { get; set; }

                public string Endpoint { get; set; }

                public string PricePerRequest { get; set; }

                public string PaymentToken { get; set; }

                public string WalletAddress { get; set; }

                public string Network { get; set; }

                public Algorand.Address Developer { get; set; }

                public ulong CreatedAt { get; set; }

                public ulong UpdatedAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDescription.From(Description);
                    stringRef[ret.Count] = vDescription.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTags = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTags.From(Tags);
                    stringRef[ret.Count] = vTags.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndpoint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEndpoint.From(Endpoint);
                    stringRef[ret.Count] = vEndpoint.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPricePerRequest = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPricePerRequest.From(PricePerRequest);
                    stringRef[ret.Count] = vPricePerRequest.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPaymentToken = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPaymentToken.From(PaymentToken);
                    stringRef[ret.Count] = vPaymentToken.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWalletAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vWalletAddress.From(WalletAddress);
                    stringRef[ret.Count] = vWalletAddress.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNetwork = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vNetwork.From(Network);
                    stringRef[ret.Count] = vNetwork.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeveloper = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vDeveloper.From(Developer);
                    ret.AddRange(vDeveloper.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUpdatedAt.From(UpdatedAt);
                    ret.AddRange(vUpdatedAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ServiceData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ServiceData();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexDescription = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDescription.Decode(bytes.Skip(indexDescription + prefixOffset).ToArray());
                    var valueDescription = vDescription.ToValue();
                    if (valueDescription is string vDescriptionValue) { ret.Description = vDescriptionValue; }
                    var indexTags = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTags = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTags.Decode(bytes.Skip(indexTags + prefixOffset).ToArray());
                    var valueTags = vTags.ToValue();
                    if (valueTags is string vTagsValue) { ret.Tags = vTagsValue; }
                    var indexEndpoint = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndpoint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEndpoint.Decode(bytes.Skip(indexEndpoint + prefixOffset).ToArray());
                    var valueEndpoint = vEndpoint.ToValue();
                    if (valueEndpoint is string vEndpointValue) { ret.Endpoint = vEndpointValue; }
                    var indexPricePerRequest = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPricePerRequest = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPricePerRequest.Decode(bytes.Skip(indexPricePerRequest + prefixOffset).ToArray());
                    var valuePricePerRequest = vPricePerRequest.ToValue();
                    if (valuePricePerRequest is string vPricePerRequestValue) { ret.PricePerRequest = vPricePerRequestValue; }
                    var indexPaymentToken = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPaymentToken = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPaymentToken.Decode(bytes.Skip(indexPaymentToken + prefixOffset).ToArray());
                    var valuePaymentToken = vPaymentToken.ToValue();
                    if (valuePaymentToken is string vPaymentTokenValue) { ret.PaymentToken = vPaymentTokenValue; }
                    var indexWalletAddress = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWalletAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vWalletAddress.Decode(bytes.Skip(indexWalletAddress + prefixOffset).ToArray());
                    var valueWalletAddress = vWalletAddress.ToValue();
                    if (valueWalletAddress is string vWalletAddressValue) { ret.WalletAddress = vWalletAddressValue; }
                    var indexNetwork = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNetwork = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vNetwork.Decode(bytes.Skip(indexNetwork + prefixOffset).ToArray());
                    var valueNetwork = vNetwork.ToValue();
                    if (valueNetwork is string vNetworkValue) { ret.Network = vNetworkValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeveloper = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDeveloper.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDeveloper = vDeveloper.ToValue();
                    if (valueDeveloper is Algorand.Address vDeveloperValue) { ret.Developer = vDeveloperValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUpdatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUpdatedAt = vUpdatedAt.ToValue();
                    if (valueUpdatedAt is ulong vUpdatedAtValue) { ret.UpdatedAt = vUpdatedAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ServiceData);
                }
                public bool Equals(ServiceData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ServiceData left, ServiceData right)
                {
                    return EqualityComparer<ServiceData>.Default.Equals(left, right);
                }
                public static bool operator !=(ServiceData left, ServiceData right)
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
        ///Register a new AI agent service on-chain.
        ///
        ///payTx MUST be a payment of >= 1 ALGO from Txn.sender → ADMIN_ADDRESS,
        ///grouped before this app call.
        ///</summary>
        /// <param name="payTx"> </param>
        /// <param name="name"> </param>
        /// <param name="description"> </param>
        /// <param name="tags"> </param>
        /// <param name="endpoint"> </param>
        /// <param name="pricePerRequest"> </param>
        /// <param name="paymentToken"> </param>
        /// <param name="walletAddress"> </param>
        /// <param name="network"> </param>
        public async Task Register(PaymentTransaction payTx, string name, string description, string tags, string endpoint, string pricePerRequest, string paymentToken, string walletAddress, string network, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTx });
            byte[] abiHandle = { 208, 245, 51, 74 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var tagsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tagsAbi.From(tags);
            var endpointAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); endpointAbi.From(endpoint);
            var pricePerRequestAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); pricePerRequestAbi.From(pricePerRequest);
            var paymentTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); paymentTokenAbi.From(paymentToken);
            var walletAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); walletAddressAbi.From(walletAddress);
            var networkAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); networkAbi.From(network);

            var result = await base.CallApp(new List<object> { abiHandle, payTx, nameAbi, descriptionAbi, tagsAbi, endpointAbi, pricePerRequestAbi, paymentTokenAbi, walletAddressAbi, networkAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Register_Transactions(PaymentTransaction payTx, string name, string description, string tags, string endpoint, string pricePerRequest, string paymentToken, string walletAddress, string network, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTx });
            byte[] abiHandle = { 208, 245, 51, 74 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var tagsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tagsAbi.From(tags);
            var endpointAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); endpointAbi.From(endpoint);
            var pricePerRequestAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); pricePerRequestAbi.From(pricePerRequest);
            var paymentTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); paymentTokenAbi.From(paymentToken);
            var walletAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); walletAddressAbi.From(walletAddress);
            var networkAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); networkAbi.From(network);

            return await base.MakeTransactionList(new List<object> { abiHandle, payTx, nameAbi, descriptionAbi, tagsAbi, endpointAbi, pricePerRequestAbi, paymentTokenAbi, walletAddressAbi, networkAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update an existing service registration.
        ///Only the original developer can update. Requires 1 ALGO payment.
        ///</summary>
        /// <param name="payTx"> </param>
        /// <param name="name"> </param>
        /// <param name="description"> </param>
        /// <param name="tags"> </param>
        /// <param name="endpoint"> </param>
        /// <param name="pricePerRequest"> </param>
        /// <param name="paymentToken"> </param>
        /// <param name="walletAddress"> </param>
        /// <param name="network"> </param>
        public async Task Update(PaymentTransaction payTx, string name, string description, string tags, string endpoint, string pricePerRequest, string paymentToken, string walletAddress, string network, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTx });
            byte[] abiHandle = { 161, 239, 141, 154 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var tagsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tagsAbi.From(tags);
            var endpointAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); endpointAbi.From(endpoint);
            var pricePerRequestAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); pricePerRequestAbi.From(pricePerRequest);
            var paymentTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); paymentTokenAbi.From(paymentToken);
            var walletAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); walletAddressAbi.From(walletAddress);
            var networkAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); networkAbi.From(network);

            var result = await base.CallApp(new List<object> { abiHandle, payTx, nameAbi, descriptionAbi, tagsAbi, endpointAbi, pricePerRequestAbi, paymentTokenAbi, walletAddressAbi, networkAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Update_Transactions(PaymentTransaction payTx, string name, string description, string tags, string endpoint, string pricePerRequest, string paymentToken, string walletAddress, string network, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTx });
            byte[] abiHandle = { 161, 239, 141, 154 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var tagsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tagsAbi.From(tags);
            var endpointAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); endpointAbi.From(endpoint);
            var pricePerRequestAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); pricePerRequestAbi.From(pricePerRequest);
            var paymentTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); paymentTokenAbi.From(paymentToken);
            var walletAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); walletAddressAbi.From(walletAddress);
            var networkAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); networkAbi.From(network);

            return await base.MakeTransactionList(new List<object> { abiHandle, payTx, nameAbi, descriptionAbi, tagsAbi, endpointAbi, pricePerRequestAbi, paymentTokenAbi, walletAddressAbi, networkAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Remove a service and refund box MBR. No payment required.
        ///Only the original developer can deregister.
        ///</summary>
        /// <param name="name"> </param>
        public async Task Deregister(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 77, 184, 184 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Deregister_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 77, 184, 184 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Fetch a service registration by developer address and name.
        ///</summary>
        /// <param name="developer">Algorand address string (base58-check, 58 chars) </param>
        /// <param name="name">Service name </param>
        public async Task<Structs.ServiceData> GetService(Algorand.Address developer, string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 120, 113, 253 };
            var developerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); developerAbi.From(developer);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.SimApp(new List<object> { abiHandle, developerAbi, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ServiceData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetService_Transactions(Algorand.Address developer, string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 120, 113, 253 };
            var developerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); developerAbi.From(developer);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, developerAbi, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if a service exists.
        ///</summary>
        /// <param name="developer"> </param>
        /// <param name="name"> </param>
        public async Task<bool> HasService(Algorand.Address developer, string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 12, 16, 189 };
            var developerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); developerAbi.From(developer);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.SimApp(new List<object> { abiHandle, developerAbi, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HasService_Transactions(Algorand.Address developer, string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 12, 16, 189 };
            var developerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); developerAbi.From(developer);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, developerAbi, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the admin wallet address that receives registration fees.
        ///</summary>
        public async Task<string> GetAdmin(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 80, 95, 168 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetAdmin_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 80, 95, 168 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the registration fee in microALGO.
        ///</summary>
        public async Task<ulong> GetRegistrationFee(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 206, 179, 97 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRegistrationFee_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 206, 179, 97 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2hhaW5QZVJlZ2lzdHJ5IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlNlcnZpY2VEYXRhIjpbeyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJkZXNjcmlwdGlvbiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ0YWdzIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImVuZHBvaW50IiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InByaWNlUGVyUmVxdWVzdCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJwYXltZW50VG9rZW4iLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoid2FsbGV0QWRkcmVzcyIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJuZXR3b3JrIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImRldmVsb3BlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiY3JlYXRlZEF0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InVwZGF0ZWRBdCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXIiLCJkZXNjIjoiUmVnaXN0ZXIgYSBuZXcgQUkgYWdlbnQgc2VydmljZSBvbi1jaGFpbi5cblxucGF5VHggTVVTVCBiZSBhIHBheW1lbnQgb2YgPj0gMSBBTEdPIGZyb20gVHhuLnNlbmRlciDihpIgQURNSU5fQUREUkVTUyxcbmdyb3VwZWQgYmVmb3JlIHRoaXMgYXBwIGNhbGwuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheVR4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXNjcmlwdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kcG9pbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlUGVyUmVxdWVzdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudFRva2VuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXRBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXR3b3JrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZSIsImRlc2MiOiJVcGRhdGUgYW4gZXhpc3Rpbmcgc2VydmljZSByZWdpc3RyYXRpb24uXG5Pbmx5IHRoZSBvcmlnaW5hbCBkZXZlbG9wZXIgY2FuIHVwZGF0ZS4gUmVxdWlyZXMgMSBBTEdPIHBheW1lbnQuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheVR4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXNjcmlwdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kcG9pbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlUGVyUmVxdWVzdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudFRva2VuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXRBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXR3b3JrIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcmVnaXN0ZXIiLCJkZXNjIjoiUmVtb3ZlIGEgc2VydmljZSBhbmQgcmVmdW5kIGJveCBNQlIuIE5vIHBheW1lbnQgcmVxdWlyZWQuXG5Pbmx5IHRoZSBvcmlnaW5hbCBkZXZlbG9wZXIgY2FuIGRlcmVnaXN0ZXIuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U2VydmljZSIsImRlc2MiOiJGZXRjaCBhIHNlcnZpY2UgcmVnaXN0cmF0aW9uIGJ5IGRldmVsb3BlciBhZGRyZXNzIGFuZCBuYW1lLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGV2ZWxvcGVyIiwiZGVzYyI6IkFsZ29yYW5kIGFkZHJlc3Mgc3RyaW5nIChiYXNlNTgtY2hlY2ssIDU4IGNoYXJzKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOiJTZXJ2aWNlIG5hbWUiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxzdHJpbmcsc3RyaW5nLHN0cmluZyxzdHJpbmcsc3RyaW5nLHN0cmluZyxzdHJpbmcsYWRkcmVzcyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlNlcnZpY2VEYXRhIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJoYXNTZXJ2aWNlIiwiZGVzYyI6IkNoZWNrIGlmIGEgc2VydmljZSBleGlzdHMuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXZlbG9wZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRBZG1pbiIsImRlc2MiOiJSZXR1cm5zIHRoZSBhZG1pbiB3YWxsZXQgYWRkcmVzcyB0aGF0IHJlY2VpdmVzIHJlZ2lzdHJhdGlvbiBmZWVzLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UmVnaXN0cmF0aW9uRmVlIiwiZGVzYyI6IlJldHVybnMgdGhlIHJlZ2lzdHJhdGlvbiBmZWUgaW4gbWljcm9BTEdPLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyN10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MDldLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHRoZSBvcmlnaW5hbCBkZXZlbG9wZXIgY2FuIGRlcmVnaXN0ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzldLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHRoZSBvcmlnaW5hbCBkZXZlbG9wZXIgY2FuIHVwZGF0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMjRdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgYmUgPj0gMSBBTEdPIGZyb20gc2VuZGVyIHRvIGFkbWluIHdhbGxldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0NV0sImVycm9yTWVzc2FnZSI6IlNlcnZpY2UgYWxyZWFkeSByZWdpc3RlcmVkOyB1c2UgdXBkYXRlKCkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MDAsODkzXSwiZXJyb3JNZXNzYWdlIjoiU2VydmljZSBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjldLCJlcnJvck1lc3NhZ2UiOiJTZXJ2aWNlIG5vdCBmb3VuZDsgdXNlIHJlZ2lzdGVyKCkgZmlyc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MjAsODMxXSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDcsMjIzLDIzOSwyNTUsMjcxLDI4NywzMDMsMzE5LDQ5Miw1MDgsNTI0LDU0MCw1NTYsNTcyLDU4OCw2MDQsNzgyLDg3MCw5MTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTcsMjMzLDI0OSwyNjUsMjgxLDI5NywzMTMsMzI2LDUwMiw1MTgsNTM0LDU1MCw1NjYsNTgyLDU5OCw2MTEsNzg5LDg3Nyw5MjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODY0LDkwOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDEsNDg2XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXlJREVnTXpJS0lDQWdJR0o1ZEdWallteHZZMnNnSW5OMll6b2lJQ0k2SWlBd2VEQXdOREFnTUhneE5URm1OMk0zTlFvZ0lDQWdMeThnYzNKakwwTm9ZV2x1VUdWU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pZd0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRMmhoYVc1UVpWSmxaMmx6ZEhKNUlHVjRkR1Z1WkhNZ1lYSmpOQzVEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVEVLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhrTUdZMU16TTBZU0F3ZUdFeFpXWTRaRGxoSURCNE9HVTBaR0k0WWpnZ01IZ3dZVGM0TnpGbVpDQXdlREE1TUdNeE1HSmtJREI0T0RrMU1EVm1ZVGdnTUhoa09XTmxZak0yTVNBdkx5QnRaWFJvYjJRZ0luSmxaMmx6ZEdWeUtIQmhlU3h6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJblZ3WkdGMFpTaHdZWGtzYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0prWlhKbFoybHpkR1Z5S0hOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJUWlhKMmFXTmxLR0ZrWkhKbGMzTXNjM1J5YVc1bktTaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5MR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0ltaGhjMU5sY25acFkyVW9ZV1JrY21WemN5eHpkSEpwYm1jcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWjJWMFFXUnRhVzRvS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWjJWMFVtVm5hWE4wY21GMGFXOXVSbVZsS0NsMWFXNTBOalFpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCeVpXZHBjM1JsY2lCMWNHUmhkR1VnWkdWeVpXZHBjM1JsY2lCblpYUlRaWEoyYVdObElHaGhjMU5sY25acFkyVWdiV0ZwYmw5blpYUkJaRzFwYmw5eWIzVjBaVUE0SUcxaGFXNWZaMlYwVW1WbmFYTjBjbUYwYVc5dVJtVmxYM0p2ZFhSbFFEa0tJQ0FnSUdWeWNnb0tiV0ZwYmw5blpYUlNaV2RwYzNSeVlYUnBiMjVHWldWZmNtOTFkR1ZBT1RvS0lDQWdJQzh2SUhOeVl5OURhR0ZwYmxCbFVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU16TUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VXdNREF3TURBd01EQXdNR1kwTWpRd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFFXUnRhVzVmY205MWRHVkFPRG9LSUNBZ0lDOHZJSE55WXk5RGFHRnBibEJsVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem95TWpVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01ETmhORE0wT1RVeE5XRTFNRE0yTkRrek56TXpOVEV6TlRNMU16SXpOelV4TlRjMVlUUTROV0UwWXpWaE5ESTBPVFEwTlRNMFpqUTROVFkxTmpNMU5HTTBaRFV3TXpVME9UUTFOVEUwWlRVeE5UazFOalV5TlRnMU9UUm1OV0UxTkRVeE5UTTFPVFF5TXpjMU9ETTFNemMxTURReU5EVUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNVG9LSUNBZ0lDOHZJSE55WXk5RGFHRnBibEJsVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFTm9ZV2x1VUdWU1pXZHBjM1J5ZVNCbGVIUmxibVJ6SUdGeVl6UXVRMjl1ZEhKaFkzUWdld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRZamcwTkRkaU16WWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI1ZmNtOTFkR1ZBTVRJS0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVkJjSEJzYVdOaGRHbHZibDl5YjNWMFpVQXhNam9LSUNBZ0lDOHZJSE55WXk5RGFHRnBibEJsVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHOXVRM0psWVhSbE9pQWljbVZ4ZFdseVpTSWdmU2tLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpjbU12UTJoaGFXNVFaVkpsWjJsemRISjVMbUZzWjI4dWRITTZPa05vWVdsdVVHVlNaV2RwYzNSeWVTNXlaV2RwYzNSbGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWjJsemRHVnlPZ29nSUNBZ0x5OGdjM0pqTDBOb1lXbHVVR1ZTWldkcGMzUnllUzVoYkdkdkxuUnpPamcyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh5SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ053b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEZ0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUhOeVl5OURhR0ZwYmxCbFVtVm5hWE4wY25rdVlXeG5ieTUwY3pvNU9Bb2dJQ0FnTHk4Z2RHaHBjeTUyWlhKcFpubFFZWGx0Wlc1MEtIQmhlVlI0S1RzS0lDQWdJSFZ1WTI5MlpYSWdNVFVLSUNBZ0lHTmhiR3h6ZFdJZ2RtVnlhV1o1VUdGNWJXVnVkQW9nSUNBZ0x5OGdjM0pqTDBOb1lXbHVVR1ZTWldkcGMzUnllUzVoYkdkdkxuUnpPakV3TUFvZ0lDQWdMeThnWTI5dWMzUWdZbTk0UzJWNUlEMGdkR2hwY3k1dFlXdGxTMlY1S0c1aGJXVXBPd29nSUNBZ1pHbG5JREUwQ2lBZ0lDQmpZV3hzYzNWaUlHMWhhMlZMWlhrS0lDQWdJQzh2SUhOeVl5OURhR0ZwYmxCbFVtVm5hWE4wY25rdVlXeG5ieTUwY3pvMk5Rb2dJQ0FnTHk4Z2MyVnlkbWxqWlhNZ1BTQkNiM2hOWVhBOFlubDBaWE1zSUZObGNuWnBZMlZFWVhSaFBpaDdJR3RsZVZCeVpXWnBlRG9nSW5OMll6b2lJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNaak9pSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjM0pqTDBOb1lXbHVVR1ZTWldkcGMzUnllUzVoYkdkdkxuUnpPakV3TVFvZ0lDQWdMeThnWVhOelpYSjBLQ0YwYUdsekxuTmxjblpwWTJWektHSnZlRXRsZVNrdVpYaHBjM1J6TENBaVUyVnlkbWxqWlNCaGJISmxZV1I1SUhKbFoybHpkR1Z5WldRN0lIVnpaU0IxY0dSaGRHVW9LU0lwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJUWlhKMmFXTmxJR0ZzY21WaFpIa2djbVZuYVhOMFpYSmxaRHNnZFhObElIVndaR0YwWlNncENpQWdJQ0F2THlCemNtTXZRMmhoYVc1UVpWSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1URTBDaUFnSUNBdkx5QmtaWFpsYkc5d1pYSTZJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpjbU12UTJoaGFXNVFaVkpsWjJsemRISjVMbUZzWjI4dWRITTZNVEF6Q2lBZ0lDQXZMeUJqYjI1emRDQnViM2NnUFNCSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdPd29nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ0x5OGdjM0pqTDBOb1lXbHVVR1ZTWldkcGMzUnllUzVoYkdkdkxuUnpPakV4TlFvZ0lDQWdMeThnWTNKbFlYUmxaRUYwT2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvYm05M0tTd0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnlZeTlEYUdGcGJsQmxVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hNRFV0TVRFM0NpQWdJQ0F2THlCMGFHbHpMbk5sY25acFkyVnpLR0p2ZUV0bGVTa3VkbUZzZFdVZ1BTQnVaWGNnVTJWeWRtbGpaVVJoZEdFb2V3b2dJQ0FnTHk4Z0lDQnVZVzFsT2lCdVlXMWxMQW9nSUNBZ0x5OGdJQ0JrWlhOamNtbHdkR2x2YmpvZ1pHVnpZM0pwY0hScGIyNHNDaUFnSUNBdkx5QWdJSFJoWjNNNklIUmhaM01zQ2lBZ0lDQXZMeUFnSUdWdVpIQnZhVzUwT2lCbGJtUndiMmx1ZEN3S0lDQWdJQzh2SUNBZ2NISnBZMlZRWlhKU1pYRjFaWE4wT2lCd2NtbGpaVkJsY2xKbGNYVmxjM1FzQ2lBZ0lDQXZMeUFnSUhCaGVXMWxiblJVYjJ0bGJqb2djR0Y1YldWdWRGUnZhMlZ1TEFvZ0lDQWdMeThnSUNCM1lXeHNaWFJCWkdSeVpYTnpPaUIzWVd4c1pYUkJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQnVaWFIzYjNKck9pQnVaWFIzYjNKckxBb2dJQ0FnTHk4Z0lDQmtaWFpsYkc5d1pYSTZJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUdOeVpXRjBaV1JCZERvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0c1dmR5a3NDaUFnSUNBdkx5QWdJSFZ3WkdGMFpXUkJkRG9nYm1WM0lHRnlZelF1VldsdWREWTBLRzV2ZHlrc0NpQWdJQ0F2THlCOUtUc0tJQ0FnSUhCMWMyaHBiblFnTmpRZ0x5OGdOalFLSUNBZ0lIVnVZMjkyWlhJZ01UY0tJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURRd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTVRZS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJREUwQ2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXhNZ29nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01UQUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjM0pqTDBOb1lXbHVVR1ZTWldkcGMzUnllUzVoYkdkdkxuUnpPamcyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6Y21NdlEyaGhhVzVRWlZKbFoybHpkSEo1TG1Gc1oyOHVkSE02T2tOb1lXbHVVR1ZTWldkcGMzUnllUzUxY0dSaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVTZDaUFnSUNBdkx5QnpjbU12UTJoaGFXNVFaVkpsWjJsemRISjVMbUZzWjI4dWRITTZNVEk0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh5SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ053b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEZ0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUhOeVl5OURhR0ZwYmxCbFVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE5EQUtJQ0FnSUM4dklIUm9hWE11ZG1WeWFXWjVVR0Y1YldWdWRDaHdZWGxVZUNrN0NpQWdJQ0IxYm1OdmRtVnlJREUxQ2lBZ0lDQmpZV3hzYzNWaUlIWmxjbWxtZVZCaGVXMWxiblFLSUNBZ0lDOHZJSE55WXk5RGFHRnBibEJsVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TkRJS0lDQWdJQzh2SUdOdmJuTjBJR0p2ZUV0bGVTQTlJSFJvYVhNdWJXRnJaVXRsZVNodVlXMWxLVHNLSUNBZ0lHUnBaeUF4TkFvZ0lDQWdZMkZzYkhOMVlpQnRZV3RsUzJWNUNpQWdJQ0F2THlCemNtTXZRMmhoYVc1UVpWSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk5qVUtJQ0FnSUM4dklITmxjblpwWTJWeklEMGdRbTk0VFdGd1BHSjVkR1Z6TENCVFpYSjJhV05sUkdGMFlUNG9leUJyWlhsUWNtVm1hWGc2SUNKemRtTTZJaUI5S1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMll6b2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE55WXk5RGFHRnBibEJsVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TkRNS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuTmxjblpwWTJWektHSnZlRXRsZVNrdVpYaHBjM1J6TENBaVUyVnlkbWxqWlNCdWIzUWdabTkxYm1RN0lIVnpaU0J5WldkcGMzUmxjaWdwSUdacGNuTjBJaWs3Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUZObGNuWnBZMlVnYm05MElHWnZkVzVrT3lCMWMyVWdjbVZuYVhOMFpYSW9LU0JtYVhKemRBb2dJQ0FnTHk4Z2MzSmpMME5vWVdsdVVHVlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRTBOUzB4TkRZS0lDQWdJQzh2SUdOdmJuTjBJR1Y0YVhOMGFXNW5JRDBnWTJ4dmJtVW9kR2hwY3k1elpYSjJhV05sY3loaWIzaExaWGtwTG5aaGJIVmxLVHNLSUNBZ0lDOHZJR0Z6YzJWeWRDaGxlR2x6ZEdsdVp5NWtaWFpsYkc5d1pYSXVibUYwYVhabElEMDlQU0JVZUc0dWMyVnVaR1Z5TENBaVQyNXNlU0IwYUdVZ2IzSnBaMmx1WVd3Z1pHVjJaV3h2Y0dWeUlHTmhiaUIxY0dSaGRHVWlLVHNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE5pQXZMeUF4TmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ0x5OGdjM0pqTDBOb1lXbHVVR1ZTWldkcGMzUnllUzVoYkdkdkxuUnpPakUwTmdvZ0lDQWdMeThnWVhOelpYSjBLR1Y0YVhOMGFXNW5MbVJsZG1Wc2IzQmxjaTV1WVhScGRtVWdQVDA5SUZSNGJpNXpaVzVrWlhJc0lDSlBibXg1SUhSb1pTQnZjbWxuYVc1aGJDQmtaWFpsYkc5d1pYSWdZMkZ1SUhWd1pHRjBaU0lwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dkR2hsSUc5eWFXZHBibUZzSUdSbGRtVnNiM0JsY2lCallXNGdkWEJrWVhSbENpQWdJQ0F2THlCemNtTXZRMmhoYVc1UVpWSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UUTRDaUFnSUNBdkx5QmpiMjV6ZENCdWIzY2dQU0JIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd093b2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnTHk4Z2MzSmpMME5vWVdsdVVHVlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRTJNQW9nSUNBZ0x5OGdZM0psWVhSbFpFRjBPaUJsZUdsemRHbHVaeTVqY21WaGRHVmtRWFFzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRITWdORGdnT0NBdkx5QTBPQ3dnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE55WXk5RGFHRnBibEJsVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TmpFS0lDQWdJQzh2SUhWd1pHRjBaV1JCZERvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0c1dmR5a3NDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpjbU12UTJoaGFXNVFaVkpsWjJsemRISjVMbUZzWjI4dWRITTZNVFV3TFRFMk1nb2dJQ0FnTHk4Z2RHaHBjeTV6WlhKMmFXTmxjeWhpYjNoTFpYa3BMblpoYkhWbElEMGdibVYzSUZObGNuWnBZMlZFWVhSaEtIc0tJQ0FnSUM4dklDQWdibUZ0WlRvZ2JtRnRaU3dLSUNBZ0lDOHZJQ0FnWkdWelkzSnBjSFJwYjI0NklHUmxjMk55YVhCMGFXOXVMQW9nSUNBZ0x5OGdJQ0IwWVdkek9pQjBZV2R6TEFvZ0lDQWdMeThnSUNCbGJtUndiMmx1ZERvZ1pXNWtjRzlwYm5Rc0NpQWdJQ0F2THlBZ0lIQnlhV05sVUdWeVVtVnhkV1Z6ZERvZ2NISnBZMlZRWlhKU1pYRjFaWE4wTEFvZ0lDQWdMeThnSUNCd1lYbHRaVzUwVkc5clpXNDZJSEJoZVcxbGJuUlViMnRsYml3S0lDQWdJQzh2SUNBZ2QyRnNiR1YwUVdSa2NtVnpjem9nZDJGc2JHVjBRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdibVYwZDI5eWF6b2dibVYwZDI5eWF5d0tJQ0FnSUM4dklDQWdaR1YyWld4dmNHVnlPaUJsZUdsemRHbHVaeTVrWlhabGJHOXdaWElzQ2lBZ0lDQXZMeUFnSUdOeVpXRjBaV1JCZERvZ1pYaHBjM1JwYm1jdVkzSmxZWFJsWkVGMExBb2dJQ0FnTHk4Z0lDQjFjR1JoZEdWa1FYUTZJRzVsZHlCaGNtTTBMbFZwYm5RMk5DaHViM2NwTEFvZ0lDQWdMeThnZlNrN0NpQWdJQ0J3ZFhOb2FXNTBJRFkwSUM4dklEWTBDaUFnSUNCMWJtTnZkbVZ5SURFNENpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREEwTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJREUzQ2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXhOUW9nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01UTUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURFeENpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUE1Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6Y21NdlEyaGhhVzVRWlZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRJNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemNtTXZRMmhoYVc1UVpWSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk9rTm9ZV2x1VUdWU1pXZHBjM1J5ZVM1a1pYSmxaMmx6ZEdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1Z5WldkcGMzUmxjam9LSUNBZ0lDOHZJSE55WXk5RGFHRnBibEJsVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TnpNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzNKakwwTm9ZV2x1VUdWU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFM05Rb2dJQ0FnTHk4Z1kyOXVjM1FnWW05NFMyVjVJRDBnZEdocGN5NXRZV3RsUzJWNUtHNWhiV1VwT3dvZ0lDQWdZMkZzYkhOMVlpQnRZV3RsUzJWNUNpQWdJQ0F2THlCemNtTXZRMmhoYVc1UVpWSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk5qVUtJQ0FnSUM4dklITmxjblpwWTJWeklEMGdRbTk0VFdGd1BHSjVkR1Z6TENCVFpYSjJhV05sUkdGMFlUNG9leUJyWlhsUWNtVm1hWGc2SUNKemRtTTZJaUI5S1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMll6b2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE55WXk5RGFHRnBibEJsVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94TnpZS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuTmxjblpwWTJWektHSnZlRXRsZVNrdVpYaHBjM1J6TENBaVUyVnlkbWxqWlNCdWIzUWdabTkxYm1RaUtUc0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdVMlZ5ZG1salpTQnViM1FnWm05MWJtUUtJQ0FnSUM4dklITnlZeTlEYUdGcGJsQmxVbVZuYVhOMGNua3VZV3huYnk1MGN6b3hOemd0TVRjNUNpQWdJQ0F2THlCamIyNXpkQ0JsZUdsemRHbHVaeUE5SUdOc2IyNWxLSFJvYVhNdWMyVnlkbWxqWlhNb1ltOTRTMlY1S1M1MllXeDFaU2s3Q2lBZ0lDQXZMeUJoYzNObGNuUW9aWGhwYzNScGJtY3VaR1YyWld4dmNHVnlMbTVoZEdsMlpTQTlQVDBnVkhodUxuTmxibVJsY2l3Z0lrOXViSGtnZEdobElHOXlhV2RwYm1Gc0lHUmxkbVZzYjNCbGNpQmpZVzRnWkdWeVpXZHBjM1JsY2lJcE93b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREUySUM4dklERTJDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemNtTXZRMmhoYVc1UVpWSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1UYzVDaUFnSUNBdkx5QmhjM05sY25Rb1pYaHBjM1JwYm1jdVpHVjJaV3h2Y0dWeUxtNWhkR2wyWlNBOVBUMGdWSGh1TG5ObGJtUmxjaXdnSWs5dWJIa2dkR2hsSUc5eWFXZHBibUZzSUdSbGRtVnNiM0JsY2lCallXNGdaR1Z5WldkcGMzUmxjaUlwT3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSFJvWlNCdmNtbG5hVzVoYkNCa1pYWmxiRzl3WlhJZ1kyRnVJR1JsY21WbmFYTjBaWElLSUNBZ0lDOHZJSE55WXk5RGFHRnBibEJsVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94T0RFS0lDQWdJQzh2SUhSb2FYTXVjMlZ5ZG1salpYTW9ZbTk0UzJWNUtTNWtaV3hsZEdVb0tUc0tJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjM0pqTDBOb1lXbHVVR1ZTWldkcGMzUnllUzVoYkdkdkxuUnpPakU0TkFvZ0lDQWdMeThnWTI5dWMzUWdZbUZzWVc1alpTQTlJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxtSmhiR0Z1WTJVN0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSQ1lXeGhibU5sQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNBdkx5QnpjbU12UTJoaGFXNVFaVkpsWjJsemRISjVMbUZzWjI4dWRITTZNVGcxQ2lBZ0lDQXZMeUJqYjI1emRDQnRhVzVDWVd3Z1BTQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3k1dGFXNUNZV3hoYm1ObE93b2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFRXbHVRbUZzWVc1alpRb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJQzh2SUhOeVl5OURhR0ZwYmxCbFVtVm5hWE4wY25rdVlXeG5ieTUwY3pveE9EWUtJQ0FnSUM4dklHbG1JQ2hpWVd4aGJtTmxJRDRnYldsdVFtRnNLU0I3Q2lBZ0lDQStDaUFnSUNCaWVpQmtaWEpsWjJsemRHVnlYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z2MzSmpMME5vWVdsdVVHVlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRTROeTB4T1RNS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dZbUZzWVc1alpTQXRJRzFwYmtKaGJDd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1RzS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE55WXk5RGFHRnBibEJsVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem94T0RrS0lDQWdJQzh2SUhKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzNKakwwTm9ZV2x1VUdWU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFNU1Bb2dJQ0FnTHk4Z1lXMXZkVzUwT2lCaVlXeGhibU5sSUMwZ2JXbHVRbUZzTEFvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeUNpQWdJQ0F0Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzNKakwwTm9ZV2x1VUdWU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFNE55MHhPVElLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ1ltRnNZVzVqWlNBdElHMXBia0poYkN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzNKakwwTm9ZV2x1VUdWU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFNU1Rb2dJQ0FnTHk4Z1ptVmxPaUF3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6Y21NdlEyaGhhVzVRWlZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRnM0xURTVNd29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCaVlXeGhibU5sSUMwZ2JXbHVRbUZzTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BPd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtDbVJsY21WbmFYTjBaWEpmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjM0pqTDBOb1lXbHVVR1ZTWldkcGMzUnllUzVoYkdkdkxuUnpPakUzTXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzNKakwwTm9ZV2x1VUdWU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pwRGFHRnBibEJsVW1WbmFYTjBjbmt1WjJWMFUyVnlkbWxqWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRk5sY25acFkyVTZDaUFnSUNBdkx5QnpjbU12UTJoaGFXNVFaVkpsWjJsemRISjVMbUZzWjI4dWRITTZNakEyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjM0pqTDBOb1lXbHVVR1ZTWldkcGMzUnllUzVoYkdkdkxuUnpPakkxTkFvZ0lDQWdMeThnY21WMGRYSnVJR1JsZG1Wc2IzQmxjaTV1WVhScGRtVXVZbmwwWlhNdVkyOXVZMkYwS0NJNklpa3VZMjl1WTJGMEtHNWhiV1V1Ym1GMGFYWmxLVHNLSUNBZ0lITjNZWEFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJam9pQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOeVl5OURhR0ZwYmxCbFVtVm5hWE4wY25rdVlXeG5ieTUwY3pvMk5Rb2dJQ0FnTHk4Z2MyVnlkbWxqWlhNZ1BTQkNiM2hOWVhBOFlubDBaWE1zSUZObGNuWnBZMlZFWVhSaFBpaDdJR3RsZVZCeVpXWnBlRG9nSW5OMll6b2lJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNaak9pSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjM0pqTDBOb1lXbHVVR1ZTWldkcGMzUnllUzVoYkdkdkxuUnpPakl3T1FvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWMyVnlkbWxqWlhNb1ltOTRTMlY1S1M1bGVHbHpkSE1zSUNKVFpYSjJhV05sSUc1dmRDQm1iM1Z1WkNJcE93b2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRaWEoyYVdObElHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z2MzSmpMME5vWVdsdVVHVlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qSXhNQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11YzJWeWRtbGpaWE1vWW05NFMyVjVLUzUyWVd4MVpUc0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjM0pqTDBOb1lXbHVVR1ZTWldkcGMzUnllUzVoYkdkdkxuUnpPakl3TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzNKakwwTm9ZV2x1VUdWU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pwRGFHRnBibEJsVW1WbmFYTjBjbmt1YUdGelUyVnlkbWxqWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtaGhjMU5sY25acFkyVTZDaUFnSUNBdkx5QnpjbU12UTJoaGFXNVFaVkpsWjJsemRISjVMbUZzWjI4dWRITTZNakUyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjM0pqTDBOb1lXbHVVR1ZTWldkcGMzUnllUzVoYkdkdkxuUnpPakkxTkFvZ0lDQWdMeThnY21WMGRYSnVJR1JsZG1Wc2IzQmxjaTV1WVhScGRtVXVZbmwwWlhNdVkyOXVZMkYwS0NJNklpa3VZMjl1WTJGMEtHNWhiV1V1Ym1GMGFYWmxLVHNLSUNBZ0lITjNZWEFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJam9pQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOeVl5OURhR0ZwYmxCbFVtVm5hWE4wY25rdVlXeG5ieTUwY3pvMk5Rb2dJQ0FnTHk4Z2MyVnlkbWxqWlhNZ1BTQkNiM2hOWVhBOFlubDBaWE1zSUZObGNuWnBZMlZFWVhSaFBpaDdJR3RsZVZCeVpXWnBlRG9nSW5OMll6b2lJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNaak9pSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjM0pqTDBOb1lXbHVVR1ZTWldkcGMzUnllUzVoYkdkdkxuUnpPakl4T1FvZ0lDQWdMeThnY21WMGRYSnVJRzVsZHlCaGNtTTBMa0p2YjJ3b2RHaHBjeTV6WlhKMmFXTmxjeWhpYjNoTFpYa3BMbVY0YVhOMGN5azdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lDOHZJSE55WXk5RGFHRnBibEJsVW1WbmFYTjBjbmt1WVd4bmJ5NTBjem95TVRZS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOeVl5OURhR0ZwYmxCbFVtVm5hWE4wY25rdVlXeG5ieTUwY3pvNlEyaGhhVzVRWlZKbFoybHpkSEo1TG0xaGEyVkxaWGtvYm1GdFpUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncHRZV3RsUzJWNU9nb2dJQ0FnTHk4Z2MzSmpMME5vWVdsdVVHVlNaV2RwYzNSeWVTNWhiR2R2TG5Sek9qSTBOZ29nSUNBZ0x5OGdjSEpwZG1GMFpTQnRZV3RsUzJWNUtHNWhiV1U2SUdGeVl6UXVVM1J5S1RvZ1lubDBaWE1nZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpjbU12UTJoaGFXNVFaVkpsWjJsemRISjVMbUZzWjI4dWRITTZNalEzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdWSGh1TG5ObGJtUmxjaTVpZVhSbGN5NWpiMjVqWVhRb0lqb2lLUzVqYjI1allYUW9ibUZ0WlM1dVlYUnBkbVVwT3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV05mTVNBdkx5QWlPaUlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6Y21NdlEyaGhhVzVRWlZKbFoybHpkSEo1TG1Gc1oyOHVkSE02T2tOb1lXbHVVR1ZTWldkcGMzUnllUzUyWlhKcFpubFFZWGx0Wlc1MEtIQmhlVlI0T2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q25abGNtbG1lVkJoZVcxbGJuUTZDaUFnSUNBdkx5QnpjbU12UTJoaGFXNVFaVkpsWjJsemRISjVMbUZzWjI4dWRITTZNall3Q2lBZ0lDQXZMeUJ3Y21sMllYUmxJSFpsY21sbWVWQmhlVzFsYm5Rb2NHRjVWSGc2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaWs2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemNtTXZRMmhoYVc1UVpWSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qWXhMVEkyT1FvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb0NpQWdJQ0F2THlBZ0lIQmhlVlI0TEFvZ0lDQWdMeThnSUNCN0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0VGRVRVbE9YMEZFUkZKRlUxTXBMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJSHNnWjNKbFlYUmxjbFJvWVc1RmNUb2dVa1ZIU1ZOVVVrRlVTVTlPWDBaRlJTQjlMQW9nSUNBZ0x5OGdJQ0I5TEFvZ0lDQWdMeThnSUNBaVVHRjViV1Z1ZENCdGRYTjBJR0psSUQ0OUlERWdRVXhIVHlCbWNtOXRJSE5sYm1SbGNpQjBieUJoWkcxcGJpQjNZV3hzWlhRaUNpQWdJQ0F2THlBcE93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJQzh2SUhOeVl5OURhR0ZwYmxCbFVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU5qUUtJQ0FnSUM4dklITmxibVJsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOeVl5OURhR0ZwYmxCbFVtVm5hWE4wY25rdVlXeG5ieTUwY3pveU5qRXRNalk1Q2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNnS0lDQWdJQzh2SUNBZ2NHRjVWSGdzQ2lBZ0lDQXZMeUFnSUhzS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vUVVSTlNVNWZRVVJFVWtWVFV5a3VibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dleUJuY21WaGRHVnlWR2hoYmtWeE9pQlNSVWRKVTFSU1FWUkpUMDVmUmtWRklIMHNDaUFnSUNBdkx5QWdJSDBzQ2lBZ0lDQXZMeUFnSUNKUVlYbHRaVzUwSUcxMWMzUWdZbVVnUGowZ01TQkJURWRQSUdaeWIyMGdjMlZ1WkdWeUlIUnZJR0ZrYldsdUlIZGhiR3hsZENJS0lDQWdJQzh2SUNrN0NpQWdJQ0E5UFFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzNKakwwTm9ZV2x1VUdWU1pXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJMk5Rb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJNklHNWxkeUJoY21NMExrRmtaSEpsYzNNb1FVUk5TVTVmUVVSRVVrVlRVeWt1Ym1GMGFYWmxMQW9nSUNBZ2NIVnphR0o1ZEdWeklHSmhjMlV6TWloRFNWRmFVRFpKTnpOUk5UVXlOMUZYV2toYVRGcENTVVJUVDBoV1ZqVk1UVkExU1VWUlRsRlpWbEpZV1U5YVZGRlRXVUpSS1NBdkx5QmhaR1J5SUVOSlVWcFFOa2szTTFFMU5USTNVVmRhU0ZwTVdrSkpSRk5QU0ZaV05VeE5VRFZKUlZGT1VWbFdVbGhaVDFwVVVWTlpRamRZTlRkUVFrVUtJQ0FnSUM4dklITnlZeTlEYUdGcGJsQmxVbVZuYVhOMGNua3VZV3huYnk1MGN6b3lOakV0TWpZNUNpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDZ0tJQ0FnSUM4dklDQWdjR0Y1Vkhnc0NpQWdJQ0F2THlBZ0lIc0tJQ0FnSUM4dklDQWdJQ0J6Wlc1a1pYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklHNWxkeUJoY21NMExrRmtaSEpsYzNNb1FVUk5TVTVmUVVSRVVrVlRVeWt1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nZXlCbmNtVmhkR1Z5VkdoaGJrVnhPaUJTUlVkSlUxUlNRVlJKVDA1ZlJrVkZJSDBzQ2lBZ0lDQXZMeUFnSUgwc0NpQWdJQ0F2THlBZ0lDSlFZWGx0Wlc1MElHMTFjM1FnWW1VZ1BqMGdNU0JCVEVkUElHWnliMjBnYzJWdVpHVnlJSFJ2SUdGa2JXbHVJSGRoYkd4bGRDSUtJQ0FnSUM4dklDazdDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQXZMeUJ6Y21NdlEyaGhhVzVRWlZKbFoybHpkSEo1TG1Gc1oyOHVkSE02TWpZMkNpQWdJQ0F2THlCaGJXOTFiblE2SUhzZ1ozSmxZWFJsY2xSb1lXNUZjVG9nVWtWSFNWTlVVa0ZVU1U5T1gwWkZSU0I5TEFvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3TURBd0lDOHZJREV3TURBd01EQUtJQ0FnSUM4dklITnlZeTlEYUdGcGJsQmxVbVZuYVhOMGNua3VZV3huYnk1MGN6b3lOakV0TWpZNUNpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDZ0tJQ0FnSUM4dklDQWdjR0Y1Vkhnc0NpQWdJQ0F2THlBZ0lIc0tJQ0FnSUM4dklDQWdJQ0J6Wlc1a1pYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklHNWxkeUJoY21NMExrRmtaSEpsYzNNb1FVUk5TVTVmUVVSRVVrVlRVeWt1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nZXlCbmNtVmhkR1Z5VkdoaGJrVnhPaUJTUlVkSlUxUlNRVlJKVDA1ZlJrVkZJSDBzQ2lBZ0lDQXZMeUFnSUgwc0NpQWdJQ0F2THlBZ0lDSlFZWGx0Wlc1MElHMTFjM1FnWW1VZ1BqMGdNU0JCVEVkUElHWnliMjBnYzJWdVpHVnlJSFJ2SUdGa2JXbHVJSGRoYkd4bGRDSUtJQ0FnSUM4dklDazdDaUFnSUNBK1BRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsdFpXNTBJRzExYzNRZ1ltVWdQajBnTVNCQlRFZFBJR1p5YjIwZ2MyVnVaR1Z5SUhSdklHRmtiV2x1SUhkaGJHeGxkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBSUJJQ1lFQkhOMll6b0JPZ0lBUUFRVkgzeDFNUmtVUkRFWVFRQ1BnZ2NFMFBVelNnU2g3NDJhQkk1TnVMZ0VDbmh4L1FRSkRCQzlCSWxRWDZnRTJjNnpZVFlhQUk0SEFHY0JoQUt3QXdBRExRQVNBQUVBZ0F3VkgzeDFBQUFBQUFBUFFrQ3dKRU9BUUJVZmZIVUFPa05KVVZwUU5razNNMUUxTlRJM1VWZGFTRnBNV2tKSlJGTlBTRlpXTlV4TlVEVkpSVkZPVVZsV1VsaFpUMXBVVVZOWlFqZFlOVGRRUWtXd0pFT0FCTGhFZXpZMkdnQ09BUUFCQUNSRE1SWWtDVWs0RUNRU1JEWWFBVWtpV1NNSVN3RVZTVThDRWtRMkdnSkpJbGtqQ0VzQkZVbFBBaEpFTmhvRFNTSlpJd2hMQVJWSlR3SVNSRFlhQkVraVdTTUlTd0VWU1U4Q0VrUTJHZ1ZKSWxrakNFc0JGVWxQQWhKRU5ob0dTU0paSXdoTEFSVkpUd0lTUkRZYUIwa2lXU01JU3dFVlNVOENFa1EyR2doSklsa2pDRXNCRlJKRVR3K0lBbmhMRG9nQ1pTaE1VRW05UlFFVVJERUFNZ2NXZ1VCUEVRaEpGbGNHQWlwTVVFeFBFQWhKRmxjR0FrOENURkJNVHc0SVNSWlhCZ0pQQWt4UVRFOE1DRWtXVndZQ1R3Sk1VRXhQQ2doSkZsY0dBazhDVEZCTVR3Z0lTUlpYQmdKUEFreFFURThHQ0JaWEJnSlFUd0pRU3dGUVRGQlBDVkJQQ0ZCUEIxQlBCbEJQQlZCUEJGQlBBMUJQQWxCTEFieEl2eVJETVJZa0NVazRFQ1FTUkRZYUFVa2lXU01JU3dFVlNVOENFa1EyR2dKSklsa2pDRXNCRlVsUEFoSkVOaG9EU1NKWkl3aExBUlZKVHdJU1JEWWFCRWtpV1NNSVN3RVZTVThDRWtRMkdnVkpJbGtqQ0VzQkZVbFBBaEpFTmhvR1NTSlpJd2hMQVJWSlR3SVNSRFlhQjBraVdTTUlTd0VWU1U4Q0VrUTJHZ2hKSWxrakNFc0JGUkpFVHcrSUFWdExEb2dCU0NoTVVFbTlSUUZFU1lFUUpicEpNUUFTUkRJSFN3S0RBakFJdWt3V2dVQlBFZ2hKRmxjR0FpcE1VRXhQRVFoSkZsY0dBazhDVEZCTVR3OElTUlpYQmdKUEFreFFURThOQ0VrV1Z3WUNUd0pNVUV4UEN3aEpGbGNHQWs4Q1RGQk1Ud2tJU1JaWEJnSlBBa3hRVEU4SENCWlhCZ0pRVHdOUVR3SlFURkJQQ1ZCUENGQlBCMUJQQmxCUEJWQlBCRkJQQTFCUEFsQkxBYnhJdnlSRE5ob0JTU0paSXdoTEFSVVNSSWdBblNoTVVFbTlSUUZFU1lFUUpib3hBQkpFdkVneUNuTUFURWxQQWtReUNuTUJURWxPQWs0RFJBMUJBQk94TVFCTEFrc0NDYklJc2dja3NoQWlzZ0d6SkVNMkdnRkpGU1VTUkRZYUFra2lXU01JU3dFVkVrUk1LVkJNVndJQVVDaE1VRW05UlFGRXZrZ3JURkN3SkVNMkdnRkpGU1VTUkRZYUFra2lXU01JU3dFVkVrUk1LVkJNVndJQVVDaE1VTDFGQVlBQkFDSlBBbFFyVEZDd0pFT0tBUUV4QUNsUWkvOVhBZ0JRaVlvQkFJdi9PQUF4QUJLTC96Z0hnQ0FTSVpmNUg5dzczWDRXeWZLOGhRT1RqMXIxYkg5UVNEWVlyRytIWm5DV0F4SVFpLzg0Q0lIQWhEMFBFRVNKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
