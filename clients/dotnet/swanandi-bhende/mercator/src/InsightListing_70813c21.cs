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

namespace Arc56.Generated.swanandi_bhende.mercator.InsightListing_70813c21
{


    //
    // On-chain listing registry for trading insights.
    //    
    //    State:
    //        registry_app_id: Global reference to AgentRegistry app (UInt64).
    //        next_listing_id: Global counter allocating unique listing IDs (UInt64).
    //        listings: BoxMap(listing_id => Listing), storing all current listings.
    //    
    //    Purpose: Seller-facing contract for publishing insights + buyer-facing registry for discovery.
    //    
    //
    public class InsightListingProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public InsightListingProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Listing : AVMObjectType
            {
                public ulong Price { get; set; }

                public Algorand.Address Seller { get; set; }

                public string IpfsHash { get; set; }

                public ulong AsaId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrice.From(Price);
                    ret.AddRange(vPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSeller.From(Seller);
                    ret.AddRange(vSeller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpfsHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vIpfsHash.From(IpfsHash);
                    stringRef[ret.Count] = vIpfsHash.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsaId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsaId.From(AsaId);
                    ret.AddRange(vAsaId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Listing Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Listing();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrice = vPrice.ToValue();
                    if (valuePrice is ulong vPriceValue) { ret.Price = vPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSeller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSeller = vSeller.ToValue();
                    if (valueSeller is Algorand.Address vSellerValue) { ret.Seller = vSellerValue; }
                    var indexIpfsHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpfsHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vIpfsHash.Decode(bytes.Skip(indexIpfsHash + prefixOffset).ToArray());
                    var valueIpfsHash = vIpfsHash.ToValue();
                    if (valueIpfsHash is string vIpfsHashValue) { ret.IpfsHash = vIpfsHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsaId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsaId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsaId = vAsaId.ToValue();
                    if (valueAsaId is ulong vAsaIdValue) { ret.AsaId = vAsaIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Listing);
                }
                public bool Equals(Listing? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Listing left, Listing right)
                {
                    return EqualityComparer<Listing>.Default.Equals(left, right);
                }
                public static bool operator !=(Listing left, Listing right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Publish a new trading insight and receive seller ASA for proof-of-ownership.
        ///Purpose: Allocate unique listing ID and link IPFS content permanently on-chain.
        ///Actions: 1. Verify seller is registered in AgentRegistry before proceeding (cross-contract call). 2. Increment next_listing_id counter → allocate new listing ID. 3. Call itxn.AssetConfig to mint one ASA with:    - INSIGHT token name, Mercator Insight asset name, IpfsHash as URL.    - Seller as manager + reserve + freeze + clawback (seller controls proof token).    - Fee=1000 micro-Algo. 4. Store Listing struct in boxes: {price, seller, ipfs_hash, asa_id}. 5. Increment counter for next invocation. 6. Call AgentRegistry.increment_transaction_count to record seller activity. 7. Return listing_id to caller (frontend caches this).
        ///Args:     price: Settlement amount (micro-USDC). e.g., 5_000_000 = 5 USDC.     seller: Seller's Algorand wallet (58-char checksummed address).     ipfs_hash: Content CID (e.g., "Qm...") pinned on Pinata.
        ///Returns:     listing_id: Unique identifier (used in /discover results, x402 payment, escrow).
        ///Raises:     AssertionError if seller is not registered in AgentRegistry.
        ///</summary>
        /// <param name="price"> </param>
        /// <param name="seller"> </param>
        /// <param name="ipfs_hash"> </param>
        public async Task<ulong> CreateListing(ulong price, Algorand.Address seller, string ipfs_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 184, 54, 214 };
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var ipfs_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_hashAbi.From(ipfs_hash);

            var result = await base.CallApp(new List<object> { abiHandle, priceAbi, sellerAbi, ipfs_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateListing_Transactions(ulong price, Algorand.Address seller, string ipfs_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 184, 54, 214 };
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var ipfs_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_hashAbi.From(ipfs_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, priceAbi, sellerAbi, ipfs_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSW5zaWdodExpc3RpbmciLCJkZXNjIjoiT24tY2hhaW4gbGlzdGluZyByZWdpc3RyeSBmb3IgdHJhZGluZyBpbnNpZ2h0cy5cbiAgICBcbiAgICBTdGF0ZTpcbiAgICAgICAgcmVnaXN0cnlfYXBwX2lkOiBHbG9iYWwgcmVmZXJlbmNlIHRvIEFnZW50UmVnaXN0cnkgYXBwIChVSW50NjQpLlxuICAgICAgICBuZXh0X2xpc3RpbmdfaWQ6IEdsb2JhbCBjb3VudGVyIGFsbG9jYXRpbmcgdW5pcXVlIGxpc3RpbmcgSURzIChVSW50NjQpLlxuICAgICAgICBsaXN0aW5nczogQm94TWFwKGxpc3RpbmdfaWQgPT4gTGlzdGluZyksIHN0b3JpbmcgYWxsIGN1cnJlbnQgbGlzdGluZ3MuXG4gICAgXG4gICAgUHVycG9zZTogU2VsbGVyLWZhY2luZyBjb250cmFjdCBmb3IgcHVibGlzaGluZyBpbnNpZ2h0cyArIGJ1eWVyLWZhY2luZyByZWdpc3RyeSBmb3IgZGlzY292ZXJ5LlxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJMaXN0aW5nIjpbeyJuYW1lIjoicHJpY2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic2VsbGVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJpcGZzX2hhc2giLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYXNhX2lkIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfbGlzdGluZyIsImRlc2MiOiJQdWJsaXNoIGEgbmV3IHRyYWRpbmcgaW5zaWdodCBhbmQgcmVjZWl2ZSBzZWxsZXIgQVNBIGZvciBwcm9vZi1vZi1vd25lcnNoaXAuXG5QdXJwb3NlOiBBbGxvY2F0ZSB1bmlxdWUgbGlzdGluZyBJRCBhbmQgbGluayBJUEZTIGNvbnRlbnQgcGVybWFuZW50bHkgb24tY2hhaW4uXG5BY3Rpb25zOiAxLiBWZXJpZnkgc2VsbGVyIGlzIHJlZ2lzdGVyZWQgaW4gQWdlbnRSZWdpc3RyeSBiZWZvcmUgcHJvY2VlZGluZyAoY3Jvc3MtY29udHJhY3QgY2FsbCkuIDIuIEluY3JlbWVudCBuZXh0X2xpc3RpbmdfaWQgY291bnRlciDihpIgYWxsb2NhdGUgbmV3IGxpc3RpbmcgSUQuIDMuIENhbGwgaXR4bi5Bc3NldENvbmZpZyB0byBtaW50IG9uZSBBU0Egd2l0aDogICAgLSBJTlNJR0hUIHRva2VuIG5hbWUsIE1lcmNhdG9yIEluc2lnaHQgYXNzZXQgbmFtZSwgSXBmc0hhc2ggYXMgVVJMLiAgICAtIFNlbGxlciBhcyBtYW5hZ2VyICsgcmVzZXJ2ZSArIGZyZWV6ZSArIGNsYXdiYWNrIChzZWxsZXIgY29udHJvbHMgcHJvb2YgdG9rZW4pLiAgICAtIEZlZT0xMDAwIG1pY3JvLUFsZ28uIDQuIFN0b3JlIExpc3Rpbmcgc3RydWN0IGluIGJveGVzOiB7cHJpY2UsIHNlbGxlciwgaXBmc19oYXNoLCBhc2FfaWR9LiA1LiBJbmNyZW1lbnQgY291bnRlciBmb3IgbmV4dCBpbnZvY2F0aW9uLiA2LiBDYWxsIEFnZW50UmVnaXN0cnkuaW5jcmVtZW50X3RyYW5zYWN0aW9uX2NvdW50IHRvIHJlY29yZCBzZWxsZXIgYWN0aXZpdHkuIDcuIFJldHVybiBsaXN0aW5nX2lkIHRvIGNhbGxlciAoZnJvbnRlbmQgY2FjaGVzIHRoaXMpLlxuQXJnczogICAgIHByaWNlOiBTZXR0bGVtZW50IGFtb3VudCAobWljcm8tVVNEQykuIGUuZy4sIDVfMDAwXzAwMCA9IDUgVVNEQy4gICAgIHNlbGxlcjogU2VsbGVyJ3MgQWxnb3JhbmQgd2FsbGV0ICg1OC1jaGFyIGNoZWNrc3VtbWVkIGFkZHJlc3MpLiAgICAgaXBmc19oYXNoOiBDb250ZW50IENJRCAoZS5nLiwgXCJRbS4uLlwiKSBwaW5uZWQgb24gUGluYXRhLlxuUmV0dXJuczogICAgIGxpc3RpbmdfaWQ6IFVuaXF1ZSBpZGVudGlmaWVyICh1c2VkIGluIC9kaXNjb3ZlciByZXN1bHRzLCB4NDAyIHBheW1lbnQsIGVzY3JvdykuXG5SYWlzZXM6ICAgICBBc3NlcnRpb25FcnJvciBpZiBzZWxsZXIgaXMgbm90IHJlZ2lzdGVyZWQgaW4gQWdlbnRSZWdpc3RyeS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxsZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlwZnNfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTY4XSwiZXJyb3JNZXNzYWdlIjoiVW5yZWdpc3RlcmVkIGFnZW50IOKAlCBjYWxsIEFnZW50UmVnaXN0cnkucmVnaXN0ZXIoKSBmaXJzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NV0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGxvZyB2YWx1ZSBpcyBub3QgdGhlIHJlc3VsdCBvZiBhbiBBQkkgcmV0dXJuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5uZXh0X2xpc3RpbmdfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE2LDEyNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucmVnaXN0cnlfYXBwX2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFS0lDQWdJR0o1ZEdWallteHZZMnNnSW5KbFoybHpkSEo1WDJGd2NGOXBaQ0lnTUhneE5URm1OMk0zTlNBaWJtVjRkRjlzYVhOMGFXNW5YMmxrSWdvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YVc1emFXZG9kRjlzYVhOMGFXNW5MM050WVhKMFgyTnZiblJ5WVdOMGN5OXBibk5wWjJoMFgyeHBjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNemNLSUNBZ0lDOHZJR05zWVhOeklFbHVjMmxuYUhSTWFYTjBhVzVuS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUEzQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd6TldJNE16WmtOaUF2THlCdFpYUm9iMlFnSW1OeVpXRjBaVjlzYVhOMGFXNW5LSFZwYm5RMk5DeGhaR1J5WlhOekxITjBjbWx1WnlsMWFXNTBOalFpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMk55WldGMFpWOXNhWE4wYVc1blgzSnZkWFJsUURVS0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZiR2x6ZEdsdVoxOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmFXNXphV2RvZEY5c2FYTjBhVzVuTDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OcFoyaDBYMnhwYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlRZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCamNtVmhkR1ZmYkdsemRHbHVad29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBM09nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YVc1emFXZG9kRjlzYVhOMGFXNW5MbU52Ym5SeVlXTjBMa2x1YzJsbmFIUk1hWE4wYVc1bkxtTnlaV0YwWlY5c2FYTjBhVzVuVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDJ4cGMzUnBibWM2Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTlwYm5OcFoyaDBYMnhwYzNScGJtY3ZjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjMmxuYUhSZmJHbHpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzFOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTlwYm5OcFoyaDBYMnhwYzNScGJtY3ZjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjMmxuYUhSZmJHbHpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzVNQzA1TWdvZ0lDQWdMeThnSXlCRGFHVmpheUJ6Wld4c1pYSWdhWE1nY21WbmFYTjBaWEpsWkNCcGJpQkJaMlZ1ZEZKbFoybHpkSEo1SUdKbFptOXlaU0J3Y205alpXVmthVzVuSUNodGRYTjBJR0psSUdacGNuTjBJSE4wWVhSbGJXVnVkQ2tLSUNBZ0lDOHZJQ01nVkdocGN5QnBjeUJoSUdKbGMzUXRaV1ptYjNKMElHTnliM056TFdOdmJuUnlZV04wSUdOaGJHdzdJR2xtSUhKbFoybHpkSEo1WDJGd2NGOXBaQ0JwY3lCdWIzUWdjMlYwTENCemEybHdJSFJvWlNCamFHVmphd29nSUNBZ0x5OGdhV1lnYzJWc1ppNXlaV2RwYzNSeWVWOWhjSEJmYVdRdWRtRnNkV1VnSVQwZ1ZVbHVkRFkwS0RBcE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5KbFoybHpkSEo1WDJGd2NGOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVpXZHBjM1J5ZVY5aGNIQmZhV1FnWlhocGMzUnpDaUFnSUNCaWVpQmpjbVZoZEdWZmJHbHpkR2x1WjE5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMmx1YzJsbmFIUmZiR2x6ZEdsdVp5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXphV2RvZEY5c2FYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qa3pMVGszQ2lBZ0lDQXZMeUJwYzE5eVpXZHBjM1JsY21Wa0xDQjBlRzRnUFNCaGNtTTBMbUZpYVY5allXeHNXMkZ5WXpRdVFtOXZiRjBvQ2lBZ0lDQXZMeUFnSUNBZ0ltbHpYM0psWjJsemRHVnlaV1FvWVdSa2NtVnpjeWxpYjI5c0lpd0tJQ0FnSUM4dklDQWdJQ0J6Wld4c1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQWE5sYkdZdWNtVm5hWE4wY25sZllYQndYMmxrTG5aaGJIVmxMQW9nSUNBZ0x5OGdLUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmFXNXphV2RvZEY5c2FYTjBhVzVuTDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OcFoyaDBYMnhwYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T1RZS0lDQWdJQzh2SUdGd2NGOXBaRDF6Wld4bUxuSmxaMmx6ZEhKNVgyRndjRjlwWkM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnlaV2RwYzNSeWVWOWhjSEJmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjbVZuYVhOMGNubGZZWEJ3WDJsa0lHVjRhWE4wY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5cGJuTnBaMmgwWDJ4cGMzUnBibWN2YzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzJsbmFIUmZiR2x6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG81TXkwNU53b2dJQ0FnTHk4Z2FYTmZjbVZuYVhOMFpYSmxaQ3dnZEhodUlEMGdZWEpqTkM1aFltbGZZMkZzYkZ0aGNtTTBMa0p2YjJ4ZEtBb2dJQ0FnTHk4Z0lDQWdJQ0pwYzE5eVpXZHBjM1JsY21Wa0tHRmtaSEpsYzNNcFltOXZiQ0lzQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNiR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxelpXeG1MbkpsWjJsemRISjVYMkZ3Y0Y5cFpDNTJZV3gxWlN3S0lDQWdJQzh2SUNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURreE9XTXdNbVJtSUM4dklHMWxkR2h2WkNBaWFYTmZjbVZuYVhOMFpYSmxaQ2hoWkdSeVpYTnpLV0p2YjJ3aUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pHbG5JREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z2JHOW5JSFpoYkhWbElHbHpJRzV2ZENCMGFHVWdjbVZ6ZFd4MElHOW1JR0Z1SUVGQ1NTQnlaWFIxY200S0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVZbTl2YkFvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YVc1emFXZG9kRjlzYVhOMGFXNW5MM050WVhKMFgyTnZiblJ5WVdOMGN5OXBibk5wWjJoMFgyeHBjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZPVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnBjMTl5WldkcGMzUmxjbVZrTENBaVZXNXlaV2RwYzNSbGNtVmtJR0ZuWlc1MElPS0FsQ0JqWVd4c0lFRm5aVzUwVW1WbmFYTjBjbmt1Y21WbmFYTjBaWElvS1NCbWFYSnpkQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklGVnVjbVZuYVhOMFpYSmxaQ0JoWjJWdWRDRGlnSlFnWTJGc2JDQkJaMlZ1ZEZKbFoybHpkSEo1TG5KbFoybHpkR1Z5S0NrZ1ptbHljM1FLQ21OeVpXRjBaVjlzYVhOMGFXNW5YMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwybHVjMmxuYUhSZmJHbHpkR2x1Wnk5emJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emFXZG9kRjlzYVhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFd01Bb2dJQ0FnTHk4Z2JHbHpkR2x1WjE5cFpDQTlJSE5sYkdZdWJtVjRkRjlzYVhOMGFXNW5YMmxrTG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJtVjRkRjlzYVhOMGFXNW5YMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtNWxlSFJmYkdsemRHbHVaMTlwWkNCbGVHbHpkSE1LSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMmx1YzJsbmFIUmZiR2x6ZEdsdVp5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXphV2RvZEY5c2FYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXdNaTB4TVRVS0lDQWdJQzh2SUNNZ1RXbHVkQ0J2Ym1VZ1FWTkJJR1p2Y2lCMGFHbHpJR3hwYzNScGJtY2dZVzVrSUhOMGIzSmxJR2wwY3lCcFpDQjNhWFJvSUd4cGMzUnBibWNnYldWMFlXUmhkR0V1Q2lBZ0lDQXZMeUJoYzNObGRGOXlaWE4xYkhRZ1BTQnBkSGh1TGtGemMyVjBRMjl1Wm1sbktBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1BWVkpiblEyTkNneEtTd0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjejFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pHVm1ZWFZzZEY5bWNtOTZaVzQ5Um1Gc2MyVXNDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFNKSlRsTkpSMGhVSWl3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5dVlXMWxQU0pOWlhKallYUnZjaUJKYm5OcFoyaDBJaXdLSUNBZ0lDOHZJQ0FnSUNCMWNtdzlhWEJtYzE5b1lYTm9MbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlQWE5sYkd4bGNpNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUMXpaV3hzWlhJdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHWnlaV1Y2WlQxelpXeHNaWEl1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yUFhObGJHeGxjaTV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNneE1EQXdLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwybHVjMmxuYUhSZmJHbHpkR2x1Wnk5emJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emFXZG9kRjlzYVhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFd09Rb2dJQ0FnTHk4Z2RYSnNQV2x3Wm5OZmFHRnphQzV1WVhScGRtVXNDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFTnNZWGRpWVdOckNpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSR2NtVmxlbVVLSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRkpsYzJWeWRtVUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFMWhibUZuWlhJS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSVlVrd0tJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwybHVjMmxuYUhSZmJHbHpkR2x1Wnk5emJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emFXZG9kRjlzYVhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFd09Bb2dJQ0FnTHk4Z1lYTnpaWFJmYm1GdFpUMGlUV1Z5WTJGMGIzSWdTVzV6YVdkb2RDSXNDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrMWxjbU5oZEc5eUlFbHVjMmxuYUhRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRtRnRaUW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZhVzV6YVdkb2RGOXNhWE4wYVc1bkwzTnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTnBaMmgwWDJ4cGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UQTNDaUFnSUNBdkx5QjFibWwwWDI1aGJXVTlJa2xPVTBsSFNGUWlMQW9nSUNBZ2NIVnphR0o1ZEdWeklDSkpUbE5KUjBoVUlnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGVnVhWFJPWVcxbENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5cGJuTnBaMmgwWDJ4cGMzUnBibWN2YzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzJsbmFIUmZiR2x6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TURZS0lDQWdJQzh2SUdSbFptRjFiSFJmWm5KdmVtVnVQVVpoYkhObExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRVpXWmhkV3gwUm5KdmVtVnVDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXBibk5wWjJoMFgyeHBjM1JwYm1jdmMyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMybG5hSFJmYkdsemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1EVUtJQ0FnSUM4dklHUmxZMmx0WVd4elBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFJHVmphVzFoYkhNS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJsdWMybG5hSFJmYkdsemRHbHVaeTl6YldGeWRGOWpiMjUwY21GamRITXZhVzV6YVdkb2RGOXNhWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPakV3TkFvZ0lDQWdMeThnZEc5MFlXdzlWVWx1ZERZMEtERXBMQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlViM1JoYkFvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YVc1emFXZG9kRjlzYVhOMGFXNW5MM050WVhKMFgyTnZiblJ5WVdOMGN5OXBibk5wWjJoMFgyeHBjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNVEF5TFRFd013b2dJQ0FnTHk4Z0l5Qk5hVzUwSUc5dVpTQkJVMEVnWm05eUlIUm9hWE1nYkdsemRHbHVaeUJoYm1RZ2MzUnZjbVVnYVhSeklHbGtJSGRwZEdnZ2JHbHpkR2x1WnlCdFpYUmhaR0YwWVM0S0lDQWdJQzh2SUdGemMyVjBYM0psYzNWc2RDQTlJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNCd2RYTm9hVzUwSURNZ0x5OGdZV05tWndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZhVzV6YVdkb2RGOXNhWE4wYVc1bkwzTnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTnBaMmgwWDJ4cGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1URTBDaUFnSUNBdkx5Qm1aV1U5VlVsdWREWTBLREV3TURBcExBb2dJQ0FnY0hWemFHbHVkQ0F4TURBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmFXNXphV2RvZEY5c2FYTjBhVzVuTDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OcFoyaDBYMnhwYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRBeUxURXhOUW9nSUNBZ0x5OGdJeUJOYVc1MElHOXVaU0JCVTBFZ1ptOXlJSFJvYVhNZ2JHbHpkR2x1WnlCaGJtUWdjM1J2Y21VZ2FYUnpJR2xrSUhkcGRHZ2diR2x6ZEdsdVp5QnRaWFJoWkdGMFlTNEtJQ0FnSUM4dklHRnpjMlYwWDNKbGMzVnNkQ0E5SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3c5VlVsdWREWTBLREVwTEFvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4elBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JrWldaaGRXeDBYMlp5YjNwbGJqMUdZV3h6WlN3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlJa2xPVTBsSFNGUWlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOUlrMWxjbU5oZEc5eUlFbHVjMmxuYUhRaUxBb2dJQ0FnTHk4Z0lDQWdJSFZ5YkQxcGNHWnpYMmhoYzJndWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHMWhibUZuWlhJOWMyVnNiR1Z5TG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCeVpYTmxjblpsUFhObGJHeGxjaTV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWm5KbFpYcGxQWE5sYkd4bGNpNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdZMnhoZDJKaFkyczljMlZzYkdWeUxtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5VlVsdWREWTBLREV3TURBcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1EzSmxZWFJsWkVGemMyVjBTVVFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMmx1YzJsbmFIUmZiR2x6ZEdsdVp5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXphV2RvZEY5c2FYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXlNZ29nSUNBZ0x5OGdZWE5oWDJsa1BXRnlZelF1VlVsdWREWTBLR0Z6WVY5cFpDa3NDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXBibk5wWjJoMFgyeHBjM1JwYm1jdmMyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMybG5hSFJmYkdsemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1UZ3RNVEl6Q2lBZ0lDQXZMeUJ6Wld4bUxteHBjM1JwYm1kelcyRnlZelF1VlVsdWREWTBLR3hwYzNScGJtZGZhV1FwWFNBOUlFeHBjM1JwYm1jb0NpQWdJQ0F2THlBZ0lDQWdjSEpwWTJVOWNISnBZMlVzQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNiR1Z5UFhObGJHeGxjaXdLSUNBZ0lDOHZJQ0FnSUNCcGNHWnpYMmhoYzJnOWFYQm1jMTlvWVhOb0xBb2dJQ0FnTHk4Z0lDQWdJR0Z6WVY5cFpEMWhjbU0wTGxWSmJuUTJOQ2hoYzJGZmFXUXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1pHbG5JRFlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRE15Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXBibk5wWjJoMFgyeHBjM1JwYm1jdmMyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMybG5hSFJmYkdsemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1UZ0tJQ0FnSUM4dklITmxiR1l1YkdsemRHbHVaM05iWVhKak5DNVZTVzUwTmpRb2JHbHpkR2x1WjE5cFpDbGRJRDBnVEdsemRHbHVaeWdLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcyWXpZNU56TTNORFk1Tm1VMk53b2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZhVzV6YVdkb2RGOXNhWE4wYVc1bkwzTnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTnBaMmgwWDJ4cGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1URTRMVEV5TXdvZ0lDQWdMeThnYzJWc1ppNXNhWE4wYVc1bmMxdGhjbU0wTGxWSmJuUTJOQ2hzYVhOMGFXNW5YMmxrS1YwZ1BTQk1hWE4wYVc1bktBb2dJQ0FnTHk4Z0lDQWdJSEJ5YVdObFBYQnlhV05sTEFvZ0lDQWdMeThnSUNBZ0lITmxiR3hsY2oxelpXeHNaWElzQ2lBZ0lDQXZMeUFnSUNBZ2FYQm1jMTlvWVhOb1BXbHdabk5mYUdGemFDd0tJQ0FnSUM4dklDQWdJQ0JoYzJGZmFXUTlZWEpqTkM1VlNXNTBOalFvWVhOaFgybGtLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMmx1YzJsbmFIUmZiR2x6ZEdsdVp5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXphV2RvZEY5c2FYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXlOQW9nSUNBZ0x5OGdjMlZzWmk1dVpYaDBYMnhwYzNScGJtZGZhV1F1ZG1Gc2RXVWdQU0JzYVhOMGFXNW5YMmxrSUNzZ1ZVbHVkRFkwS0RFcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTWlBdkx5QWlibVY0ZEY5c2FYTjBhVzVuWDJsa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwybHVjMmxuYUhSZmJHbHpkR2x1Wnk5emJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emFXZG9kRjlzYVhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pVMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBQUVtQXc5eVpXZHBjM1J5ZVY5aGNIQmZhV1FFRlI5OGRROXVaWGgwWDJ4cGMzUnBibWRmYVdReEcwRUFHSUFFTmJnMjFqWWFBSTRCQUFFQU1Sa1VNUmdRUkVJQUNERVpGREVZRkJCRE5ob0JTUldCQ0JKRU5ob0NTUldCSUJKRU5ob0RSd0lpV1lFQ0NFd1ZFa1FpS0dWRVFRQXhzU0lvWlVTeUdJQUVrWndDMzdJYVN3R3lHb0VHc2hBaXNnR3p0RDVKVndBRUtSSkVWd1FBU1JVakVrU0FBUUFUUkNJcVpVU3hTd0ZKVndJQVN3UkpzaXhKc2l0SnNpcEpzaWxNc2llQUVFMWxjbU5oZEc5eUlFbHVjMmxuYUhTeUpvQUhTVTVUU1VkSVZMSWxJcklrSXJJakk3SWlnUU95RUlIb0I3SUJzN1E4RmtzR1R3SlFnQUlBTWxCTVVFeFFTd0VXZ0Fkc2FYTjBhVzVuU3dGUVNieElUd0svVENNSUtreG5LVXhRc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
