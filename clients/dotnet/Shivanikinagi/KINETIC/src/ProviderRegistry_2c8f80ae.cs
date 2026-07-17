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

namespace Arc56.Generated.Shivanikinagi.KINETIC.ProviderRegistry_2c8f80ae
{


    public class ProviderRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ProviderRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ProviderInfo : AVMObjectType
            {
                public ulong VramGb { get; set; }

                public byte[] GpuModel { get; set; }

                public ulong PricePerHour { get; set; }

                public byte[] EndpointUrl { get; set; }

                public ulong UptimeScore { get; set; }

                public ulong Active { get; set; }

                public ulong BadgeAppId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVramGb = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVramGb.From(VramGb);
                    ret.AddRange(vVramGb.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGpuModel = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vGpuModel.From(GpuModel);
                    ret.AddRange(vGpuModel.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPricePerHour = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPricePerHour.From(PricePerHour);
                    ret.AddRange(vPricePerHour.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndpointUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vEndpointUrl.From(EndpointUrl);
                    ret.AddRange(vEndpointUrl.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUptimeScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUptimeScore.From(UptimeScore);
                    ret.AddRange(vUptimeScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vActive.From(Active);
                    ret.AddRange(vActive.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBadgeAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBadgeAppId.From(BadgeAppId);
                    ret.AddRange(vBadgeAppId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProviderInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ProviderInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVramGb = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVramGb.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVramGb = vVramGb.ToValue();
                    if (valueVramGb is ulong vVramGbValue) { ret.VramGb = vVramGbValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGpuModel = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vGpuModel.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGpuModel = vGpuModel.ToValue();
                    if (valueGpuModel is byte[] vGpuModelValue) { ret.GpuModel = vGpuModelValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPricePerHour = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPricePerHour.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePricePerHour = vPricePerHour.ToValue();
                    if (valuePricePerHour is ulong vPricePerHourValue) { ret.PricePerHour = vPricePerHourValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndpointUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vEndpointUrl.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEndpointUrl = vEndpointUrl.ToValue();
                    if (valueEndpointUrl is byte[] vEndpointUrlValue) { ret.EndpointUrl = vEndpointUrlValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUptimeScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUptimeScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUptimeScore = vUptimeScore.ToValue();
                    if (valueUptimeScore is ulong vUptimeScoreValue) { ret.UptimeScore = vUptimeScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActive = vActive.ToValue();
                    if (valueActive is ulong vActiveValue) { ret.Active = vActiveValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBadgeAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBadgeAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBadgeAppId = vBadgeAppId.ToValue();
                    if (valueBadgeAppId is ulong vBadgeAppIdValue) { ret.BadgeAppId = vBadgeAppIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProviderInfo);
                }
                public bool Equals(ProviderInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProviderInfo left, ProviderInfo right)
                {
                    return EqualityComparer<ProviderInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(ProviderInfo left, ProviderInfo right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="badge_app_id"> </param>
        public async Task SetBadgeAppId(ulong badge_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 86, 222, 218 };
            var badge_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); badge_app_idAbi.From(badge_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, badge_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBadgeAppId_Transactions(ulong badge_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 86, 222, 218 };
            var badge_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); badge_app_idAbi.From(badge_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, badge_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="vram_gb"> </param>
        /// <param name="gpu_model"> </param>
        /// <param name="price_per_hour"> </param>
        /// <param name="endpoint_url"> </param>
        public async Task RegisterProvider(ulong vram_gb, byte[] gpu_model, ulong price_per_hour, byte[] endpoint_url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 196, 152, 61 };
            var vram_gbAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vram_gbAbi.From(vram_gb);
            var gpu_modelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); gpu_modelAbi.From(gpu_model);
            var price_per_hourAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_per_hourAbi.From(price_per_hour);
            var endpoint_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); endpoint_urlAbi.From(endpoint_url);

            var result = await base.CallApp(new List<object> { abiHandle, vram_gbAbi, gpu_modelAbi, price_per_hourAbi, endpoint_urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterProvider_Transactions(ulong vram_gb, byte[] gpu_model, ulong price_per_hour, byte[] endpoint_url, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 196, 152, 61 };
            var vram_gbAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vram_gbAbi.From(vram_gb);
            var gpu_modelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); gpu_modelAbi.From(gpu_model);
            var price_per_hourAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); price_per_hourAbi.From(price_per_hour);
            var endpoint_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); endpoint_urlAbi.From(endpoint_url);

            return await base.MakeTransactionList(new List<object> { abiHandle, vram_gbAbi, gpu_modelAbi, price_per_hourAbi, endpoint_urlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DeregisterProvider(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 236, 175, 61 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeregisterProvider_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 236, 175, 61 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="provider"> </param>
        /// <param name="score"> </param>
        public async Task UpdateUptimeScore(Algorand.Address provider, ulong score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 153, 163, 253 };
            var providerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); providerAbi.From(provider);
            var scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scoreAbi.From(score);

            var result = await base.CallApp(new List<object> { abiHandle, providerAbi, scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateUptimeScore_Transactions(Algorand.Address provider, ulong score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 153, 163, 253 };
            var providerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); providerAbi.From(provider);
            var scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scoreAbi.From(score);

            return await base.MakeTransactionList(new List<object> { abiHandle, providerAbi, scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="provider"> </param>
        public async Task<Structs.ProviderInfo> GetProvider(Algorand.Address provider, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 103, 217, 63 };
            var providerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); providerAbi.From(provider);

            var result = await base.SimApp(new List<object> { abiHandle, providerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProviderInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetProvider_Transactions(Algorand.Address provider, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 103, 217, 63 };
            var providerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); providerAbi.From(provider);

            return await base.MakeTransactionList(new List<object> { abiHandle, providerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHJvdmlkZXJSZWdpc3RyeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7ImN1cnJlbnQiOnsiYXBwSUQiOjc1ODgxMzU2M319LCJzdHJ1Y3RzIjp7IlByb3ZpZGVySW5mbyI6W3sibmFtZSI6InZyYW1fZ2IiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZ3B1X21vZGVsIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6InByaWNlX3Blcl9ob3VyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImVuZHBvaW50X3VybCIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJ1cHRpbWVfc2NvcmUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWN0aXZlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImJhZGdlX2FwcF9pZCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoic2V0X2JhZGdlX2FwcF9pZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiYWRnZV9hcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXJfcHJvdmlkZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidnJhbV9nYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ3B1X21vZGVsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZV9wZXJfaG91ciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kcG9pbnRfdXJsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcmVnaXN0ZXJfcHJvdmlkZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX3VwdGltZV9zY29yZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvdmlkZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjb3JlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wcm92aWRlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvdmlkZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxieXRlW10sdWludDY0LGJ5dGVbXSx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJQcm92aWRlckluZm8iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTg4XSwiZXJyb3JNZXNzYWdlIjoiYmFkZ2UgY2hlY2sgZmFpbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgzLDE5Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYmFkZ2VfYXBwX2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2MiwyODUsMzEzLDMyMCw0MTQsNDM3LDQ2NSw0NzJdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQwLDE2NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0OSwxNzFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzgwLDUyOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTIsMTMyLDE1NywzODhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTldLCJlcnJvck1lc3NhZ2UiOiJvbmx5IGNyZWF0b3IgY2FuIHNldCBiYWRnZSBhcHAgaWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTVdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IGNyZWF0b3IgY2FuIHVwZGF0ZSB1cHRpbWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDQsNTM3XSwiZXJyb3JNZXNzYWdlIjoicHJvdmlkZXIgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU0XSwiZXJyb3JNZXNzYWdlIjoicHJvdmlkZXIgbm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTBdLCJlcnJvck1lc3NhZ2UiOiJzY29yZSBtdXN0IGJlIDAtMTAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBNElESWdNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TnpBM01qWm1OelkyT1RZME5qVTNNaUFpWW1Ga1oyVmZZWEJ3WDJsa0lpQXdlREF3TW1NS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WldkcGMzUnllUzV3ZVRveE53b2dJQ0FnTHk4Z2MyVnNaaTVpWVdSblpWOWhjSEJmYVdRZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSmhaR2RsWDJGd2NGOXBaQ0lLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVm5hWE4wY25rdWNIazZNVFFLSUNBZ0lDOHZJR05zWVhOeklGQnliM1pwWkdWeVVtVm5hWE4wY25rb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnd1pUVTJaR1ZrWVNBd2VEY3hZelE1T0ROa0lEQjRObVJsWTJGbU0yUWdNSGc0TURrNVlUTm1aQ0F3ZURka05qZGtPVE5tSUM4dklHMWxkR2h2WkNBaWMyVjBYMkpoWkdkbFgyRndjRjlwWkNoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljbVZuYVhOMFpYSmZjSEp2ZG1sa1pYSW9kV2x1ZERZMExHSjVkR1ZiWFN4MWFXNTBOalFzWW5sMFpWdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltUmxjbVZuYVhOMFpYSmZjSEp2ZG1sa1pYSW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0luVndaR0YwWlY5MWNIUnBiV1ZmYzJOdmNtVW9ZV1JrY21WemN5eDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzQnliM1pwWkdWeUtHRmtaSEpsYzNNcEtIVnBiblEyTkN4aWVYUmxXMTBzZFdsdWREWTBMR0o1ZEdWYlhTeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCelpYUmZZbUZrWjJWZllYQndYMmxrSUhKbFoybHpkR1Z5WDNCeWIzWnBaR1Z5SUdSbGNtVm5hWE4wWlhKZmNISnZkbWxrWlhJZ2RYQmtZWFJsWDNWd2RHbHRaVjl6WTI5eVpTQm5aWFJmY0hKdmRtbGtaWElLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE5Eb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekxuSmxaMmx6ZEhKNUxsQnliM1pwWkdWeVVtVm5hWE4wY25rdWMyVjBYMkpoWkdkbFgyRndjRjlwWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjlpWVdSblpWOWhjSEJmYVdRNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVm5hWE4wY25rdWNIazZNVGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMbkI1T2pJeENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaWIyNXNlU0JqY21WaGRHOXlJR05oYmlCelpYUWdZbUZrWjJVZ1lYQndJR2xrSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIa2dZM0psWVhSdmNpQmpZVzRnYzJWMElHSmhaR2RsSUdGd2NDQnBaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMbkI1T2pJeUNpQWdJQ0F2THlCelpXeG1MbUpoWkdkbFgyRndjRjlwWkNBOUlHSmhaR2RsWDJGd2NGOXBaQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZbUZrWjJWZllYQndYMmxrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM1d2VUb3hPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TG5KbFoybHpkSEo1TGxCeWIzWnBaR1Z5VW1WbmFYTjBjbmt1Y21WbmFYTjBaWEpmY0hKdmRtbGtaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXZHBjM1JsY2w5d2NtOTJhV1JsY2pvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM1d2VUb3lOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQnVJRElLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM1d2VUb3pNaTB6TXdvZ0lDQWdMeThnSXlCVVQwUlBPaUJTWlhCc1lXTmxJSFJvYVhNZ1kzSmxZWFJ2Y2lCaWVYQmhjM01nZDJsMGFDQnBibTVsY2lCaGNIQWdZMkZzYkNCMGJ5QkNZV1JuWlUxcGJuUmxjaTUyWlhKcFpubGZZbUZrWjJVdUNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56SUc5eUlITmxiR1l1WW1Ga1oyVmZZWEJ3WDJsa0lENGdWVWx1ZERZMEtEQXBMQ0FpWW1Ga1oyVWdZMmhsWTJzZ1ptRnBiR1ZrSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1oyeHZZbUZzSUVOeVpXRjBiM0pCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWW01NklISmxaMmx6ZEdWeVgzQnliM1pwWkdWeVgySnZiMnhmZEhKMVpVQXpDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVltRmtaMlZmWVhCd1gybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1KaFpHZGxYMkZ3Y0Y5cFpDQmxlR2x6ZEhNS0lDQWdJR0o2SUhKbFoybHpkR1Z5WDNCeWIzWnBaR1Z5WDJKdmIyeGZabUZzYzJWQU5Bb0tjbVZuYVhOMFpYSmZjSEp2ZG1sa1pYSmZZbTl2YkY5MGNuVmxRRE02Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9LY21WbmFYTjBaWEpmY0hKdmRtbGtaWEpmWW05dmJGOXRaWEpuWlVBMU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUxuQjVPak15TFRNekNpQWdJQ0F2THlBaklGUlBSRTg2SUZKbGNHeGhZMlVnZEdocGN5QmpjbVZoZEc5eUlHSjVjR0Z6Y3lCM2FYUm9JR2x1Ym1WeUlHRndjQ0JqWVd4c0lIUnZJRUpoWkdkbFRXbHVkR1Z5TG5abGNtbG1lVjlpWVdSblpTNEtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNZ2IzSWdjMlZzWmk1aVlXUm5aVjloY0hCZmFXUWdQaUJWU1c1ME5qUW9NQ2tzSUNKaVlXUm5aU0JqYUdWamF5Qm1ZV2xzWldRaUNpQWdJQ0JoYzNObGNuUWdMeThnWW1Ga1oyVWdZMmhsWTJzZ1ptRnBiR1ZrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21WbmFYTjBjbmt1Y0hrNk5ESUtJQ0FnSUM4dklHSmhaR2RsWDJGd2NGOXBaRDF6Wld4bUxtSmhaR2RsWDJGd2NGOXBaQ3dLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmlZV1JuWlY5aGNIQmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVltRmtaMlZmWVhCd1gybGtJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUxuQjVPak0xTFRRekNpQWdJQ0F2THlCelpXeG1MbkJ5YjNacFpHVnljMXRVZUc0dWMyVnVaR1Z5WFNBOUlGQnliM1pwWkdWeVNXNW1ieWdLSUNBZ0lDOHZJQ0FnSUNCMmNtRnRYMmRpUFhaeVlXMWZaMklzQ2lBZ0lDQXZMeUFnSUNBZ1ozQjFYMjF2WkdWc1BXZHdkVjl0YjJSbGJDNWpiM0I1S0Nrc0NpQWdJQ0F2THlBZ0lDQWdjSEpwWTJWZmNHVnlYMmh2ZFhJOWNISnBZMlZmY0dWeVgyaHZkWElzQ2lBZ0lDQXZMeUFnSUNBZ1pXNWtjRzlwYm5SZmRYSnNQV1Z1WkhCdmFXNTBYM1Z5YkM1amIzQjVLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RYQjBhVzFsWDNOamIzSmxQVlZKYm5RMk5DZ3hNREFwTEFvZ0lDQWdMeThnSUNBZ0lHRmpkR2wyWlQxVlNXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lDQWdZbUZrWjJWZllYQndYMmxrUFhObGJHWXVZbUZrWjJWZllYQndYMmxrTEFvZ0lDQWdMeThnS1FvZ0lDQWdaR2xuSURVS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01ESmpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhwYm5RZ05EUUtJQ0FnSUdScFp5QTFDaUFnSUNBckNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM1d2VUbzBNQW9nSUNBZ0x5OGdkWEIwYVcxbFgzTmpiM0psUFZWSmJuUTJOQ2d4TURBcExBb2dJQ0FnY0hWemFHbHVkQ0F4TURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM1d2VUb3pOUzAwTXdvZ0lDQWdMeThnYzJWc1ppNXdjbTkyYVdSbGNuTmJWSGh1TG5ObGJtUmxjbDBnUFNCUWNtOTJhV1JsY2tsdVptOG9DaUFnSUNBdkx5QWdJQ0FnZG5KaGJWOW5ZajEyY21GdFgyZGlMQW9nSUNBZ0x5OGdJQ0FnSUdkd2RWOXRiMlJsYkQxbmNIVmZiVzlrWld3dVkyOXdlU2dwTEFvZ0lDQWdMeThnSUNBZ0lIQnlhV05sWDNCbGNsOW9iM1Z5UFhCeWFXTmxYM0JsY2w5b2IzVnlMQW9nSUNBZ0x5OGdJQ0FnSUdWdVpIQnZhVzUwWDNWeWJEMWxibVJ3YjJsdWRGOTFjbXd1WTI5d2VTZ3BMQW9nSUNBZ0x5OGdJQ0FnSUhWd2RHbHRaVjl6WTI5eVpUMVZTVzUwTmpRb01UQXdLU3dLSUNBZ0lDOHZJQ0FnSUNCaFkzUnBkbVU5VlVsdWREWTBLREVwTEFvZ0lDQWdMeThnSUNBZ0lHSmhaR2RsWDJGd2NGOXBaRDF6Wld4bUxtSmhaR2RsWDJGd2NGOXBaQ3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TG5CNU9qUXhDaUFnSUNBdkx5QmhZM1JwZG1VOVZVbHVkRFkwS0RFcExBb2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM1d2VUb3pOUzAwTXdvZ0lDQWdMeThnYzJWc1ppNXdjbTkyYVdSbGNuTmJWSGh1TG5ObGJtUmxjbDBnUFNCUWNtOTJhV1JsY2tsdVptOG9DaUFnSUNBdkx5QWdJQ0FnZG5KaGJWOW5ZajEyY21GdFgyZGlMQW9nSUNBZ0x5OGdJQ0FnSUdkd2RWOXRiMlJsYkQxbmNIVmZiVzlrWld3dVkyOXdlU2dwTEFvZ0lDQWdMeThnSUNBZ0lIQnlhV05sWDNCbGNsOW9iM1Z5UFhCeWFXTmxYM0JsY2w5b2IzVnlMQW9nSUNBZ0x5OGdJQ0FnSUdWdVpIQnZhVzUwWDNWeWJEMWxibVJ3YjJsdWRGOTFjbXd1WTI5d2VTZ3BMQW9nSUNBZ0x5OGdJQ0FnSUhWd2RHbHRaVjl6WTI5eVpUMVZTVzUwTmpRb01UQXdLU3dLSUNBZ0lDOHZJQ0FnSUNCaFkzUnBkbVU5VlVsdWREWTBLREVwTEFvZ0lDQWdMeThnSUNBZ0lHSmhaR2RsWDJGd2NGOXBaRDF6Wld4bUxtSmhaR2RsWDJGd2NGOXBaQ3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21WbmFYTjBjbmt1Y0hrNk16VUtJQ0FnSUM4dklITmxiR1l1Y0hKdmRtbGtaWEp6VzFSNGJpNXpaVzVrWlhKZElEMGdVSEp2ZG1sa1pYSkpibVp2S0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURjd056STJaamMyTmprMk5EWTFOeklLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMbkI1T2pNMUxUUXpDaUFnSUNBdkx5QnpaV3htTG5CeWIzWnBaR1Z5YzF0VWVHNHVjMlZ1WkdWeVhTQTlJRkJ5YjNacFpHVnlTVzVtYnlnS0lDQWdJQzh2SUNBZ0lDQjJjbUZ0WDJkaVBYWnlZVzFmWjJJc0NpQWdJQ0F2THlBZ0lDQWdaM0IxWDIxdlpHVnNQV2R3ZFY5dGIyUmxiQzVqYjNCNUtDa3NDaUFnSUNBdkx5QWdJQ0FnY0hKcFkyVmZjR1Z5WDJodmRYSTljSEpwWTJWZmNHVnlYMmh2ZFhJc0NpQWdJQ0F2THlBZ0lDQWdaVzVrY0c5cGJuUmZkWEpzUFdWdVpIQnZhVzUwWDNWeWJDNWpiM0I1S0Nrc0NpQWdJQ0F2THlBZ0lDQWdkWEIwYVcxbFgzTmpiM0psUFZWSmJuUTJOQ2d4TURBcExBb2dJQ0FnTHk4Z0lDQWdJR0ZqZEdsMlpUMVZTVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnWW1Ga1oyVmZZWEJ3WDJsa1BYTmxiR1l1WW1Ga1oyVmZZWEJ3WDJsa0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WldkcGMzUnllUzV3ZVRveU5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dweVpXZHBjM1JsY2w5d2NtOTJhV1JsY2w5aWIyOXNYMlpoYkhObFFEUTZDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWWlCeVpXZHBjM1JsY2w5d2NtOTJhV1JsY2w5aWIyOXNYMjFsY21kbFFEVUtDZ292THlCamIyNTBjbUZqZEhNdWNtVm5hWE4wY25rdVVISnZkbWxrWlhKU1pXZHBjM1J5ZVM1a1pYSmxaMmx6ZEdWeVgzQnliM1pwWkdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1Z5WldkcGMzUmxjbDl3Y205MmFXUmxjam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WldkcGMzUnllUzV3ZVRvME53b2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ2FXNGdjMlZzWmk1d2NtOTJhV1JsY25Nc0lDSndjbTkyYVdSbGNpQnViM1FnY21WbmFYTjBaWEpsWkNJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnM01EY3lObVkzTmpZNU5qUTJOVGN5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUhCeWIzWnBaR1Z5SUc1dmRDQnlaV2RwYzNSbGNtVmtDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZuYVhOMGNua3VjSGs2TkRnS0lDQWdJQzh2SUdSaGRHRWdQU0J6Wld4bUxuQnliM1pwWkdWeWMxdFVlRzR1YzJWdVpHVnlYUzVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzNNRGN5Tm1ZM05qWTVOalEyTlRjeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM1d2VUbzFNQW9nSUNBZ0x5OGdkbkpoYlY5bllqMWtZWFJoTG5aeVlXMWZaMklzQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WldkcGMzUnllUzV3ZVRvMU1Rb2dJQ0FnTHk4Z1ozQjFYMjF2WkdWc1BXUmhkR0V1WjNCMVgyMXZaR1ZzTG1OdmNIa29LU3dLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElEUTBDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBME5Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMbkI1T2pVeUNpQWdJQ0F2THlCd2NtbGpaVjl3WlhKZmFHOTFjajFrWVhSaExuQnlhV05sWDNCbGNsOW9iM1Z5TEFvZ0lDQWdaR2xuSURJS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TG5CNU9qVXpDaUFnSUNBdkx5QmxibVJ3YjJsdWRGOTFjbXc5WkdGMFlTNWxibVJ3YjJsdWRGOTFjbXd1WTI5d2VTZ3BMQW9nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ01UZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdaR2xuSURRS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXlaV2RwYzNSeWVTNXdlVG8xTkFvZ0lDQWdMeThnZFhCMGFXMWxYM05qYjNKbFBXUmhkR0V1ZFhCMGFXMWxYM05qYjNKbExBb2dJQ0FnWkdsbklEUUtJQ0FnSUhCMWMyaHBiblFnTWpBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUxuQjVPalUyQ2lBZ0lDQXZMeUJpWVdSblpWOWhjSEJmYVdROVpHRjBZUzVpWVdSblpWOWhjSEJmYVdRc0NpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lIQjFjMmhwYm5RZ016WUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMbkI1T2pRNUxUVTNDaUFnSUNBdkx5QnpaV3htTG5CeWIzWnBaR1Z5YzF0VWVHNHVjMlZ1WkdWeVhTQTlJRkJ5YjNacFpHVnlTVzVtYnlnS0lDQWdJQzh2SUNBZ0lDQjJjbUZ0WDJkaVBXUmhkR0V1ZG5KaGJWOW5ZaXdLSUNBZ0lDOHZJQ0FnSUNCbmNIVmZiVzlrWld3OVpHRjBZUzVuY0hWZmJXOWtaV3d1WTI5d2VTZ3BMQW9nSUNBZ0x5OGdJQ0FnSUhCeWFXTmxYM0JsY2w5b2IzVnlQV1JoZEdFdWNISnBZMlZmY0dWeVgyaHZkWElzQ2lBZ0lDQXZMeUFnSUNBZ1pXNWtjRzlwYm5SZmRYSnNQV1JoZEdFdVpXNWtjRzlwYm5SZmRYSnNMbU52Y0hrb0tTd0tJQ0FnSUM4dklDQWdJQ0IxY0hScGJXVmZjMk52Y21VOVpHRjBZUzUxY0hScGJXVmZjMk52Y21Vc0NpQWdJQ0F2THlBZ0lDQWdZV04wYVhabFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JpWVdSblpWOWhjSEJmYVdROVpHRjBZUzVpWVdSblpWOWhjSEJmYVdRc0NpQWdJQ0F2THlBcENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURKakNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTFDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTkRRS0lDQWdJQ3NLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21WbmFYTjBjbmt1Y0hrNk5UVUtJQ0FnSUM4dklHRmpkR2wyWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TG5CNU9qUTVMVFUzQ2lBZ0lDQXZMeUJ6Wld4bUxuQnliM1pwWkdWeWMxdFVlRzR1YzJWdVpHVnlYU0E5SUZCeWIzWnBaR1Z5U1c1bWJ5Z0tJQ0FnSUM4dklDQWdJQ0IyY21GdFgyZGlQV1JoZEdFdWRuSmhiVjluWWl3S0lDQWdJQzh2SUNBZ0lDQm5jSFZmYlc5a1pXdzlaR0YwWVM1bmNIVmZiVzlrWld3dVkyOXdlU2dwTEFvZ0lDQWdMeThnSUNBZ0lIQnlhV05sWDNCbGNsOW9iM1Z5UFdSaGRHRXVjSEpwWTJWZmNHVnlYMmh2ZFhJc0NpQWdJQ0F2THlBZ0lDQWdaVzVrY0c5cGJuUmZkWEpzUFdSaGRHRXVaVzVrY0c5cGJuUmZkWEpzTG1OdmNIa29LU3dLSUNBZ0lDOHZJQ0FnSUNCMWNIUnBiV1ZmYzJOdmNtVTlaR0YwWVM1MWNIUnBiV1ZmYzJOdmNtVXNDaUFnSUNBdkx5QWdJQ0FnWVdOMGFYWmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCaVlXUm5aVjloY0hCZmFXUTlaR0YwWVM1aVlXUm5aVjloY0hCZmFXUXNDaUFnSUNBdkx5QXBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TG5CNU9qUTVDaUFnSUNBdkx5QnpaV3htTG5CeWIzWnBaR1Z5YzF0VWVHNHVjMlZ1WkdWeVhTQTlJRkJ5YjNacFpHVnlTVzVtYnlnS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnM01EY3lObVkzTmpZNU5qUTJOVGN5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WldkcGMzUnllUzV3ZVRvME9TMDFOd29nSUNBZ0x5OGdjMlZzWmk1d2NtOTJhV1JsY25OYlZIaHVMbk5sYm1SbGNsMGdQU0JRY205MmFXUmxja2x1Wm04b0NpQWdJQ0F2THlBZ0lDQWdkbkpoYlY5bllqMWtZWFJoTG5aeVlXMWZaMklzQ2lBZ0lDQXZMeUFnSUNBZ1ozQjFYMjF2WkdWc1BXUmhkR0V1WjNCMVgyMXZaR1ZzTG1OdmNIa29LU3dLSUNBZ0lDOHZJQ0FnSUNCd2NtbGpaVjl3WlhKZmFHOTFjajFrWVhSaExuQnlhV05sWDNCbGNsOW9iM1Z5TEFvZ0lDQWdMeThnSUNBZ0lHVnVaSEJ2YVc1MFgzVnliRDFrWVhSaExtVnVaSEJ2YVc1MFgzVnliQzVqYjNCNUtDa3NDaUFnSUNBdkx5QWdJQ0FnZFhCMGFXMWxYM05qYjNKbFBXUmhkR0V1ZFhCMGFXMWxYM05qYjNKbExBb2dJQ0FnTHk4Z0lDQWdJR0ZqZEdsMlpUMVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWW1Ga1oyVmZZWEJ3WDJsa1BXUmhkR0V1WW1Ga1oyVmZZWEJ3WDJsa0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WldkcGMzUnllUzV3ZVRvME5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMbkpsWjJsemRISjVMbEJ5YjNacFpHVnlVbVZuYVhOMGNua3VkWEJrWVhSbFgzVndkR2x0WlY5elkyOXlaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25Wd1pHRjBaVjkxY0hScGJXVmZjMk52Y21VNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVm5hWE4wY25rdWNIazZOVGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUxuQjVPall4Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQ0FpYjI1c2VTQmpjbVZoZEc5eUlHTmhiaUIxY0dSaGRHVWdkWEIwYVcxbElnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaMnh2WW1Gc0lFTnlaV0YwYjNKQlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2RYQmtZWFJsSUhWd2RHbHRaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMbkI1T2pZeUNpQWdJQ0F2THlCaGMzTmxjblFnY0hKdmRtbGtaWElnYVc0Z2MyVnNaaTV3Y205MmFXUmxjbk1zSUNKd2NtOTJhV1JsY2lCdWIzUWdabTkxYm1RaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE56QTNNalptTnpZMk9UWTBOalUzTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnY0hKdmRtbGtaWElnYm05MElHWnZkVzVrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21WbmFYTjBjbmt1Y0hrNk5qTUtJQ0FnSUM4dklHRnpjMlZ5ZENCelkyOXlaU0E4UFNCVlNXNTBOalFvTVRBd0tTd2dJbk5qYjNKbElHMTFjM1FnWW1VZ01DMHhNREFpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXhNREFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2MyTnZjbVVnYlhWemRDQmlaU0F3TFRFd01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzSmxaMmx6ZEhKNUxuQjVPalkzQ2lBZ0lDQXZMeUIyY21GdFgyZGlQV1JoZEdFdWRuSmhiVjluWWl3S0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TG5CNU9qWTRDaUFnSUNBdkx5Qm5jSFZmYlc5a1pXdzlaR0YwWVM1bmNIVmZiVzlrWld3dVkyOXdlU2dwTEFvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdORFFLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElEUTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y21WbmFYTjBjbmt1Y0hrNk5qa0tJQ0FnSUM4dklIQnlhV05sWDNCbGNsOW9iM1Z5UFdSaGRHRXVjSEpwWTJWZmNHVnlYMmh2ZFhJc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVm5hWE4wY25rdWNIazZOekFLSUNBZ0lDOHZJR1Z1WkhCdmFXNTBYM1Z5YkQxa1lYUmhMbVZ1WkhCdmFXNTBYM1Z5YkM1amIzQjVLQ2tzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdsdWRDQXhPQW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QTFDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMbkI1T2pjeUNpQWdJQ0F2THlCaFkzUnBkbVU5WkdGMFlTNWhZM1JwZG1Vc0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnY0hWemFHbHVkQ0F5T0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNtVm5hWE4wY25rdWNIazZOek1LSUNBZ0lDOHZJR0poWkdkbFgyRndjRjlwWkQxa1lYUmhMbUpoWkdkbFgyRndjRjlwWkN3S0lDQWdJR1JwWnlBMUNpQWdJQ0J3ZFhOb2FXNTBJRE0yQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5eVpXZHBjM1J5ZVM1d2VUbzJOaTAzTkFvZ0lDQWdMeThnYzJWc1ppNXdjbTkyYVdSbGNuTmJjSEp2ZG1sa1pYSmRJRDBnVUhKdmRtbGtaWEpKYm1adktBb2dJQ0FnTHk4Z0lDQWdJSFp5WVcxZloySTlaR0YwWVM1MmNtRnRYMmRpTEFvZ0lDQWdMeThnSUNBZ0lHZHdkVjl0YjJSbGJEMWtZWFJoTG1kd2RWOXRiMlJsYkM1amIzQjVLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2NISnBZMlZmY0dWeVgyaHZkWEk5WkdGMFlTNXdjbWxqWlY5d1pYSmZhRzkxY2l3S0lDQWdJQzh2SUNBZ0lDQmxibVJ3YjJsdWRGOTFjbXc5WkdGMFlTNWxibVJ3YjJsdWRGOTFjbXd1WTI5d2VTZ3BMQW9nSUNBZ0x5OGdJQ0FnSUhWd2RHbHRaVjl6WTI5eVpUMXpZMjl5WlN3S0lDQWdJQzh2SUNBZ0lDQmhZM1JwZG1VOVpHRjBZUzVoWTNScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWW1Ga1oyVmZZWEJ3WDJsa1BXUmhkR0V1WW1Ga1oyVmZZWEJ3WDJsa0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBeVl3b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOUW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURRMENpQWdJQ0FyQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMbkI1T2pVNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXVjbVZuYVhOMGNua3VVSEp2ZG1sa1pYSlNaV2RwYzNSeWVTNW5aWFJmY0hKdmRtbGtaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZjSEp2ZG1sa1pYSTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjbVZuYVhOMGNua3VjSGs2TnpZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNKbFoybHpkSEo1TG5CNU9qYzRDaUFnSUNBdkx5QmhjM05sY25RZ2NISnZkbWxrWlhJZ2FXNGdjMlZzWmk1d2NtOTJhV1JsY25Nc0lDSndjbTkyYVdSbGNpQnViM1FnWm05MWJtUWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROekEzTWpabU56WTJPVFkwTmpVM01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJSEJ5YjNacFpHVnlJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0psWjJsemRISjVMbkI1T2pjNUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXdjbTkyYVdSbGNuTmJjSEp2ZG1sa1pYSmRDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl5WldkcGMzUnllUzV3ZVRvM05nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNeUF2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQ0FJQUFTWURDSEJ5YjNacFpHVnlER0poWkdkbFgyRndjRjlwWkFJQUxERVlRQUFES1NSbk1SdEJBREl4R1JSRU1SaEVnZ1VFRGxiZTJnUnh4Smc5Qkczc3J6MEVnSm1qL1FSOVo5ay9OaG9BamdVQUNRQWRBSmNCRkFHcEFERVpGREVZRkJCRE5ob0JTUlVpRWtRWE1RQXlDUkpFS1V4bkpVTTJHZ0ZKRlNJU1JCYzJHZ0pIQWlSWkl3aE1GVWxQQWhKRU5ob0RTUlVpRWtRWE5ob0VSd0lrV1NNSVRCVVNSREVBTWdrU1FBQUhKQ2xsUkVFQU9DVkVKQ2xsUkVzRkZpcFFnU3hMQlFoTEJCWlBBa3hRVEJaWEJnSlFnV1FXVUNVV1VFd1dVRXNFVUVzQlVDZ3hBRkJKdkVoTXZ5VkRKRUwveFNneEFGQzlSUUZFS0RFQVVFa2tJcm9YU3dHQkxDTzZGeU1JU3dLQkxFOEN1a3NDZ1FvaXVoZExBNEVTSTdvWFN3UkxBU082RnlNSVN3Vk9BcnBMQklFVUlyb1hUd1dCSkNLNkYwOEZGaXBRU3dVVmdTd0lUd1VXVHdKTVVFd1dWd1lDVUU4Q0ZsQWtGbEJNRmxCUEFsQk1VQ2d4QUZCSnZFaE12eVZETmhvQlNSV0JJQkpFTmhvQ1NSVWlFa1FYTVFBeUNSSkVLRThDVUVtOVJRRkVTd0dCWkE1RVNTUWl1aGRMQVlFc0k3b1hJd2hMQW9Fc1R3SzZTd0tCQ2lLNkYwc0RnUklqdWhkTEJFc0JJN29YSXdoTEJVNEN1a3NFZ1J3aXVoZExCWUVrSXJvWFR3VVdLbEJMQlJXQkxBaFBCUlpQQWt4UVRCWlhCZ0pRVHdZV1VFOENGbEJNRmxCUEFsQk1VRXNCdkVpL0pVTTJHZ0ZKRllFZ0VrUW9URkJKdlVVQlJMNUlnQVFWSDN4MVRGQ3dKVU09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
