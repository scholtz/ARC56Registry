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

namespace Arc56.Generated.swanandi_bhende.mercator.InsightListing_b1cdf144
{


    //
    // On-chain listing registry for trading insights.
    //    
    //    State:
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
        ///Actions: 1. Increment next_listing_id counter → allocate new listing ID. 2. Call itxn.AssetConfig to mint one ASA with:    - INSIGHT token name, Mercator Insight asset name, IpfsHash as URL.    - Seller as manager + reserve + freeze + clawback (seller controls proof token).    - Fee=1000 micro-Algo. 3. Store Listing struct in boxes: {price, seller, ipfs_hash, asa_id}. 4. Increment counter for next invocation. 5. Return listing_id to caller (frontend caches this).
        ///</summary>
        /// <param name="price">Settlement amount (micro-USDC). e.g., 5_000_000 = 5 USDC. </param>
        /// <param name="seller">Seller's Algorand wallet (58-char checksummed address). </param>
        /// <param name="ipfs_hash">Content CID (e.g., "Qm...") pinned on Pinata. </param>
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSW5zaWdodExpc3RpbmciLCJkZXNjIjoiT24tY2hhaW4gbGlzdGluZyByZWdpc3RyeSBmb3IgdHJhZGluZyBpbnNpZ2h0cy5cbiAgICBcbiAgICBTdGF0ZTpcbiAgICAgICAgbmV4dF9saXN0aW5nX2lkOiBHbG9iYWwgY291bnRlciBhbGxvY2F0aW5nIHVuaXF1ZSBsaXN0aW5nIElEcyAoVUludDY0KS5cbiAgICAgICAgbGlzdGluZ3M6IEJveE1hcChsaXN0aW5nX2lkID0+IExpc3RpbmcpLCBzdG9yaW5nIGFsbCBjdXJyZW50IGxpc3RpbmdzLlxuICAgIFxuICAgIFB1cnBvc2U6IFNlbGxlci1mYWNpbmcgY29udHJhY3QgZm9yIHB1Ymxpc2hpbmcgaW5zaWdodHMgKyBidXllci1mYWNpbmcgcmVnaXN0cnkgZm9yIGRpc2NvdmVyeS5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTGlzdGluZyI6W3sibmFtZSI6InByaWNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNlbGxlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiaXBmc19oYXNoIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImFzYV9pZCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX2xpc3RpbmciLCJkZXNjIjoiUHVibGlzaCBhIG5ldyB0cmFkaW5nIGluc2lnaHQgYW5kIHJlY2VpdmUgc2VsbGVyIEFTQSBmb3IgcHJvb2Ytb2Ytb3duZXJzaGlwLlxuUHVycG9zZTogQWxsb2NhdGUgdW5pcXVlIGxpc3RpbmcgSUQgYW5kIGxpbmsgSVBGUyBjb250ZW50IHBlcm1hbmVudGx5IG9uLWNoYWluLlxuQWN0aW9uczogMS4gSW5jcmVtZW50IG5leHRfbGlzdGluZ19pZCBjb3VudGVyIOKGkiBhbGxvY2F0ZSBuZXcgbGlzdGluZyBJRC4gMi4gQ2FsbCBpdHhuLkFzc2V0Q29uZmlnIHRvIG1pbnQgb25lIEFTQSB3aXRoOiAgICAtIElOU0lHSFQgdG9rZW4gbmFtZSwgTWVyY2F0b3IgSW5zaWdodCBhc3NldCBuYW1lLCBJcGZzSGFzaCBhcyBVUkwuICAgIC0gU2VsbGVyIGFzIG1hbmFnZXIgKyByZXNlcnZlICsgZnJlZXplICsgY2xhd2JhY2sgKHNlbGxlciBjb250cm9scyBwcm9vZiB0b2tlbikuICAgIC0gRmVlPTEwMDAgbWljcm8tQWxnby4gMy4gU3RvcmUgTGlzdGluZyBzdHJ1Y3QgaW4gYm94ZXM6IHtwcmljZSwgc2VsbGVyLCBpcGZzX2hhc2gsIGFzYV9pZH0uIDQuIEluY3JlbWVudCBjb3VudGVyIGZvciBuZXh0IGludm9jYXRpb24uIDUuIFJldHVybiBsaXN0aW5nX2lkIHRvIGNhbGxlciAoZnJvbnRlbmQgY2FjaGVzIHRoaXMpLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZSIsImRlc2MiOiJTZXR0bGVtZW50IGFtb3VudCAobWljcm8tVVNEQykuIGUuZy4sIDVfMDAwXzAwMCA9IDUgVVNEQy4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxsZXIiLCJkZXNjIjoiU2VsbGVyJ3MgQWxnb3JhbmQgd2FsbGV0ICg1OC1jaGFyIGNoZWNrc3VtbWVkIGFkZHJlc3MpLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXBmc19oYXNoIiwiZGVzYyI6IkNvbnRlbnQgQ0lEIChlLmcuLCBcIlFtLi4uXCIpIHBpbm5lZCBvbiBQaW5hdGEuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlVuaXF1ZSBpZGVudGlmaWVyICh1c2VkIGluIC9kaXNjb3ZlciByZXN1bHRzLCB4NDAyIHBheW1lbnQsIGVzY3JvdykuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMDNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm5leHRfbGlzdGluZ19pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltNWxlSFJmYkdsemRHbHVaMTlwWkNJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMmx1YzJsbmFIUmZiR2x6ZEdsdVp5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXphV2RvZEY5c2FYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qUTNDaUFnSUNBdkx5QnpaV3htTG01bGVIUmZiR2x6ZEdsdVoxOXBaQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYm1WNGRGOXNhWE4wYVc1blgybGtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJsdWMybG5hSFJmYkdsemRHbHVaeTl6YldGeWRGOWpiMjUwY21GamRITXZhVzV6YVdkb2RGOXNhWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPak0zQ2lBZ0lDQXZMeUJqYkdGemN5Qkpibk5wWjJoMFRHbHpkR2x1WnloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTndvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TXpWaU9ETTJaRFlnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZmYkdsemRHbHVaeWgxYVc1ME5qUXNZV1JrY21WemN5eHpkSEpwYm1jcGRXbHVkRFkwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlqY21WaGRHVmZiR2x6ZEdsdVoxOXliM1YwWlVBMUNpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMnhwYzNScGJtZGZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwybHVjMmxuYUhSZmJHbHpkR2x1Wnk5emJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emFXZG9kRjlzYVhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pVd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdJZ1kzSmxZWFJsWDJ4cGMzUnBibWNLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU56b0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1sdWMybG5hSFJmYkdsemRHbHVaeTVqYjI1MGNtRmpkQzVKYm5OcFoyaDBUR2x6ZEdsdVp5NWpjbVZoZEdWZmJHbHpkR2x1WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlY5c2FYTjBhVzVuT2dvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YVc1emFXZG9kRjlzYVhOMGFXNW5MM050WVhKMFgyTnZiblJ5WVdOMGN5OXBibk5wWjJoMFgyeHBjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZOVEFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMmx1YzJsbmFIUmZiR2x6ZEdsdVp5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXphV2RvZEY5c2FYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qYzVDaUFnSUNBdkx5QnNhWE4wYVc1blgybGtJRDBnYzJWc1ppNXVaWGgwWDJ4cGMzUnBibWRmYVdRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p1WlhoMFgyeHBjM1JwYm1kZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Ym1WNGRGOXNhWE4wYVc1blgybGtJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmFXNXphV2RvZEY5c2FYTjBhVzVuTDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OcFoyaDBYMnhwYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T0RFdE9UUUtJQ0FnSUM4dklDTWdUV2x1ZENCdmJtVWdRVk5CSUdadmNpQjBhR2x6SUd4cGMzUnBibWNnWVc1a0lITjBiM0psSUdsMGN5QnBaQ0IzYVhSb0lHeHBjM1JwYm1jZ2JXVjBZV1JoZEdFdUNpQWdJQ0F2THlCaGMzTmxkRjl5WlhOMWJIUWdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNQVlZKYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXTnBiV0ZzY3oxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdaR1ZtWVhWc2RGOW1jbTk2Wlc0OVJtRnNjMlVzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBTSkpUbE5KUjBoVUlpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXVZVzFsUFNKTlpYSmpZWFJ2Y2lCSmJuTnBaMmgwSWl3S0lDQWdJQzh2SUNBZ0lDQjFjbXc5YVhCbWMxOW9ZWE5vTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCdFlXNWhaMlZ5UFhObGJHeGxjaTV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnY21WelpYSjJaVDF6Wld4c1pYSXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWNlpUMXpaV3hzWlhJdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHTnNZWGRpWVdOclBYTmxiR3hsY2k1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3hNREF3S1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMmx1YzJsbmFIUmZiR2x6ZEdsdVp5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXphV2RvZEY5c2FYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qZzRDaUFnSUNBdkx5QjFjbXc5YVhCbWMxOW9ZWE5vTG01aGRHbDJaU3dLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJEYkdGM1ltRmphd29nSUNBZ1pHbG5JRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJHY21WbGVtVUtJQ0FnSUdScFp5QXpDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBVbVZ6WlhKMlpRb2dJQ0FnWkdsbklETUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk5ZVzVoWjJWeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZWSk1DaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXBibk5wWjJoMFgyeHBjM1JwYm1jdmMyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMybG5hSFJmYkdsemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvNE53b2dJQ0FnTHk4Z1lYTnpaWFJmYm1GdFpUMGlUV1Z5WTJGMGIzSWdTVzV6YVdkb2RDSXNDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrMWxjbU5oZEc5eUlFbHVjMmxuYUhRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRtRnRaUW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZhVzV6YVdkb2RGOXNhWE4wYVc1bkwzTnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTnBaMmgwWDJ4cGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk9EWUtJQ0FnSUM4dklIVnVhWFJmYm1GdFpUMGlTVTVUU1VkSVZDSXNDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrbE9VMGxIU0ZRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZXNXBkRTVoYldVS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDJsdWMybG5hSFJmYkdsemRHbHVaeTl6YldGeWRGOWpiMjUwY21GamRITXZhVzV6YVdkb2RGOXNhWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPamcxQ2lBZ0lDQXZMeUJrWldaaGRXeDBYMlp5YjNwbGJqMUdZV3h6WlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUkdWbVlYVnNkRVp5YjNwbGJnb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmFXNXphV2RvZEY5c2FYTjBhVzVuTDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OcFoyaDBYMnhwYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T0RRS0lDQWdJQzh2SUdSbFkybHRZV3h6UFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUkdWamFXMWhiSE1LSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMmx1YzJsbmFIUmZiR2x6ZEdsdVp5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXphV2RvZEY5c2FYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qZ3pDaUFnSUNBdkx5QjBiM1JoYkQxVlNXNTBOalFvTVNrc0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZSdmRHRnNDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXBibk5wWjJoMFgyeHBjM1JwYm1jdmMyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMybG5hSFJmYkdsemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvNE1TMDRNZ29nSUNBZ0x5OGdJeUJOYVc1MElHOXVaU0JCVTBFZ1ptOXlJSFJvYVhNZ2JHbHpkR2x1WnlCaGJtUWdjM1J2Y21VZ2FYUnpJR2xrSUhkcGRHZ2diR2x6ZEdsdVp5QnRaWFJoWkdGMFlTNEtJQ0FnSUM4dklHRnpjMlYwWDNKbGMzVnNkQ0E5SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQndkWE5vYVc1MElETWdMeThnWVdObVp3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YVc1emFXZG9kRjlzYVhOMGFXNW5MM050WVhKMFgyTnZiblJ5WVdOMGN5OXBibk5wWjJoMFgyeHBjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZPVE1LSUNBZ0lDOHZJR1psWlQxVlNXNTBOalFvTVRBd01Da3NDaUFnSUNCd2RYTm9hVzUwSURFd01EQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXBibk5wWjJoMFgyeHBjM1JwYm1jdmMyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMybG5hSFJmYkdsemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvNE1TMDVOQW9nSUNBZ0x5OGdJeUJOYVc1MElHOXVaU0JCVTBFZ1ptOXlJSFJvYVhNZ2JHbHpkR2x1WnlCaGJtUWdjM1J2Y21VZ2FYUnpJR2xrSUhkcGRHZ2diR2x6ZEdsdVp5QnRaWFJoWkdGMFlTNEtJQ0FnSUM4dklHRnpjMlYwWDNKbGMzVnNkQ0E5SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3c5VlVsdWREWTBLREVwTEFvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4elBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JrWldaaGRXeDBYMlp5YjNwbGJqMUdZV3h6WlN3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlJa2xPVTBsSFNGUWlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOUlrMWxjbU5oZEc5eUlFbHVjMmxuYUhRaUxBb2dJQ0FnTHk4Z0lDQWdJSFZ5YkQxcGNHWnpYMmhoYzJndWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHMWhibUZuWlhJOWMyVnNiR1Z5TG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCeVpYTmxjblpsUFhObGJHeGxjaTV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWm5KbFpYcGxQWE5sYkd4bGNpNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdZMnhoZDJKaFkyczljMlZzYkdWeUxtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5VlVsdWREWTBLREV3TURBcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1EzSmxZWFJsWkVGemMyVjBTVVFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMMmx1YzJsbmFIUmZiR2x6ZEdsdVp5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXphV2RvZEY5c2FYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXdNUW9nSUNBZ0x5OGdZWE5oWDJsa1BXRnlZelF1VlVsdWREWTBLR0Z6WVY5cFpDa3NDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXBibk5wWjJoMFgyeHBjM1JwYm1jdmMyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMybG5hSFJmYkdsemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvNU55MHhNRElLSUNBZ0lDOHZJSE5sYkdZdWJHbHpkR2x1WjNOYllYSmpOQzVWU1c1ME5qUW9iR2x6ZEdsdVoxOXBaQ2xkSUQwZ1RHbHpkR2x1WnlnS0lDQWdJQzh2SUNBZ0lDQndjbWxqWlQxd2NtbGpaU3dLSUNBZ0lDOHZJQ0FnSUNCelpXeHNaWEk5YzJWc2JHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdsd1puTmZhR0Z6YUQxcGNHWnpYMmhoYzJnc0NpQWdJQ0F2THlBZ0lDQWdZWE5oWDJsa1BXRnlZelF1VlVsdWREWTBLR0Z6WVY5cFpDa3NDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURNeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwybHVjMmxuYUhSZmJHbHpkR2x1Wnk5emJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emFXZG9kRjlzYVhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2prM0NpQWdJQ0F2THlCelpXeG1MbXhwYzNScGJtZHpXMkZ5WXpRdVZVbHVkRFkwS0d4cGMzUnBibWRmYVdRcFhTQTlJRXhwYzNScGJtY29DaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRObU0yT1Rjek56UTJPVFpsTmpjS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwybHVjMmxuYUhSZmJHbHpkR2x1Wnk5emJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emFXZG9kRjlzYVhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2prM0xURXdNZ29nSUNBZ0x5OGdjMlZzWmk1c2FYTjBhVzVuYzF0aGNtTTBMbFZKYm5RMk5DaHNhWE4wYVc1blgybGtLVjBnUFNCTWFYTjBhVzVuS0FvZ0lDQWdMeThnSUNBZ0lIQnlhV05sUFhCeWFXTmxMQW9nSUNBZ0x5OGdJQ0FnSUhObGJHeGxjajF6Wld4c1pYSXNDaUFnSUNBdkx5QWdJQ0FnYVhCbWMxOW9ZWE5vUFdsd1puTmZhR0Z6YUN3S0lDQWdJQzh2SUNBZ0lDQmhjMkZmYVdROVlYSmpOQzVWU1c1ME5qUW9ZWE5oWDJsa0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwybHVjMmxuYUhSZmJHbHpkR2x1Wnk5emJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emFXZG9kRjlzYVhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFd013b2dJQ0FnTHk4Z2MyVnNaaTV1WlhoMFgyeHBjM1JwYm1kZmFXUWdQU0JzYVhOMGFXNW5YMmxrSUNzZ1ZVbHVkRFkwS0RFcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTUNBdkx5QWlibVY0ZEY5c2FYTjBhVzVuWDJsa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwybHVjMmxuYUhSZmJHbHpkR2x1Wnk5emJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emFXZG9kRjlzYVhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pVd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBQUVtQVE5dVpYaDBYMnhwYzNScGJtZGZhV1F4R0VBQUF5Z2laekViUVFBWWdBUTF1RGJXTmhvQWpnRUFBUUF4R1JReEdCQkVRZ0FJTVJrVU1SZ1VFRU0yR2dGSkZZRUlFa1EyR2dKSkZZRWdFa1EyR2dOSklsbUJBZ2hMQVJVU1JDSW9aVVN4U3dGWEFnQkxBN0lzU3dPeUswc0RzaXBMQTdJcHNpZUFFRTFsY21OaGRHOXlJRWx1YzJsbmFIU3lKb0FIU1U1VFNVZElWTElsSXJJa0lySWpJN0lpZ1FPeUVJSG9CN0lCczdROEZrOEVUd1JRZ0FJQU1sQk1VRThDVUVzQkZvQUhiR2x6ZEdsdVowc0JVRW04U0U4Q3Ywd2pDQ2hNWjRBRUZSOThkVXhRc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
