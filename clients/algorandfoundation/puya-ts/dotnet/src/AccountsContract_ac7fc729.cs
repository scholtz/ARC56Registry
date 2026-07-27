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

namespace Arc56.Generated.algorandfoundation.puya_ts.AccountsContract_ac7fc729
{


    public class AccountsContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AccountsContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Object3B1036D9 : AVMObjectType
            {
                public byte[] Bytes { get; set; }

                public ulong Balance { get; set; }

                public ulong MinBalance { get; set; }

                public byte[] AuthAddress { get; set; }

                public ulong TotalNumUint { get; set; }

                public ulong TotalNumByteSlice { get; set; }

                public ulong TotalExtraAppPages { get; set; }

                public ulong TotalAppsCreated { get; set; }

                public ulong TotalAppsOptedIn { get; set; }

                public ulong TotalAssetsCreated { get; set; }

                public ulong TotalAssets { get; set; }

                public ulong TotalBoxes { get; set; }

                public ulong TotalBoxBytes { get; set; }

                public bool IsOptInApp { get; set; }

                public bool IsOptInAsset { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vBytes.From(Bytes);
                    ret.AddRange(vBytes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBalance.From(Balance);
                    ret.AddRange(vBalance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMinBalance.From(MinBalance);
                    ret.AddRange(vMinBalance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuthAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vAuthAddress.From(AuthAddress);
                    ret.AddRange(vAuthAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalNumUint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalNumUint.From(TotalNumUint);
                    ret.AddRange(vTotalNumUint.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalNumByteSlice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalNumByteSlice.From(TotalNumByteSlice);
                    ret.AddRange(vTotalNumByteSlice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalExtraAppPages = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalExtraAppPages.From(TotalExtraAppPages);
                    ret.AddRange(vTotalExtraAppPages.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAppsCreated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalAppsCreated.From(TotalAppsCreated);
                    ret.AddRange(vTotalAppsCreated.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAppsOptedIn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalAppsOptedIn.From(TotalAppsOptedIn);
                    ret.AddRange(vTotalAppsOptedIn.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAssetsCreated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalAssetsCreated.From(TotalAssetsCreated);
                    ret.AddRange(vTotalAssetsCreated.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalAssets.From(TotalAssets);
                    ret.AddRange(vTotalAssets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBoxes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalBoxes.From(TotalBoxes);
                    ret.AddRange(vTotalBoxes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBoxBytes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalBoxBytes.From(TotalBoxBytes);
                    ret.AddRange(vTotalBoxBytes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsOptInApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsOptInApp.From(IsOptInApp);
                    ret.AddRange(vIsOptInApp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsOptInAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsOptInAsset.From(IsOptInAsset);
                    ret.AddRange(vIsOptInAsset.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Object3B1036D9 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Object3B1036D9();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBytes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vBytes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBytes = vBytes.ToValue();
                    if (valueBytes is byte[] vBytesValue) { ret.Bytes = vBytesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBalance = vBalance.ToValue();
                    if (valueBalance is ulong vBalanceValue) { ret.Balance = vBalanceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMinBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinBalance = vMinBalance.ToValue();
                    if (valueMinBalance is ulong vMinBalanceValue) { ret.MinBalance = vMinBalanceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuthAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vAuthAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAuthAddress = vAuthAddress.ToValue();
                    if (valueAuthAddress is byte[] vAuthAddressValue) { ret.AuthAddress = vAuthAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalNumUint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalNumUint.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalNumUint = vTotalNumUint.ToValue();
                    if (valueTotalNumUint is ulong vTotalNumUintValue) { ret.TotalNumUint = vTotalNumUintValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalNumByteSlice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalNumByteSlice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalNumByteSlice = vTotalNumByteSlice.ToValue();
                    if (valueTotalNumByteSlice is ulong vTotalNumByteSliceValue) { ret.TotalNumByteSlice = vTotalNumByteSliceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalExtraAppPages = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalExtraAppPages.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalExtraAppPages = vTotalExtraAppPages.ToValue();
                    if (valueTotalExtraAppPages is ulong vTotalExtraAppPagesValue) { ret.TotalExtraAppPages = vTotalExtraAppPagesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAppsCreated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalAppsCreated.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalAppsCreated = vTotalAppsCreated.ToValue();
                    if (valueTotalAppsCreated is ulong vTotalAppsCreatedValue) { ret.TotalAppsCreated = vTotalAppsCreatedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAppsOptedIn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalAppsOptedIn.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalAppsOptedIn = vTotalAppsOptedIn.ToValue();
                    if (valueTotalAppsOptedIn is ulong vTotalAppsOptedInValue) { ret.TotalAppsOptedIn = vTotalAppsOptedInValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAssetsCreated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalAssetsCreated.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalAssetsCreated = vTotalAssetsCreated.ToValue();
                    if (valueTotalAssetsCreated is ulong vTotalAssetsCreatedValue) { ret.TotalAssetsCreated = vTotalAssetsCreatedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalAssets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalAssets = vTotalAssets.ToValue();
                    if (valueTotalAssets is ulong vTotalAssetsValue) { ret.TotalAssets = vTotalAssetsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBoxes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalBoxes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalBoxes = vTotalBoxes.ToValue();
                    if (valueTotalBoxes is ulong vTotalBoxesValue) { ret.TotalBoxes = vTotalBoxesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBoxBytes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalBoxBytes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalBoxBytes = vTotalBoxBytes.ToValue();
                    if (valueTotalBoxBytes is ulong vTotalBoxBytesValue) { ret.TotalBoxBytes = vTotalBoxBytesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsOptInApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsOptInApp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsOptInApp = vIsOptInApp.ToValue();
                    if (valueIsOptInApp is bool vIsOptInAppValue) { ret.IsOptInApp = vIsOptInAppValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsOptInAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsOptInAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsOptInAsset = vIsOptInAsset.ToValue();
                    if (valueIsOptInAsset is bool vIsOptInAssetValue) { ret.IsOptInAsset = vIsOptInAssetValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Object3B1036D9);
                }
                public bool Equals(Object3B1036D9? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Object3B1036D9 left, Object3B1036D9 right)
                {
                    return EqualityComparer<Object3B1036D9>.Default.Equals(left, right);
                }
                public static bool operator !=(Object3B1036D9 left, Object3B1036D9 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        /// <param name="asset"> </param>
        public async Task<Structs.Object3B1036D9> GetAccountInfo(Algorand.Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 222, 229, 159 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Object3B1036D9.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAccountInfo_Transactions(Algorand.Address account, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 222, 229, 159 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OtherAccount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 41, 67, 209 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OtherAccount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 41, 67, 209 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWNjb3VudHNDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJPYmplY3QzQjEwMzZEOSI6W3sibmFtZSI6ImJ5dGVzIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoiYmFsYW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtaW5CYWxhbmNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImF1dGhBZGRyZXNzIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoidG90YWxOdW1VaW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsTnVtQnl0ZVNsaWNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsRXh0cmFBcHBQYWdlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbEFwcHNDcmVhdGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsQXBwc09wdGVkSW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxBc3NldHNDcmVhdGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsQXNzZXRzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsQm94ZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxCb3hCeXRlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpc09wdEluQXBwIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJpc09wdEluQXNzZXQiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRBY2NvdW50SW5mbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbMzJdLHVpbnQ2NCx1aW50NjQsYnl0ZVszMl0sdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCxib29sKSIsInN0cnVjdCI6Ik9iamVjdDNCMTAzNkQ5IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3RoZXJBY2NvdW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTAxLDEwNiwxMTEsMTE2LDEyMSwxMjYsMTMxLDEzNiwxNDEsMTQ2LDE1MSwxNTZdLCJlcnJvck1lc3NhZ2UiOiJhY2NvdW50IGZ1bmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TURZNE1UQXhDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXTmpiM1Z1ZEhNdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRV05qYjNWdWRITkRiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUE1Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd3WVdSbFpUVTVaaUF3ZUdZMk1qazBNMlF4SUM4dklHMWxkR2h2WkNBaVoyVjBRV05qYjNWdWRFbHVabThvWVdSa2NtVnpjeXgxYVc1ME5qUXBLR0o1ZEdWYk16SmRMSFZwYm5RMk5DeDFhVzUwTmpRc1lubDBaVnN6TWwwc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiQ3hpYjI5c0tTSXNJRzFsZEdodlpDQWliM1JvWlhKQlkyTnZkVzUwS0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOW5aWFJCWTJOdmRXNTBTVzVtYjE5eWIzVjBaVUEwSUcxaGFXNWZiM1JvWlhKQlkyTnZkVzUwWDNKdmRYUmxRRFVLSUNBZ0lHVnljZ29LYldGcGJsOXZkR2hsY2tGalkyOTFiblJmY205MWRHVkFOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZMk52ZFc1MGN5NWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QndkV0pzYVdNZ2IzUm9aWEpCWTJOdmRXNTBLQ2tnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSQlkyTnZkVzUwU1c1bWIxOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGalkyOTFiblJ6TG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnY0hWaWJHbGpJR2RsZEVGalkyOTFiblJKYm1adktHRmpZMjkxYm5RNklFRmpZMjkxYm5Rc0lHRnpjMlYwT2lCQmMzTmxkQ2tnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLQ20xaGFXNWZkMmhwYkdWZmRHOXdRREV4T2dvZ0lDQWdjSFZ6YUdsdWRDQXhOREV3Q2lBZ0lDQm5iRzlpWVd3Z1QzQmpiMlJsUW5Wa1oyVjBDaUFnSUNBK0NpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgzZG9hV3hsUURFMkNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdjSFZ6YUdsdWRDQTFJQzh2SUVSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBMk9ERXdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJ5YjNaaGJGQnliMmR5WVcwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd05qZ3hNREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR0lnYldGcGJsOTNhR2xzWlY5MGIzQkFNVEVLQ20xaGFXNWZZV1owWlhKZmQyaHBiR1ZBTVRZNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdOamIzVnVkSE11WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWW1Gc1lXNWpaVG9nWVdOamIzVnVkQzVpWVd4aGJtTmxMQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFSmhiR0Z1WTJVS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGalkyOTFiblJ6TG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUcxcGJrSmhiR0Z1WTJVNklHRmpZMjkxYm5RdWJXbHVRbUZzWVc1alpTd0tJQ0FnSUdScFp5QXhDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFMXBia0poYkdGdVkyVUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmpZMjkxYm5SekxtRnNaMjh1ZEhNNk1UVUtJQ0FnSUM4dklHRjFkR2hCWkdSeVpYTnpPaUJoWTJOdmRXNTBMbUYxZEdoQlpHUnlaWE56TG1KNWRHVnpMQW9nSUNBZ1pHbG5JRElLSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBRWFYwYUVGa1pISUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmpZMjkxYm5SekxtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklIUnZkR0ZzVG5WdFZXbHVkRG9nWVdOamIzVnVkQzUwYjNSaGJFNTFiVlZwYm5Rc0NpQWdJQ0JrYVdjZ013b2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSVWIzUmhiRTUxYlZWcGJuUUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmpZMjkxYm5SekxtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklIUnZkR0ZzVG5WdFFubDBaVk5zYVdObE9pQmhZMk52ZFc1MExuUnZkR0ZzVG5WdFFubDBaVk5zYVdObExBb2dJQ0FnWkdsbklEUUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFZHOTBZV3hPZFcxQ2VYUmxVMnhwWTJVS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGalkyOTFiblJ6TG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUhSdmRHRnNSWGgwY21GQmNIQlFZV2RsY3pvZ1lXTmpiM1Z1ZEM1MGIzUmhiRVY0ZEhKaFFYQndVR0ZuWlhNc0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnWVdOamRGOXdZWEpoYlhOZloyVjBJRUZqWTNSVWIzUmhiRVY0ZEhKaFFYQndVR0ZuWlhNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGalkyOTFiblJ6TG1Gc1oyOHVkSE02TVRrS0lDQWdJQzh2SUhSdmRHRnNRWEJ3YzBOeVpXRjBaV1E2SUdGalkyOTFiblF1ZEc5MFlXeEJjSEJ6UTNKbFlYUmxaQ3dLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRlJ2ZEdGc1FYQndjME55WldGMFpXUUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmpZMjkxYm5SekxtRnNaMjh1ZEhNNk1qQUtJQ0FnSUM4dklIUnZkR0ZzUVhCd2MwOXdkR1ZrU1c0NklHRmpZMjkxYm5RdWRHOTBZV3hCY0hCelQzQjBaV1JKYml3S0lDQWdJR1JwWnlBM0NpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEZSdmRHRnNRWEJ3YzA5d2RHVmtTVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHWjFibVJsWkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZqWTI5MWJuUnpMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJSFJ2ZEdGc1FYTnpaWFJ6UTNKbFlYUmxaRG9nWVdOamIzVnVkQzUwYjNSaGJFRnpjMlYwYzBOeVpXRjBaV1FzQ2lBZ0lDQmthV2NnT0FvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JVYjNSaGJFRnpjMlYwYzBOeVpXRjBaV1FLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHWjFibVJsWkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZqWTI5MWJuUnpMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJSFJ2ZEdGc1FYTnpaWFJ6T2lCaFkyTnZkVzUwTG5SdmRHRnNRWE56WlhSekxBb2dJQ0FnWkdsbklEa0tJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFZHOTBZV3hCYzNObGRITUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmpZMjkxYm5SekxtRnNaMjh1ZEhNNk1qTUtJQ0FnSUM4dklIUnZkR0ZzUW05NFpYTTZJR0ZqWTI5MWJuUXVkRzkwWVd4Q2IzaGxjeXdLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JVYjNSaGJFSnZlR1Z6Q2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWTJOdmRXNTBjeTVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUIwYjNSaGJFSnZlRUo1ZEdWek9pQmhZMk52ZFc1MExuUnZkR0ZzUW05NFFubDBaWE1zQ2lBZ0lDQmthV2NnTVRFS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wVkc5MFlXeENiM2hDZVhSbGN3b2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXTmpiM1Z1ZEhNdVlXeG5ieTUwY3pveU5Rb2dJQ0FnTHk4Z2FYTlBjSFJKYmtGd2NEb2dZV05qYjNWdWRDNXBjMDl3ZEdWa1NXNG9SMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbGtLU3dLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGNIQmZiM0IwWldSZmFXNEtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFkyTnZkVzUwY3k1aGJHZHZMblJ6T2pJMkNpQWdJQ0F2THlCcGMwOXdkRWx1UVhOelpYUTZJR0ZqWTI5MWJuUXVhWE5QY0hSbFpFbHVLR0Z6YzJWMEtTd0tJQ0FnSUdScFp5QXhNd29nSUNBZ2RXNWpiM1psY2lBeE5Rb2dJQ0FnWVhOelpYUmZhRzlzWkdsdVoxOW5aWFFnUVhOelpYUkNZV3hoYm1ObENpQWdJQ0JqYjNabGNpQXhOUW9nSUNBZ2NHOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllXTmpiM1Z1ZEhNdVlXeG5ieTUwY3pveE1TMHlOd29nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdZbmwwWlhNNklHRmpZMjkxYm5RdVlubDBaWE1zQ2lBZ0lDQXZMeUFnSUdKaGJHRnVZMlU2SUdGalkyOTFiblF1WW1Gc1lXNWpaU3dLSUNBZ0lDOHZJQ0FnYldsdVFtRnNZVzVqWlRvZ1lXTmpiM1Z1ZEM1dGFXNUNZV3hoYm1ObExBb2dJQ0FnTHk4Z0lDQmhkWFJvUVdSa2NtVnpjem9nWVdOamIzVnVkQzVoZFhSb1FXUmtjbVZ6Y3k1aWVYUmxjeXdLSUNBZ0lDOHZJQ0FnZEc5MFlXeE9kVzFWYVc1ME9pQmhZMk52ZFc1MExuUnZkR0ZzVG5WdFZXbHVkQ3dLSUNBZ0lDOHZJQ0FnZEc5MFlXeE9kVzFDZVhSbFUyeHBZMlU2SUdGalkyOTFiblF1ZEc5MFlXeE9kVzFDZVhSbFUyeHBZMlVzQ2lBZ0lDQXZMeUFnSUhSdmRHRnNSWGgwY21GQmNIQlFZV2RsY3pvZ1lXTmpiM1Z1ZEM1MGIzUmhiRVY0ZEhKaFFYQndVR0ZuWlhNc0NpQWdJQ0F2THlBZ0lIUnZkR0ZzUVhCd2MwTnlaV0YwWldRNklHRmpZMjkxYm5RdWRHOTBZV3hCY0hCelEzSmxZWFJsWkN3S0lDQWdJQzh2SUNBZ2RHOTBZV3hCY0hCelQzQjBaV1JKYmpvZ1lXTmpiM1Z1ZEM1MGIzUmhiRUZ3Y0hOUGNIUmxaRWx1TEFvZ0lDQWdMeThnSUNCMGIzUmhiRUZ6YzJWMGMwTnlaV0YwWldRNklHRmpZMjkxYm5RdWRHOTBZV3hCYzNObGRITkRjbVZoZEdWa0xBb2dJQ0FnTHk4Z0lDQjBiM1JoYkVGemMyVjBjem9nWVdOamIzVnVkQzUwYjNSaGJFRnpjMlYwY3l3S0lDQWdJQzh2SUNBZ2RHOTBZV3hDYjNobGN6b2dZV05qYjNWdWRDNTBiM1JoYkVKdmVHVnpMQW9nSUNBZ0x5OGdJQ0IwYjNSaGJFSnZlRUo1ZEdWek9pQmhZMk52ZFc1MExuUnZkR0ZzUW05NFFubDBaWE1zQ2lBZ0lDQXZMeUFnSUdselQzQjBTVzVCY0hBNklHRmpZMjkxYm5RdWFYTlBjSFJsWkVsdUtFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1SlpDa3NDaUFnSUNBdkx5QWdJR2x6VDNCMFNXNUJjM05sZERvZ1lXTmpiM1Z1ZEM1cGMwOXdkR1ZrU1c0b1lYTnpaWFFwTEFvZ0lDQWdMeThnZlFvZ0lDQWdkVzVqYjNabGNpQXhNZ29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeE13b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFeUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV05qYjNWdWRITXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QndkV0pzYVdNZ1oyVjBRV05qYjNWdWRFbHVabThvWVdOamIzVnVkRG9nUVdOamIzVnVkQ3dnWVhOelpYUTZJRUZ6YzJWMEtTQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURrNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVdOamIzVnVkSE11WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FXTmpiM1Z1ZEhORGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQVFBbUFRTUdnUUV4RzBFQTVERVpGRVF4R0VTQ0FnUUszdVdmQlBZcFE5RTJHZ0NPQWdBREFBRUFJa00yR2dGSkZZRWdFa1EyR2dKSkZZRUlFa1FYZ1lJTE1nd05RUUFXc1lFR3NoQ0JCYklaS0xJZUtMSWZJN0lCczBMLzRVeEpjd0JFU3dGekFVUkxBbk1DUkVzRGN3TkVTd1J6QkVSTEJYTUZSRXNHY3daRVN3ZHpCMFJMQ0hNSVJFc0pjd2xFU3dwekNrUkxDM01MUkVzTU1naGhTdzFQRDNBQVRnOUlUd3dXVHcxTVVFOE1GbEJQQzFCUENoWlFUd2tXVUU4SUZsQlBCeFpRVHdZV1VFOEZGbEJQQkJaUVR3TVdVRThDRmxDQUFRQWpUd05VSWs4RFZGQ0FCQlVmZkhWTVVMQWlRekVaRkRFWUZCQkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
