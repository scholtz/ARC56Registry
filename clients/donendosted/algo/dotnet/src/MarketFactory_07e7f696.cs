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

namespace Arc56.Generated.donendosted.algo.MarketFactory_07e7f696
{


    public class MarketFactoryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MarketFactoryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class MarketMeta : AVMObjectType
            {
                public ulong AppId { get; set; }

                public string AssetSymbol { get; set; }

                public string Question { get; set; }

                public ulong ResolutionPrice { get; set; }

                public ulong ExpiryTs { get; set; }

                public string MarketType { get; set; }

                public bool Settled { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAppId.From(AppId);
                    ret.AddRange(vAppId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetSymbol = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAssetSymbol.From(AssetSymbol);
                    stringRef[ret.Count] = vAssetSymbol.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vQuestion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vQuestion.From(Question);
                    stringRef[ret.Count] = vQuestion.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResolutionPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vResolutionPrice.From(ResolutionPrice);
                    ret.AddRange(vResolutionPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiryTs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiryTs.From(ExpiryTs);
                    ret.AddRange(vExpiryTs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMarketType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMarketType.From(MarketType);
                    stringRef[ret.Count] = vMarketType.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSettled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vSettled.From(Settled);
                    ret.AddRange(vSettled.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static MarketMeta Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new MarketMeta();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAppId = vAppId.ToValue();
                    if (valueAppId is ulong vAppIdValue) { ret.AppId = vAppIdValue; }
                    var indexAssetSymbol = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetSymbol = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAssetSymbol.Decode(bytes.Skip(indexAssetSymbol + prefixOffset).ToArray());
                    var valueAssetSymbol = vAssetSymbol.ToValue();
                    if (valueAssetSymbol is string vAssetSymbolValue) { ret.AssetSymbol = vAssetSymbolValue; }
                    var indexQuestion = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vQuestion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vQuestion.Decode(bytes.Skip(indexQuestion + prefixOffset).ToArray());
                    var valueQuestion = vQuestion.ToValue();
                    if (valueQuestion is string vQuestionValue) { ret.Question = vQuestionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResolutionPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vResolutionPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueResolutionPrice = vResolutionPrice.ToValue();
                    if (valueResolutionPrice is ulong vResolutionPriceValue) { ret.ResolutionPrice = vResolutionPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiryTs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiryTs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiryTs = vExpiryTs.ToValue();
                    if (valueExpiryTs is ulong vExpiryTsValue) { ret.ExpiryTs = vExpiryTsValue; }
                    var indexMarketType = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMarketType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMarketType.Decode(bytes.Skip(indexMarketType + prefixOffset).ToArray());
                    var valueMarketType = vMarketType.ToValue();
                    if (valueMarketType is string vMarketTypeValue) { ret.MarketType = vMarketTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSettled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vSettled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSettled = vSettled.ToValue();
                    if (valueSettled is bool vSettledValue) { ret.Settled = vSettledValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MarketMeta);
                }
                public bool Equals(MarketMeta? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MarketMeta left, MarketMeta right)
                {
                    return EqualityComparer<MarketMeta>.Default.Equals(left, right);
                }
                public static bool operator !=(MarketMeta left, MarketMeta right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="registry_app_id"> </param>
        public async Task Create(ulong registry_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var registry_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registry_app_idAbi.From(registry_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, registry_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong registry_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var registry_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registry_app_idAbi.From(registry_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, registry_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_symbol"> </param>
        /// <param name="question"> </param>
        /// <param name="resolution_price"> </param>
        /// <param name="expiry_ts"> </param>
        /// <param name="market_type"> </param>
        /// <param name="seed_algo"> </param>
        public async Task<ulong> CreateMarket(string asset_symbol, string question, ulong resolution_price, ulong expiry_ts, string market_type, ulong seed_algo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 150, 226, 10 };
            var asset_symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); asset_symbolAbi.From(asset_symbol);
            var questionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); questionAbi.From(question);
            var resolution_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); resolution_priceAbi.From(resolution_price);
            var expiry_tsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiry_tsAbi.From(expiry_ts);
            var market_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); market_typeAbi.From(market_type);
            var seed_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); seed_algoAbi.From(seed_algo);

            var result = await base.CallApp(new List<object> { abiHandle, asset_symbolAbi, questionAbi, resolution_priceAbi, expiry_tsAbi, market_typeAbi, seed_algoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateMarket_Transactions(string asset_symbol, string question, ulong resolution_price, ulong expiry_ts, string market_type, ulong seed_algo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 150, 226, 10 };
            var asset_symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); asset_symbolAbi.From(asset_symbol);
            var questionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); questionAbi.From(question);
            var resolution_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); resolution_priceAbi.From(resolution_price);
            var expiry_tsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiry_tsAbi.From(expiry_ts);
            var market_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); market_typeAbi.From(market_type);
            var seed_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); seed_algoAbi.From(seed_algo);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_symbolAbi, questionAbi, resolution_priceAbi, expiry_tsAbi, market_typeAbi, seed_algoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="market_id"> </param>
        public async Task<Structs.MarketMeta> GetMarket(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 224, 46, 126 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            var result = await base.SimApp(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MarketMeta.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetMarket_Transactions(ulong market_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 224, 46, 126 };
            var market_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_idAbi.From(market_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, market_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetMarketCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 80, 169, 64 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetMarketCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 80, 169, 64 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWFya2V0RmFjdG9yeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJNYXJrZXRNZXRhIjpbeyJuYW1lIjoiYXBwX2lkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFzc2V0X3N5bWJvbCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJxdWVzdGlvbiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJyZXNvbHV0aW9uX3ByaWNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImV4cGlyeV90cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXJrZXRfdHlwZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJzZXR0bGVkIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlZ2lzdHJ5X2FwcF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfbWFya2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X3N5bWJvbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicXVlc3Rpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc29sdXRpb25fcHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyeV90cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X3R5cGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlZWRfYWxnbyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9tYXJrZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFya2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsc3RyaW5nLHN0cmluZyx1aW50NjQsdWludDY0LHN0cmluZyxib29sKSIsInN0cnVjdCI6Ik1hcmtldE1ldGEiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9tYXJrZXRfY291bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjIyXSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gbG9nIHZhbHVlIGlzIG5vdCB0aGUgcmVzdWx0IG9mIGFuIEFCSSByZXR1cm4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODAsMzg4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tYXJrZXRfY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZWdpc3RyeV9hcHBfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI1LDE0MSwxNzNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM1LDE1MSwxODBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEwLDE1OSwxNjcsMTg4LDM2Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3Nl0sImVycm9yTWVzc2FnZSI6Im1hcmtldCBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzRdLCJlcnJvck1lc3NhZ2UiOiJwbGF0Zm9ybSBwYXVzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQXlDaUFnSUNCaWVYUmxZMkpzYjJOcklDSnRZWEpyWlhSZlkyOTFiblFpSURCNE1UVXhaamRqTnpVZ0luSmxaMmx6ZEhKNVgyRndjRjlwWkNJZ01IZzJaRFl4TnpJMllqWTFOelF6WVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoY210bGRGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExuQjVPakkyQ2lBZ0lDQXZMeUJqYkdGemN5Qk5ZWEpyWlhSR1lXTjBiM0o1S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURrS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaVpqazJaVEl3WVNBd2VHTTRaVEF5WlRkbElEQjROekkxTUdFNU5EQWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVmZiV0Z5YTJWMEtITjBjbWx1Wnl4emRISnBibWNzZFdsdWREWTBMSFZwYm5RMk5DeHpkSEpwYm1jc2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFgyMWhjbXRsZENoMWFXNTBOalFwS0hWcGJuUTJOQ3h6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkN4MWFXNTBOalFzYzNSeWFXNW5MR0p2YjJ3cElpd2diV1YwYUc5a0lDSm5aWFJmYldGeWEyVjBYMk52ZFc1MEtDbDFhVzUwTmpRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdWZmJXRnlhMlYwSUdkbGRGOXRZWEpyWlhRZ1oyVjBYMjFoY210bGRGOWpiM1Z1ZEFvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGeWEyVjBYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpZS0lDQWdJQzh2SUdOc1lYTnpJRTFoY210bGRFWmhZM1J2Y25rb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREkwTUdReVpqWTNJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsQ2lBZ0lDQmxjbklLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWJXRnlhMlYwWDJaaFkzUnZjbmt1WTI5dWRISmhZM1F1VFdGeWEyVjBSbUZqZEc5eWVTNWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGeWEyVjBYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVjSGs2TXpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoY210bGRGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJ6Wld4bUxuSmxaMmx6ZEhKNVgyRndjRjlwWkM1MllXeDFaU0E5SUhKbFoybHpkSEo1WDJGd2NGOXBaQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljbVZuYVhOMGNubGZZWEJ3WDJsa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlYSnJaWFJmWm1GamRHOXllUzlqYjI1MGNtRmpkQzV3ZVRvek5Rb2dJQ0FnTHk4Z2MyVnNaaTV0WVhKclpYUmZZMjkxYm5RdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW0xaGNtdGxkRjlqYjNWdWRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGNtdGxkRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbkI1T2pNeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWJXRnlhMlYwWDJaaFkzUnZjbmt1WTI5dWRISmhZM1F1VFdGeWEyVjBSbUZqZEc5eWVTNWpjbVZoZEdWZmJXRnlhMlYwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDIxaGNtdGxkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZWEpyWlhSZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1d2VUb3pOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVhKclpYUmZabUZqZEc5eWVTOWpiMjUwY21GamRDNXdlVG8wTnkwMU1Bb2dJQ0FnTHk4Z2FYTmZjR0YxYzJWa0xDQmZkSGh1SUQwZ1lYSmpOQzVoWW1sZlkyRnNiRnRoY21NMExrSnZiMnhkS0FvZ0lDQWdMeThnSUNBZ0lDSm5aWFJmY0dGMWMyVmtLQ2xpYjI5c0lpd0tJQ0FnSUM4dklDQWdJQ0JoY0hCZmFXUTlRWEJ3YkdsallYUnBiMjRvYzJWc1ppNXlaV2RwYzNSeWVWOWhjSEJmYVdRdWRtRnNkV1VwTEFvZ0lDQWdMeThnS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhjbXRsZEY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG5CNU9qUTVDaUFnSUNBdkx5QmhjSEJmYVdROVFYQndiR2xqWVhScGIyNG9jMlZzWmk1eVpXZHBjM1J5ZVY5aGNIQmZhV1F1ZG1Gc2RXVXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luSmxaMmx6ZEhKNVgyRndjRjlwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaV2RwYzNSeWVWOWhjSEJmYVdRZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoY210bGRGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExuQjVPalEzTFRVd0NpQWdJQ0F2THlCcGMxOXdZWFZ6WldRc0lGOTBlRzRnUFNCaGNtTTBMbUZpYVY5allXeHNXMkZ5WXpRdVFtOXZiRjBvQ2lBZ0lDQXZMeUFnSUNBZ0ltZGxkRjl3WVhWelpXUW9LV0p2YjJ3aUxBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Y5cFpEMUJjSEJzYVdOaGRHbHZiaWh6Wld4bUxuSmxaMmx6ZEhKNVgyRndjRjlwWkM1MllXeDFaU2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5T1RZMlpqQmtaaUF2THlCdFpYUm9iMlFnSW1kbGRGOXdZWFZ6WldRb0tXSnZiMndpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdOQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdGd2NHeHBZMkYwYVc5dUlHeHZaeUIyWVd4MVpTQnBjeUJ1YjNRZ2RHaGxJSEpsYzNWc2RDQnZaaUJoYmlCQlFra2djbVYwZFhKdUNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVhKclpYUmZabUZqZEc5eWVTOWpiMjUwY21GamRDNXdlVG8xTVFvZ0lDQWdMeThnWVhOelpYSjBJRzV2ZENCcGMxOXdZWFZ6WldRdWJtRjBhWFpsTENBaWNHeGhkR1p2Y20wZ2NHRjFjMlZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklIQnNZWFJtYjNKdElIQmhkWE5sWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoY210bGRGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExuQjVPalV6TFRZeENpQWdJQ0F2THlCa1pYQnNiM2xmZEhodUlEMGdZWEpqTkM1aFltbGZZMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQWlZM0psWVhSbEtITjBjbWx1Wnl4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5emVXMWliMndzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpiMngxZEdsdmJsOXdjbWxqWlN3S0lDQWdJQzh2SUNBZ0lDQmxlSEJwY25sZmRITXNDaUFnSUNBdkx5QWdJQ0FnYzJWc1ppNXlaV2RwYzNSeWVWOWhjSEJmYVdRdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVWRzYjJKaGJDNXRhVzVmWW1Gc1lXNWpaU0FySUhObFpXUmZZV3huYnl3S0lDQWdJQzh2SUNBZ0lDQmhjSEJmYVdROVFYQndiR2xqWVhScGIyNG9NQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnlhMlYwWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1Y0hrNk5Ua0tJQ0FnSUM4dklHWmxaVDFIYkc5aVlXd3ViV2x1WDJKaGJHRnVZMlVnS3lCelpXVmtYMkZzWjI4c0NpQWdJQ0JuYkc5aVlXd2dUV2x1UW1Gc1lXNWpaUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0Z5YTJWMFgyWmhZM1J2Y25rdlkyOXVkSEpoWTNRdWNIazZOVGdLSUNBZ0lDOHZJSE5sYkdZdWNtVm5hWE4wY25sZllYQndYMmxrTG5aaGJIVmxMQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhjbXRsZEY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG5CNU9qWXdDaUFnSUNBdkx5QmhjSEJmYVdROVFYQndiR2xqWVhScGIyNG9NQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0Z5YTJWMFgyWmhZM1J2Y25rdlkyOXVkSEpoWTNRdWNIazZOVE10TmpFS0lDQWdJQzh2SUdSbGNHeHZlVjkwZUc0Z1BTQmhjbU0wTG1GaWFWOWpZV3hzS0FvZ0lDQWdMeThnSUNBZ0lDSmpjbVZoZEdVb2MzUnlhVzVuTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNONWJXSnZiQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpYTnZiSFYwYVc5dVgzQnlhV05sTEFvZ0lDQWdMeThnSUNBZ0lHVjRjR2x5ZVY5MGN5d0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxuSmxaMmx6ZEhKNVgyRndjRjlwWkM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlSMnh2WW1Gc0xtMXBibDlpWVd4aGJtTmxJQ3NnYzJWbFpGOWhiR2R2TEFvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxQmNIQnNhV05oZEdsdmJpZ3dLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGd4TTJFd01HSTVJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLSE4wY21sdVp5eDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklEUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUVOeVpXRjBaV1JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGeWEyVjBYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVjSGs2TmpRS0lDQWdJQzh2SUcxcFpDQTlJSE5sYkdZdWJXRnlhMlYwWDJOdmRXNTBMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYldGeWEyVjBYMk52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTFoY210bGRGOWpiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZWEpyWlhSZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1d2VUbzJOUW9nSUNBZ0x5OGdZbTk0WDJ0bGVTQTlJRUo1ZEdWektHSWliV0Z5YTJWME9pSXBJQ3NnYjNBdWFYUnZZaWh0YVdRcENpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnMlpEWXhOekkyWWpZMU56UXpZUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV0Z5YTJWMFgyWmhZM1J2Y25rdlkyOXVkSEpoWTNRdWNIazZOamdLSUNBZ0lDOHZJR0Z3Y0Y5cFpEMWhjbU0wTGxWSmJuUTJOQ2h0WVhKclpYUmZZWEJ3WDJsa0tTd0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFoY210bGRGOW1ZV04wYjNKNUwyTnZiblJ5WVdOMExuQjVPalkzTFRjMUNpQWdJQ0F2THlCaWIzZ3VkbUZzZFdVZ1BTQk5ZWEpyWlhSTlpYUmhLQW9nSUNBZ0x5OGdJQ0FnSUdGd2NGOXBaRDFoY21NMExsVkpiblEyTkNodFlYSnJaWFJmWVhCd1gybGtLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl6ZVcxaWIydzlZWE56WlhSZmMzbHRZbTlzTEFvZ0lDQWdMeThnSUNBZ0lIRjFaWE4wYVc5dVBYRjFaWE4wYVc5dUxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzI5c2RYUnBiMjVmY0hKcFkyVTlZWEpqTkM1VlNXNTBOalFvY21WemIyeDFkR2x2Ymw5d2NtbGpaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1pYaHdhWEo1WDNSelBXRnlZelF1VlVsdWREWTBLR1Y0Y0dseWVWOTBjeWtzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnlhMlYwWDNSNWNHVTliV0Z5YTJWMFgzUjVjR1VzQ2lBZ0lDQXZMeUFnSUNBZ2MyVjBkR3hsWkQxaGNtTTBMa0p2YjJ3b1JtRnNjMlVwTEFvZ0lDQWdMeThnS1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURGbUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaHBiblFnTXpFS0lDQWdJSFZ1WTI5MlpYSWdNVEFLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhjbXRsZEY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG5CNU9qYzBDaUFnSUNBdkx5QnpaWFIwYkdWa1BXRnlZelF1UW05dmJDaEdZV3h6WlNrc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGNtdGxkRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbkI1T2pZM0xUYzFDaUFnSUNBdkx5QmliM2d1ZG1Gc2RXVWdQU0JOWVhKclpYUk5aWFJoS0FvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxaGNtTTBMbFZKYm5RMk5DaHRZWEpyWlhSZllYQndYMmxrS1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5emVXMWliMnc5WVhOelpYUmZjM2x0WW05c0xBb2dJQ0FnTHk4Z0lDQWdJSEYxWlhOMGFXOXVQWEYxWlhOMGFXOXVMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyOXNkWFJwYjI1ZmNISnBZMlU5WVhKak5DNVZTVzUwTmpRb2NtVnpiMngxZEdsdmJsOXdjbWxqWlNrc0NpQWdJQ0F2THlBZ0lDQWdaWGh3YVhKNVgzUnpQV0Z5WXpRdVZVbHVkRFkwS0dWNGNHbHllVjkwY3lrc0NpQWdJQ0F2THlBZ0lDQWdiV0Z5YTJWMFgzUjVjR1U5YldGeWEyVjBYM1I1Y0dVc0NpQWdJQ0F2THlBZ0lDQWdjMlYwZEd4bFpEMWhjbU0wTGtKdmIyd29SbUZzYzJVcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVhKclpYUmZabUZqZEc5eWVTOWpiMjUwY21GamRDNXdlVG8zTmdvZ0lDQWdMeThnYzJWc1ppNXRZWEpyWlhSZlkyOTFiblF1ZG1Gc2RXVWdQU0J0YVdRZ0t5QlZTVzUwTmpRb01Ta0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p0WVhKclpYUmZZMjkxYm5RaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxaGNtdGxkRjltWVdOMGIzSjVMMk52Ym5SeVlXTjBMbkI1T2pNM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWJXRnlhMlYwWDJaaFkzUnZjbmt1WTI5dWRISmhZM1F1VFdGeWEyVjBSbUZqZEc5eWVTNW5aWFJmYldGeWEyVjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyMWhjbXRsZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0WVhKclpYUmZabUZqZEc5eWVTOWpiMjUwY21GamRDNXdlVG8zT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnlhMlYwWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1Y0hrNk9ERUtJQ0FnSUM4dklHSnZlRjlyWlhrZ1BTQkNlWFJsY3loaUltMWhjbXRsZERvaUtTQXJJRzl3TG1sMGIySW9iV0Z5YTJWMFgybGtLUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlRFprTmpFM01qWmlOalUzTkROaENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dFlYSnJaWFJmWm1GamRHOXllUzlqYjI1MGNtRmpkQzV3ZVRvNE13b2dJQ0FnTHk4Z1lYTnpaWEowSUdKdmVDNXRZWGxpWlNncFd6RmRMQ0FpYldGeWEyVjBJRzV2ZENCbWIzVnVaQ0lLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnYldGeWEyVjBJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMWhjbXRsZEY5bVlXTjBiM0o1TDJOdmJuUnlZV04wTG5CNU9qZzBDaUFnSUNBdkx5QnlaWFIxY200Z1ltOTRMbTFoZVdKbEtDbGJNRjB1WTI5d2VTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRZWEpyWlhSZlptRmpkRzl5ZVM5amIyNTBjbUZqZEM1d2VUbzNPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtMWhjbXRsZEY5bVlXTjBiM0o1TG1OdmJuUnlZV04wTGsxaGNtdGxkRVpoWTNSdmNua3VaMlYwWDIxaGNtdGxkRjlqYjNWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5dFlYSnJaWFJmWTI5MWJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXRnlhMlYwWDJaaFkzUnZjbmt2WTI5dWRISmhZM1F1Y0hrNk9EZ0tJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbTFoY210bGRGOWpiM1Z1ZEM1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltMWhjbXRsZEY5amIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dFlYSnJaWFJmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldGeWEyVjBYMlpoWTNSdmNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFSUFpWUVERzFoY210bGRGOWpiM1Z1ZEFRVkgzeDFEM0psWjJsemRISjVYMkZ3Y0Y5cFpBZHRZWEpyWlhRNk1Sa1VSREVZUVFBZGdnTUV2NWJpQ2dUSTRDNStCSEpRcVVBMkdnQ09Bd0FnQVE4QktRQ0FCQ1FOTDJjMkdnQ09BUUFCQURZYUFVa1ZKQkpFRnlwTVp5Z2laeU5ETmhvQlNTSlpKUWhMQVJWSlR3SVNSRFlhQWtraVdTVUlTd0VWU1U4Q0VrUTJHZ05KRlNRU1JEWWFCRWtWSkJKRU5ob0ZTU0paSlFoTEFSVVNSRFlhQmtrVkpCSkVGN0VpS21WRVNiSVlnQVFwWnZEZnNocUJCcklRSXJJQnM3UStTVmNBQkNrU1JGY0VBRWtWSXhKRUlsTVVSTEV5QVU4Q0NFd1dJcklZZ0FTQk9nQzVzaHBMQ0xJYVN3U3lHa3NEc2hxeUdvRUdzaEN5QWJPMFBTSW9aVVJKRml0TVVFOENGa21BQWdBZlVJRWZUd29JU1JaWEJnSlBBa3hRVEU4SUNFeFBCMUJQQmxCTUZsY0dBbENBQVFCUVR3WlFUd1ZRVHdSUVN3SzhTRThDVEw5TUl3Z29UR2NwVEZDd0kwTTJHZ0ZKRlNRU1JCY1dLMHhRU2IxRkFVUytTQ2xNVUxBalF5SW9aVVFXS1V4UXNDTkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
